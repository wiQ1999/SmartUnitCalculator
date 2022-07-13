using Microsoft.AspNetCore.Mvc.Rendering;
using SmartUnitCalculator.Database.Models;

namespace SmartUnitCalculator.Controllers.ViewModels;
public class CalculationViewModel
{
    public List<string>? UnitTypes { get; set; }
    public string? Type { get; set; }
    public SelectList? BaseUnits { get; set; }
    public string? BaseUnit { get; set; }
    public decimal BaseValue { get; set; }
    public SelectList? ResultUnits { get; set; }
    public string? ResultUnit { get; set; }
    public decimal ResultValue { get; set; }
    public List<History>? History { get; set; }
}
