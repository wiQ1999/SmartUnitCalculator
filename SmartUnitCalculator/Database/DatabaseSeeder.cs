using Microsoft.EntityFrameworkCore;
using SmartUnitCalculator.Database.Models;

namespace SmartUnitCalculator.Database;
public class DatabaseSeeder
{
    private readonly ModelBuilder _modelBuilder;

    public DatabaseSeeder(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        _modelBuilder.Entity<UnitType>().HasData(
            new() { Name = "Waga", Priority = 10 },
            new() { Name = "Długość", Priority = 20 },
            new() { Name = "Objętość", Priority = 30 },
            new() { Name = "Pamięć", Priority = 40 }
        );

        _modelBuilder.Entity<Unit>().HasData(
            new() { Id = 1, TypeName = "Waga", Name = "miligram", Symbol = "mg", Priority = 10 },
            new() { Id = 2, TypeName = "Waga", Name = "gram", Symbol = "g", Priority = 20 },
            new() { Id = 3, TypeName = "Waga", Name = "dekagram", Symbol = "dag", Priority = 30 },
            new() { Id = 4, TypeName = "Waga", Name = "kilogram", Symbol = "kg", Priority = 40 },
            new() { Id = 5, TypeName = "Waga", Name = "tona", Symbol = "t", Priority = 50 },
            new() { Id = 6, TypeName = "Długość", Name = "milimetr", Symbol = "mm", Priority = 10 },
            new() { Id = 7, TypeName = "Długość", Name = "centrymetr", Symbol = "cm", Priority = 20 },
            new() { Id = 8, TypeName = "Długość", Name = "decymetr", Symbol = "dm", Priority = 30 },
            new() { Id = 9, TypeName = "Długość", Name = "metr", Symbol = "m", Priority = 40 },
            new() { Id = 10, TypeName = "Długość", Name = "kilometr", Symbol = "km", Priority = 50 },
            new() { Id = 11, TypeName = "Objętość", Name = "pikolitr", Symbol = "pl", Priority = 10 },
            new() { Id = 12, TypeName = "Objętość", Name = "mililitr", Symbol = "ml", Priority = 20 },
            new() { Id = 13, TypeName = "Objętość", Name = "litr", Symbol = "l", Priority = 30 },
            new() { Id = 14, TypeName = "Pamięć", Name = "bit", Symbol = "b", Priority = 10 },
            new() { Id = 15, TypeName = "Pamięć", Name = "bajt", Symbol = "B", Priority = 20 },
            new() { Id = 16, TypeName = "Pamięć", Name = "kilobit", Symbol = "Kb", Priority = 30 },
            new() { Id = 17, TypeName = "Pamięć", Name = "kilobajt", Symbol = "KB", Priority = 40 },
            new() { Id = 18, TypeName = "Pamięć", Name = "maegabit", Symbol = "Mb", Priority = 50 },
            new() { Id = 19, TypeName = "Pamięć", Name = "megabajt", Symbol = "MB", Priority = 60 },
            new() { Id = 20, TypeName = "Pamięć", Name = "gigabit", Symbol = "Gb", Priority = 70 },
            new() { Id = 21, TypeName = "Pamięć", Name = "gigabajt", Symbol = "GB", Priority = 80 },
            new() { Id = 22, TypeName = "Pamięć", Name = "terabit", Symbol = "Tb", Priority = 90 },
            new() { Id = 23, TypeName = "Pamięć", Name = "terabajt", Symbol = "TB", Priority = 100 }
        );

        _modelBuilder.Entity<Calculation>().HasData(
            // waga
            new() { Id = 1, BaseUnitId = 1, ResultUnitId = 2, Multiplier = 0.001m },
            new() { Id = 2, BaseUnitId = 1, ResultUnitId = 3, Multiplier = 0.0001m },
            new() { Id = 3, BaseUnitId = 1, ResultUnitId = 4, Multiplier = 0.000001m },
            new() { Id = 4, BaseUnitId = 1, ResultUnitId = 5, Multiplier = 0.000000001m },
            new() { Id = 5, BaseUnitId = 2, ResultUnitId = 1, Multiplier = 1_000m },
            new() { Id = 6, BaseUnitId = 2, ResultUnitId = 3, Multiplier = 0.1m },
            new() { Id = 7, BaseUnitId = 2, ResultUnitId = 4, Multiplier = 0.001m },
            new() { Id = 8, BaseUnitId = 2, ResultUnitId = 5, Multiplier = 0.000001m },
            new() { Id = 9, BaseUnitId = 3, ResultUnitId = 1, Multiplier = 10_000m },
            new() { Id = 10, BaseUnitId = 3, ResultUnitId = 2, Multiplier = 10m },
            new() { Id = 11, BaseUnitId = 3, ResultUnitId = 4, Multiplier = 0.01m },
            new() { Id = 12, BaseUnitId = 3, ResultUnitId = 5, Multiplier = 0.00001m },
            new() { Id = 13, BaseUnitId = 4, ResultUnitId = 1, Multiplier = 1_000_000m },
            new() { Id = 14, BaseUnitId = 4, ResultUnitId = 2, Multiplier = 1_000m },
            new() { Id = 15, BaseUnitId = 4, ResultUnitId = 3, Multiplier = 100m },
            new() { Id = 16, BaseUnitId = 4, ResultUnitId = 5, Multiplier = 0.001m },
            new() { Id = 17, BaseUnitId = 5, ResultUnitId = 1, Multiplier = 1_000_000_000m },
            new() { Id = 18, BaseUnitId = 5, ResultUnitId = 2, Multiplier = 1_000_000m },
            new() { Id = 19, BaseUnitId = 5, ResultUnitId = 3, Multiplier = 100_000m },
            new() { Id = 20, BaseUnitId = 5, ResultUnitId = 4, Multiplier = 1_000m },
            // długość
            new() { Id = 21, BaseUnitId = 6, ResultUnitId = 7, Multiplier = 0.1m },
            new() { Id = 22, BaseUnitId = 6, ResultUnitId = 8, Multiplier = 0.01m },
            new() { Id = 23, BaseUnitId = 6, ResultUnitId = 9, Multiplier = 0.001m },
            new() { Id = 24, BaseUnitId = 6, ResultUnitId = 10, Multiplier = 0.000001m },
            new() { Id = 25, BaseUnitId = 7, ResultUnitId = 6, Multiplier = 10m },
            new() { Id = 26, BaseUnitId = 7, ResultUnitId = 8, Multiplier = 0.1m },
            new() { Id = 27, BaseUnitId = 7, ResultUnitId = 9, Multiplier = 0.01m },
            new() { Id = 28, BaseUnitId = 7, ResultUnitId = 10, Multiplier = 0.00001m },
            new() { Id = 29, BaseUnitId = 8, ResultUnitId = 6, Multiplier = 100m },
            new() { Id = 30, BaseUnitId = 8, ResultUnitId = 7, Multiplier = 10m },
            new() { Id = 31, BaseUnitId = 8, ResultUnitId = 9, Multiplier = 0.1m },
            new() { Id = 32, BaseUnitId = 8, ResultUnitId = 10, Multiplier = 0.0001m },
            new() { Id = 33, BaseUnitId = 9, ResultUnitId = 6, Multiplier = 1_000m },
            new() { Id = 34, BaseUnitId = 9, ResultUnitId = 7, Multiplier = 100m },
            new() { Id = 35, BaseUnitId = 9, ResultUnitId = 8, Multiplier = 10m },
            new() { Id = 36, BaseUnitId = 9, ResultUnitId = 10, Multiplier = 0.001m },
            new() { Id = 37, BaseUnitId = 10, ResultUnitId = 6, Multiplier = 1_000_000m },
            new() { Id = 38, BaseUnitId = 10, ResultUnitId = 7, Multiplier = 100_000m },
            new() { Id = 39, BaseUnitId = 10, ResultUnitId = 8, Multiplier = 10_000m },
            new() { Id = 40, BaseUnitId = 10, ResultUnitId = 9, Multiplier = 1_000m },
            // objętość
            new() { Id = 41, BaseUnitId = 11, ResultUnitId = 12, Multiplier = 0.000000001m },
            new() { Id = 42, BaseUnitId = 11, ResultUnitId = 13, Multiplier = 0.000000000001m },
            new() { Id = 43, BaseUnitId = 12, ResultUnitId = 11, Multiplier = 1_000_000_000m },
            new() { Id = 44, BaseUnitId = 12, ResultUnitId = 13, Multiplier = 0.001m },
            new() { Id = 45, BaseUnitId = 13, ResultUnitId = 11, Multiplier = 1_000_000_000_000m },
            new() { Id = 46, BaseUnitId = 13, ResultUnitId = 12, Multiplier = 1_000m },
            // pamięć
            new() { Id = 47, BaseUnitId = 14, ResultUnitId = 15, Multiplier = 0.125m },
            new() { Id = 48, BaseUnitId = 14, ResultUnitId = 16, Multiplier = 0.001m },
            new() { Id = 49, BaseUnitId = 14, ResultUnitId = 17, Multiplier = 0.000125m },
            new() { Id = 50, BaseUnitId = 14, ResultUnitId = 18, Multiplier = 0.000001m },
            new() { Id = 51, BaseUnitId = 14, ResultUnitId = 19, Multiplier = 0.000000125m },
            new() { Id = 52, BaseUnitId = 14, ResultUnitId = 20, Multiplier = 0.000000001m },
            new() { Id = 53, BaseUnitId = 14, ResultUnitId = 21, Multiplier = 0.000000000125m },
            new() { Id = 54, BaseUnitId = 14, ResultUnitId = 22, Multiplier = 0.000000000001m },
            new() { Id = 55, BaseUnitId = 14, ResultUnitId = 23, Multiplier = 0.000000000000125m },
            new() { Id = 56, BaseUnitId = 15, ResultUnitId = 14, Multiplier = 8m },
            new() { Id = 57, BaseUnitId = 15, ResultUnitId = 16, Multiplier = 0.008m },
            new() { Id = 58, BaseUnitId = 15, ResultUnitId = 17, Multiplier = 0.001m },
            new() { Id = 59, BaseUnitId = 15, ResultUnitId = 18, Multiplier = 0.000008m },
            new() { Id = 60, BaseUnitId = 15, ResultUnitId = 19, Multiplier = 0.000001m },
            new() { Id = 61, BaseUnitId = 15, ResultUnitId = 20, Multiplier = 0.000000008m },
            new() { Id = 62, BaseUnitId = 15, ResultUnitId = 21, Multiplier = 0.000000001m },
            new() { Id = 63, BaseUnitId = 15, ResultUnitId = 22, Multiplier = 0.000000000008m },
            new() { Id = 64, BaseUnitId = 15, ResultUnitId = 23, Multiplier = 0.000000000001m },
            new() { Id = 65, BaseUnitId = 16, ResultUnitId = 14, Multiplier = 1_000m },
            new() { Id = 66, BaseUnitId = 16, ResultUnitId = 15, Multiplier = 125m },
            new() { Id = 67, BaseUnitId = 16, ResultUnitId = 17, Multiplier = 0.125m },
            new() { Id = 68, BaseUnitId = 16, ResultUnitId = 18, Multiplier = 0.001m },
            new() { Id = 69, BaseUnitId = 16, ResultUnitId = 19, Multiplier = 0.000125m },
            new() { Id = 70, BaseUnitId = 16, ResultUnitId = 20, Multiplier = 0.000001m },
            new() { Id = 71, BaseUnitId = 16, ResultUnitId = 21, Multiplier = 0.000000125m },
            new() { Id = 72, BaseUnitId = 16, ResultUnitId = 22, Multiplier = 0.000000001m },
            new() { Id = 73, BaseUnitId = 16, ResultUnitId = 23, Multiplier = 0.000000000125m },
            new() { Id = 74, BaseUnitId = 17, ResultUnitId = 14, Multiplier = 8_000m },
            new() { Id = 75, BaseUnitId = 17, ResultUnitId = 15, Multiplier = 1_000m },
            new() { Id = 76, BaseUnitId = 17, ResultUnitId = 16, Multiplier = 8m },
            new() { Id = 77, BaseUnitId = 17, ResultUnitId = 18, Multiplier = 0.008m },
            new() { Id = 78, BaseUnitId = 17, ResultUnitId = 19, Multiplier = 0.001m },
            new() { Id = 79, BaseUnitId = 17, ResultUnitId = 20, Multiplier = 0.000008m },
            new() { Id = 80, BaseUnitId = 17, ResultUnitId = 21, Multiplier = 0.000001m },
            new() { Id = 81, BaseUnitId = 17, ResultUnitId = 22, Multiplier = 0.000000008m },
            new() { Id = 82, BaseUnitId = 17, ResultUnitId = 23, Multiplier = 0.000000001m },
            new() { Id = 83, BaseUnitId = 18, ResultUnitId = 14, Multiplier = 1_000_000m },
            new() { Id = 84, BaseUnitId = 18, ResultUnitId = 15, Multiplier = 125_000m },
            new() { Id = 85, BaseUnitId = 18, ResultUnitId = 16, Multiplier = 1_000m },
            new() { Id = 86, BaseUnitId = 18, ResultUnitId = 17, Multiplier = 125m },
            new() { Id = 87, BaseUnitId = 18, ResultUnitId = 19, Multiplier = 0.125m },
            new() { Id = 88, BaseUnitId = 18, ResultUnitId = 20, Multiplier = 0.001m },
            new() { Id = 89, BaseUnitId = 18, ResultUnitId = 21, Multiplier = 0.000125m },
            new() { Id = 90, BaseUnitId = 18, ResultUnitId = 22, Multiplier = 0.000001m },
            new() { Id = 91, BaseUnitId = 18, ResultUnitId = 23, Multiplier = 0.000000125m },
            new() { Id = 92, BaseUnitId = 19, ResultUnitId = 14, Multiplier = 8_000_000m },
            new() { Id = 93, BaseUnitId = 19, ResultUnitId = 15, Multiplier = 1_000_000m },
            new() { Id = 94, BaseUnitId = 19, ResultUnitId = 16, Multiplier = 8_000m },
            new() { Id = 95, BaseUnitId = 19, ResultUnitId = 17, Multiplier = 1_000m },
            new() { Id = 96, BaseUnitId = 19, ResultUnitId = 18, Multiplier = 8m },
            new() { Id = 97, BaseUnitId = 19, ResultUnitId = 20, Multiplier = 0.008m },
            new() { Id = 98, BaseUnitId = 19, ResultUnitId = 21, Multiplier = 0.001m },
            new() { Id = 99, BaseUnitId = 19, ResultUnitId = 22, Multiplier = 0.000008m },
            new() { Id = 100, BaseUnitId = 19, ResultUnitId = 23, Multiplier = 0.000001m }
            //           new() { Id = 83, BaseUnitId = 18, ResultUnitId = 14, Multiplier = 1_000_000m },
            //new() { Id = 84, BaseUnitId = 18, ResultUnitId = 15, Multiplier = 125_000m },
            //new() { Id = 85, BaseUnitId = 18, ResultUnitId = 16, Multiplier = 1_000m },
            //new() { Id = 86, BaseUnitId = 18, ResultUnitId = 17, Multiplier = 125m },
            //new() { Id = 87, BaseUnitId = 18, ResultUnitId = 19, Multiplier = 0.125m },
            //new() { Id = 88, BaseUnitId = 18, ResultUnitId = 20, Multiplier = 0.001m },
            //new() { Id = 89, BaseUnitId = 18, ResultUnitId = 21, Multiplier = 0.000125m },
            //new() { Id = 90, BaseUnitId = 18, ResultUnitId = 22, Multiplier = 0.000001m },
            //new() { Id = 91, BaseUnitId = 18, ResultUnitId = 23, Multiplier = 0.000000125m }
        );


        _modelBuilder.Entity<History>().HasData(
            new History() { Id = 1, BaseUnitId = 3, BaseValue = 25m, ResultUnitId = 5, ResultValue = 0.00025m, Created = new DateTime(2022, 7, 2, 12, 51, 2) },
            new History() { Id = 2, BaseUnitId = 3, BaseValue = 25m, ResultUnitId = 4, ResultValue = 0.25m, Created = new DateTime(2022, 7, 2, 12, 51, 59) },
            new History() { Id = 3, BaseUnitId = 4, BaseValue = 1m, ResultUnitId = 2, ResultValue = 1_000m, Created = new DateTime(2022, 7, 3, 9, 30, 51) },
            new History() { Id = 4, BaseUnitId = 4, BaseValue = 1.24m, ResultUnitId = 2, ResultValue = 1_240m, Created = new DateTime(2022, 7, 4, 21, 11, 21) }
        );
    }
}
