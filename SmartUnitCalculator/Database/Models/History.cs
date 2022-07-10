namespace SmartUnitCalculator.Database.Models;
public class History
{
    public int Id { get; set; }
    public Calculation Calculation { get; set; }
    public decimal BaseValue { get; set; }
    public DateTime Created { get; set; }
}
