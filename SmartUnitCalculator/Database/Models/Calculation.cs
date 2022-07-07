namespace SmartUnitCalculator.Database.Models
{
    public class Calculation
    {
        public Unit BaseUnit { get; set; }
        public Unit CalculatedUnit { get; set; }
        public decimal Multiplier { get; set; }
    }
}
