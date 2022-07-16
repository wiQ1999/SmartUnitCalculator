using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartUnitCalculator.Database;
using SmartUnitCalculator.Database.Models;

namespace SmartUnitCalculator.Pages
{
    public class TestModel : PageModel
    {
        private readonly DatabaseContext _context;

        public List<UnitType>? UnitTypes { get; set; }
        public UnitType? Type { get; set; }
        public SelectList? BaseUnits { get; set; }
        public string? BaseUnit { get; set; }
        public decimal BaseValue { get; set; }
        public SelectList? ResultUnits { get; set; }
        public string? ResultUnit { get; set; }
        public decimal ResultValue { get; set; }
        public List<History>? History { get; set; }

        public TestModel(DatabaseContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            UnitTypes = _context.UnitTypes.ToList();
            History = _context.History.ToList();
            if (Type is null)
            {
                BaseUnits = new(_context.Units);
                ResultUnits = new(_context.Units);
            }
            else
            {
                BaseUnits = new(_context.Units.Where(u => u.Type.Name == Type.Name).Select(u => u.Name));
                ResultUnits = new(_context.Units.Where(u => u.Type.Name == Type.Name && u.Name != BaseUnit));
            }
            Calculation test = _context.Calculations.FirstOrDefault(c => c.Id == 3);
            if (test is not null)
                ResultValue = BaseValue * (decimal)test.Multiplier;
        }
    }
}
