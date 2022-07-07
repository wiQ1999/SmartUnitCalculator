using SmartUnitCalculator.Database.Models;
using System.Data.Entity;

namespace SmartUnitCalculator.Database;
public class Database : DbContext
{
    public DbSet<Unit> Units { get; set; }
    public DbSet<Calculation> Calculations { get; set; }
}
