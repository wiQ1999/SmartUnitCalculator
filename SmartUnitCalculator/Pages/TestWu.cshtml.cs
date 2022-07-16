using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartUnitCalculator.Database;
using SmartUnitCalculator.Database.Models;
using SmartUnitCalculator.Models;

namespace SmartUnitCalculator.Pages
{
    public class TestWuModel : PageModel
    {
        private readonly DatabaseContext _context;
        private decimal _resultValue;

        public CalculatorLists Lists { get; set; }
        
        public double ResultValue => Decimal.ToDouble(_resultValue);

        [BindProperty(SupportsGet = true)]
        public string? Type { get; set; }

        [BindProperty]
        public CalculatorInput Input { get; set; }

        public TestWuModel(DatabaseContext context)
        {
            _context = context;
            Lists = new();
            Input = new();
        }

        public void OnGet()
        {
            InitializeTypeIfEmpty();
            GenerateMainPage();
        }

        private void InitializeTypeIfEmpty()
        {
            if (string.IsNullOrWhiteSpace(Type))
                Type = _context.UnitTypes!.OrderBy(ut => ut.Priority).FirstOrDefault()?.Name;
        }

        private void GenerateMainPage()
        {
            GetUnitTypes();
            GetLastHistory();
            CalculateResultValue();
            GetUnitsSelectLists();
        }

        private void GetUnitTypes() => 
            Lists.UnitTypes = _context.UnitTypes!.OrderBy(ut => ut.Priority);

        private void GetLastHistory() => 
            Lists.History = _context.History!.OrderByDescending(h => h.Created);

        private void CalculateResultValue()
        {
            Calculation calc = _context.Calculations!.FirstOrDefault(c => 
            c.BaseUnitId == Input.BaseUnitId && c.ResultUnitId == Input.ResultUnitId);
            if (calc is not null && calc.Multiplier is not null)
                _resultValue = Input.BaseValue * (decimal)calc.Multiplier;
            else
                _resultValue = Input.BaseValue;
        }

        private void GetUnitsSelectLists()
        {
            IEnumerable<Unit> allUnits = _context.Units!.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(Type))
                allUnits = allUnits.Where(u => u.TypeName == Type);
            if (allUnits.Count() < 2)
                throw new Exception("Za ma³a liczba jednostek do wyœwietlenia.");
            Lists.BaseUnits = new(allUnits, nameof(Unit.Id), nameof(Unit.Name));
            Lists.ResultUnits = new(allUnits, nameof(Unit.Id), nameof(Unit.Name));
            if (allUnits.Any(au => au.Id != Input.BaseUnitId))
            {
                Input.BaseUnitId = allUnits.Last().Id;
                Input.ResultUnitId = allUnits.First().Id;
            }
        }

        public IActionResult OnPost()
        {
            GenerateMainPage();
            SaveCalculation();
            return Page();
        }

        private void SaveCalculation()
        {
            History his = new()
            {
                BaseUnitId = Input.BaseUnitId,
                ResultUnitId = Input.ResultUnitId,
                BaseValue = Input.BaseValue,
                ResultValue = _resultValue
            };
            _context.History!.Add(his);
            _context.SaveChanges();
        }
    }
}
