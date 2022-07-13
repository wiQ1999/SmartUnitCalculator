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
            new() { Name = "Temperatura", Priority = 40 },
            new() { Name = "Czas", Priority = 50 }
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
            new() { Id = 10, TypeName = "Objętość", Name = "kilometr", Symbol = "km", Priority = 50 },
            new() { Id = 11, TypeName = "Objętość", Name = "pikolitr", Symbol = "pl", Priority = 10 },
            new() { Id = 12, TypeName = "Objętość", Name = "mililitr", Symbol = "ml", Priority = 20 },
            new() { Id = 13, TypeName = "Objętość", Name = "litr", Symbol = "l", Priority = 30 },
            new() { Id = 14, TypeName = "Temperatura", Name = "Kelwin", Symbol = "K", Priority = 10 },
            new() { Id = 15, TypeName = "Temperatura", Name = "Celsjusz", Symbol = "C", Priority = 20 },
            new() { Id = 16, TypeName = "Temperatura", Name = "Fahrenheit", Symbol = "F", Priority = 30 },
            new() { Id = 17, TypeName = "Czas", Name = "milisekunda", Symbol = "ms", Priority = 10 },
            new() { Id = 18, TypeName = "Czas", Name = "sekunda", Symbol = "sek", Priority = 20 },
            new() { Id = 19, TypeName = "Czas", Name = "minuta", Symbol = "min", Priority = 30 },
            new() { Id = 20, TypeName = "Czas", Name = "godzina", Symbol = "h", Priority = 40 },
            new() { Id = 21, TypeName = "Czas", Name = "doba", Symbol = "d", Priority = 50 }
        );

        _modelBuilder.Entity<Calculation>().HasData(
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
            new() { Id = 20, BaseUnitId = 5, ResultUnitId = 4, Multiplier = 1_000m }
        );

        _modelBuilder.Entity<History>().HasData(
            new History() { Id = 1, BaseUnitId = 3, BaseValue = 25m, ResultUnitId = 5, ResultValue = 0.00025m, Created = new DateTime(2022, 7, 2, 12, 51, 2) },
            new History() { Id = 2, BaseUnitId = 3, BaseValue = 25m, ResultUnitId = 4, ResultValue = 0.25m, Created = new DateTime(2022, 7, 2, 12, 51, 59) },
            new History() { Id = 3, BaseUnitId = 4, BaseValue = 1m, ResultUnitId = 2, ResultValue = 1_000m, Created = new DateTime(2022, 7, 3, 9, 30, 51) },
            new History() { Id = 3, BaseUnitId = 4, BaseValue = 1.24m, ResultUnitId = 2, ResultValue = 1_240m, Created = new DateTime(2022, 7, 4, 21, 11, 21) }
        );
    }
}
