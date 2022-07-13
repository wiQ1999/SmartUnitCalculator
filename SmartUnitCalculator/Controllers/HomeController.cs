using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartUnitCalculator.Controllers.ViewModels;
using SmartUnitCalculator.Database;
using SmartUnitCalculator.Database.Models;
using SmartUnitCalculator.Models;
using System.Diagnostics;

namespace SmartUnitCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string type, string baseUnit, decimal baseValue, string resultUnit, decimal resultValue)
        {
            SelectList baseUnits;
            SelectList resultUnits;
            if (type is null)
            {
                baseUnits = new(_context.Units);
                resultUnits = new(_context.Units);
            }
            else
            {
                baseUnits = new(_context.Units.Where(u => u.Type.Name == type).Select(u => u.Name));
                resultUnits = new(_context.Units.Where(u => u.Type.Name == type && u.Name != baseUnit));
            }

            Calculation test = _context.Calculations.FirstOrDefault(c => c.Id == 3);
            Calculation calculation = _context.Calculations.Where(c => c.ResultUnit.Name == baseUnit && c.ResultUnit.Name == resultUnit).FirstOrDefault();
            decimal result = 0;
            if (test is not null)
                result = baseValue * (decimal)test.Multiplier;

            List<string> unitTypes = new(_context.UnitTypes.Select(ut => ut.Name).ToList());
            CalculationViewModel viewModel = new()
            {
                UnitTypes = unitTypes,
                Type = string.IsNullOrEmpty(type)
                    ? unitTypes.FirstOrDefault() : type,
                BaseUnits = baseUnits,
                BaseUnit = baseUnit,
                BaseValue = baseValue,
                ResultUnits = resultUnits,
                ResultUnit = resultUnit,
                ResultValue = result,
                History = _context.History.ToList()
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test(string type, string baseUnit, decimal baseValue, string resultUnit, decimal resultValue)
        {
            SelectList baseUnits;
            SelectList resultUnits;
            if (type is null)
            {
                baseUnits = new(_context.Units);
                resultUnits = new(_context.Units);
            }
            else
            {
                baseUnits = new(_context.Units.Where(u => u.Type.Name == type).Select(u => u.Name));
                resultUnits = new(_context.Units.Where(u => u.Type.Name == type && u.Name != baseUnit));
            }

            Calculation test = _context.Calculations.FirstOrDefault(c => c.Id == 3);
            Calculation calculation = _context.Calculations.Where(c => c.ResultUnit.Name == baseUnit && c.ResultUnit.Name == resultUnit).FirstOrDefault();
            decimal result = 0;
            if (test is not null)
                result = baseValue * (decimal)test.Multiplier;

            List<string> unitTypes = new(_context.UnitTypes.Select(ut => ut.Name).ToList());
            CalculationViewModel viewModel = new()
            {
                UnitTypes = unitTypes,
                Type = string.IsNullOrEmpty(type)
                    ? unitTypes.FirstOrDefault() : type,
                BaseUnits = baseUnits,
                BaseUnit = baseUnit,
                BaseValue = baseValue,
                ResultUnits = resultUnits,
                ResultUnit = resultUnit,
                ResultValue = result,
                History = _context.History.ToList()
            };
            return View(viewModel);
        }

        public IActionResult TestWu(string type, string baseUnit, decimal baseValue, string resultUnit, decimal resultValue)
        {
            SelectList baseUnits;
            SelectList resultUnits;
            if (type is null)
            {
                baseUnits = new(_context.Units);
                resultUnits = new(_context.Units);
            }
            else
            {
                baseUnits = new(_context.Units.Where(u => u.Type.Name == type).Select(u => u.Name));
                resultUnits = new(_context.Units.Where(u => u.Type.Name == type && u.Name != baseUnit));
            }

            Calculation test = _context.Calculations.FirstOrDefault(c => c.Id == 3);
            Calculation calculation = _context.Calculations.Where(c => c.ResultUnit.Name == baseUnit && c.ResultUnit.Name == resultUnit).FirstOrDefault();
            decimal result = 0;
            if (test is not null)
                result = baseValue * (decimal)test.Multiplier;

            List<string> unitTypes = new(_context.UnitTypes.Select(ut => ut.Name).ToList());
            CalculationViewModel viewModel = new()
            {
                UnitTypes = unitTypes,
                Type = string.IsNullOrEmpty(type)
                    ? unitTypes.FirstOrDefault() : type,
                BaseUnits = baseUnits,
                BaseUnit = baseUnit,
                BaseValue = baseValue,
                ResultUnits = resultUnits,
                ResultUnit = resultUnit,
                ResultValue = result,
                History = _context.History.ToList()
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}