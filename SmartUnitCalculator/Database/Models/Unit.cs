namespace SmartUnitCalculator.Database.Models;
public class Unit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public UnitType Type { get; set; }
    public ICollection<Calculation> Calculations { get; set; }
}
