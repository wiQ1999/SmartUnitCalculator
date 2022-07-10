using Microsoft.AspNetCore.Mvc;
using SmartUnitCalculator.Database;
using SmartUnitCalculator.Database.Models;
using SmartUnitCalculator.Models;
using System.Diagnostics;

namespace SmartUnitCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        //    using (var context = new DatabaseContext())
        //    {
        //        //var godz = new Unit() { Name = "Godzina", Symbol = "Godz", Type = UnitType.Time };
        //        //context.Units.Add(godz);
        //        //context.SaveChanges();
        //        //var min = new Unit() { Name = "Minuta", Symbol = "Min", Type = UnitType.Time };
        //        //context.Units.Add(min);
        //        //context.SaveChanges();
        //        var godz = context.Units.First(u => u.Id == 3);
        //        var min = context.Units.First(u => u.Id == 4);
        //        var calculation = new Calculation() { BaseUnit = godz, ResultUnit = min, Multiplier = 60m };
        //        context.Calculations.Add(calculation);
        //        context.SaveChanges();
        //        var history = new History() { Calculation = calculation, BaseValue = 4.5m, ResultValue = 270m };
        //        context.History.Add(history);
        //        context.SaveChanges();
        //    }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}