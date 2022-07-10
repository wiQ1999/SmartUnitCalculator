using Microsoft.EntityFrameworkCore;
using SmartUnitCalculator.Database.Models;

namespace SmartUnitCalculator.Database;
public class DatabaseContext : DbContext
{
    public DbSet<Unit> Units { get; set; }
    public DbSet<Calculation> Calculations { get; set; }
    public DbSet<History> History { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SmartUnitCalculator;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Unit>(unit =>
        {
            unit.HasKey(u => u.Id);
            unit.Property(u => u.Name).IsRequired();
            unit.Property(u => u.Symbol).HasMaxLength(50).IsRequired(false);
            unit.Property(u => u.Type).IsRequired().HasConversion<int>();
        });

        modelBuilder.Entity<Calculation>(calculation =>
        {
            calculation.HasKey(c => c.Id);
            calculation.HasOne(c => c.BaseUnit).WithMany(u => u.Calculations).OnDelete(DeleteBehavior.Cascade);
            calculation.HasOne(c => c.ResultUnit).WithMany().OnDelete(DeleteBehavior.Restrict);
            calculation.Property(c => c.Multiplier).HasPrecision(38, 38);
        });

        modelBuilder.Entity<History>(history =>
        {
            history.HasKey(h => h.Id);
            history.HasOne(h => h.Calculation).WithMany().OnDelete(DeleteBehavior.Restrict).IsRequired(false);
            history.Property(h => h.BaseValue).HasPrecision(38, 38);
            history.Property(h => h.ResultValue).HasPrecision(38, 38);
            history.Property(h => h.Created).HasDefaultValueSql("getdate()");
        });
    }
}
