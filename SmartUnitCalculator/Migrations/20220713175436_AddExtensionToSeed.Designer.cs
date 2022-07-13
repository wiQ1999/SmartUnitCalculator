﻿// <auto-generated />
using System;
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
    [Migration("20220713175436_AddExtensionToSeed")]
    partial class AddExtensionToSeed
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

                    b.Property<decimal?>("Multiplier")
                        .HasPrecision(38, 19)
                        .HasColumnType("decimal(38,19)");

                    b.Property<int>("ResultUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BaseUnitId");

                    b.HasIndex("ResultUnitId");

                    b.ToTable("Calculations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseUnitId = 1,
                            Multiplier = 0.001m,
                            ResultUnitId = 2
                        },
                        new
                        {
                            Id = 2,
                            BaseUnitId = 1,
                            Multiplier = 0.0001m,
                            ResultUnitId = 3
                        },
                        new
                        {
                            Id = 3,
                            BaseUnitId = 1,
                            Multiplier = 0.000001m,
                            ResultUnitId = 4
                        },
                        new
                        {
                            Id = 4,
                            BaseUnitId = 1,
                            Multiplier = 0.000000001m,
                            ResultUnitId = 5
                        },
                        new
                        {
                            Id = 5,
                            BaseUnitId = 2,
                            Multiplier = 1000m,
                            ResultUnitId = 1
                        },
                        new
                        {
                            Id = 6,
                            BaseUnitId = 2,
                            Multiplier = 0.1m,
                            ResultUnitId = 3
                        },
                        new
                        {
                            Id = 7,
                            BaseUnitId = 2,
                            Multiplier = 0.001m,
                            ResultUnitId = 4
                        },
                        new
                        {
                            Id = 8,
                            BaseUnitId = 2,
                            Multiplier = 0.000001m,
                            ResultUnitId = 5
                        },
                        new
                        {
                            Id = 9,
                            BaseUnitId = 3,
                            Multiplier = 10000m,
                            ResultUnitId = 1
                        },
                        new
                        {
                            Id = 10,
                            BaseUnitId = 3,
                            Multiplier = 10m,
                            ResultUnitId = 2
                        },
                        new
                        {
                            Id = 11,
                            BaseUnitId = 3,
                            Multiplier = 0.01m,
                            ResultUnitId = 4
                        },
                        new
                        {
                            Id = 12,
                            BaseUnitId = 3,
                            Multiplier = 0.00001m,
                            ResultUnitId = 5
                        },
                        new
                        {
                            Id = 13,
                            BaseUnitId = 4,
                            Multiplier = 1000000m,
                            ResultUnitId = 1
                        },
                        new
                        {
                            Id = 14,
                            BaseUnitId = 4,
                            Multiplier = 1000m,
                            ResultUnitId = 2
                        },
                        new
                        {
                            Id = 15,
                            BaseUnitId = 4,
                            Multiplier = 100m,
                            ResultUnitId = 3
                        },
                        new
                        {
                            Id = 16,
                            BaseUnitId = 4,
                            Multiplier = 0.001m,
                            ResultUnitId = 5
                        },
                        new
                        {
                            Id = 17,
                            BaseUnitId = 5,
                            Multiplier = 1000000000m,
                            ResultUnitId = 1
                        },
                        new
                        {
                            Id = 18,
                            BaseUnitId = 5,
                            Multiplier = 1000000m,
                            ResultUnitId = 2
                        },
                        new
                        {
                            Id = 19,
                            BaseUnitId = 5,
                            Multiplier = 100000m,
                            ResultUnitId = 3
                        },
                        new
                        {
                            Id = 20,
                            BaseUnitId = 5,
                            Multiplier = 1000m,
                            ResultUnitId = 4
                        });
                });

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BaseUnitId")
                        .HasColumnType("int");

                    b.Property<decimal>("BaseValue")
                        .HasPrecision(38, 19)
                        .HasColumnType("decimal(38,19)");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("ResultUnitId")
                        .HasColumnType("int");

                    b.Property<decimal>("ResultValue")
                        .HasPrecision(38, 19)
                        .HasColumnType("decimal(38,19)");

                    b.HasKey("Id");

                    b.HasIndex("BaseUnitId");

                    b.HasIndex("ResultUnitId");

                    b.ToTable("History");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseUnitId = 3,
                            BaseValue = 25m,
                            Created = new DateTime(2022, 7, 2, 12, 51, 2, 0, DateTimeKind.Unspecified),
                            ResultUnitId = 5,
                            ResultValue = 0.00025m
                        },
                        new
                        {
                            Id = 2,
                            BaseUnitId = 3,
                            BaseValue = 25m,
                            Created = new DateTime(2022, 7, 2, 12, 51, 59, 0, DateTimeKind.Unspecified),
                            ResultUnitId = 4,
                            ResultValue = 0.25m
                        },
                        new
                        {
                            Id = 3,
                            BaseUnitId = 4,
                            BaseValue = 1m,
                            Created = new DateTime(2022, 7, 3, 9, 30, 51, 0, DateTimeKind.Unspecified),
                            ResultUnitId = 2,
                            ResultValue = 1000m
                        });
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

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Symbol")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TypeName");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "miligram",
                            Priority = 10,
                            Symbol = "mg",
                            TypeName = "Waga"
                        },
                        new
                        {
                            Id = 2,
                            Name = "gram",
                            Priority = 20,
                            Symbol = "g",
                            TypeName = "Waga"
                        },
                        new
                        {
                            Id = 3,
                            Name = "dekagram",
                            Priority = 30,
                            Symbol = "dag",
                            TypeName = "Waga"
                        },
                        new
                        {
                            Id = 4,
                            Name = "kilogram",
                            Priority = 40,
                            Symbol = "kg",
                            TypeName = "Waga"
                        },
                        new
                        {
                            Id = 5,
                            Name = "tona",
                            Priority = 50,
                            Symbol = "t",
                            TypeName = "Waga"
                        },
                        new
                        {
                            Id = 6,
                            Name = "milimetr",
                            Priority = 10,
                            Symbol = "mm",
                            TypeName = "Długość"
                        },
                        new
                        {
                            Id = 7,
                            Name = "centrymetr",
                            Priority = 20,
                            Symbol = "cm",
                            TypeName = "Długość"
                        },
                        new
                        {
                            Id = 8,
                            Name = "decymetr",
                            Priority = 30,
                            Symbol = "dm",
                            TypeName = "Długość"
                        },
                        new
                        {
                            Id = 9,
                            Name = "metr",
                            Priority = 40,
                            Symbol = "m",
                            TypeName = "Długość"
                        },
                        new
                        {
                            Id = 10,
                            Name = "kilometr",
                            Priority = 50,
                            Symbol = "km",
                            TypeName = "Objętość"
                        },
                        new
                        {
                            Id = 11,
                            Name = "pikolitr",
                            Priority = 10,
                            Symbol = "pl",
                            TypeName = "Objętość"
                        },
                        new
                        {
                            Id = 12,
                            Name = "mililitr",
                            Priority = 20,
                            Symbol = "ml",
                            TypeName = "Objętość"
                        },
                        new
                        {
                            Id = 13,
                            Name = "litr",
                            Priority = 30,
                            Symbol = "l",
                            TypeName = "Objętość"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Kelwin",
                            Priority = 10,
                            Symbol = "K",
                            TypeName = "Temperatura"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Celsjusz",
                            Priority = 20,
                            Symbol = "C",
                            TypeName = "Temperatura"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Fahrenheit",
                            Priority = 30,
                            Symbol = "F",
                            TypeName = "Temperatura"
                        },
                        new
                        {
                            Id = 17,
                            Name = "milisekunda",
                            Priority = 10,
                            Symbol = "ms",
                            TypeName = "Czas"
                        },
                        new
                        {
                            Id = 18,
                            Name = "sekunda",
                            Priority = 20,
                            Symbol = "sek",
                            TypeName = "Czas"
                        },
                        new
                        {
                            Id = 19,
                            Name = "minuta",
                            Priority = 30,
                            Symbol = "min",
                            TypeName = "Czas"
                        },
                        new
                        {
                            Id = 20,
                            Name = "godzina",
                            Priority = 40,
                            Symbol = "h",
                            TypeName = "Czas"
                        },
                        new
                        {
                            Id = 21,
                            Name = "doba",
                            Priority = 50,
                            Symbol = "d",
                            TypeName = "Czas"
                        });
                });

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.UnitType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("Priority")
                        .IsUnique();

                    b.ToTable("UnitTypes");

                    b.HasData(
                        new
                        {
                            Name = "Waga",
                            Priority = 10
                        },
                        new
                        {
                            Name = "Długość",
                            Priority = 20
                        },
                        new
                        {
                            Name = "Objętość",
                            Priority = 30
                        },
                        new
                        {
                            Name = "Temperatura",
                            Priority = 40
                        },
                        new
                        {
                            Name = "Czas",
                            Priority = 50
                        });
                });

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.Calculation", b =>
                {
                    b.HasOne("SmartUnitCalculator.Database.Models.Unit", "BaseUnit")
                        .WithMany("Calculations")
                        .HasForeignKey("BaseUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmartUnitCalculator.Database.Models.Unit", "ResultUnit")
                        .WithMany()
                        .HasForeignKey("ResultUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BaseUnit");

                    b.Navigation("ResultUnit");
                });

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.History", b =>
                {
                    b.HasOne("SmartUnitCalculator.Database.Models.Unit", "BaseUnit")
                        .WithMany()
                        .HasForeignKey("BaseUnitId")
                        .OnDelete(DeleteBehavior.Restrict)
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
                    b.HasOne("SmartUnitCalculator.Database.Models.UnitType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("SmartUnitCalculator.Database.Models.Unit", b =>
                {
                    b.Navigation("Calculations");
                });
#pragma warning restore 612, 618
        }
    }
}