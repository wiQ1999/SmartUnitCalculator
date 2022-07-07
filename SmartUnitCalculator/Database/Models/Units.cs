using System.Collections.Generic;

namespace SmartUnitCalculator.Database.Models;
public class Unit
{
    public string Name { get; set; }
    public string Symbol { get; set; }
    public UnitType Type { get; set; }
    public ICollection<Calculation> Calculations { get; set; }
}
