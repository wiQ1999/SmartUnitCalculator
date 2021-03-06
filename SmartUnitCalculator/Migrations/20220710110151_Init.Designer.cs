// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartUnitCalculator.Database;

#nullable disable

namespace SmartUnitCalculator.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220710110151_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.Calculation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BaseUnitId")
                        .HasColumnType("int");

                    b.Property<decimal>("Multiplier")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ResultUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BaseUnitId");

                    b.HasIndex("ResultUnitId");

                    b.ToTable("Calculations");
                });

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.Calculation", b =>
                {
                    b.HasOne("SmartUnitCalculator.Database.Models.Unit", "BaseUnit")
                        .WithMany("Calculations")
                        .HasForeignKey("BaseUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartUnitCalculator.Database.Models.Unit", "ResultUnit")
                        .WithMany()
                        .HasForeignKey("ResultUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BaseUnit");

                    b.Navigation("ResultUnit");
                });

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.Unit", b =>
                {
                    b.Navigation("Calculations");
                });
#pragma warning restore 612, 618
        }
    }
}
