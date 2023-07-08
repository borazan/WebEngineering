using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebEngineering.Models;

namespace WebEngineering.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            void seedDatabank()
            {
                Produkt produkt1 = new Produkt() { Name = "produkt1" };
                Produkt produkt2 = new Produkt() { Name = "produkt2" };
                Produkt produkt3 = new Produkt() { Name = "produkt3" };

                Bestellung bestellung1 = new Bestellung()
                {
                    Produkt = produkt1,
                    Menge = 20,
                    ProduktId = produkt1.Id,
                    Date = new DateTime(2023, 1, 23, 10, 20, 22)
                };
                Bestellung bestellung2 = new Bestellung()
                {
                    Produkt = produkt2,
                    Menge = 120,
                    ProduktId = produkt2.Id,
                    Date = new DateTime(2023, 1, 25, 17, 26, 10)
                };
                Bestellung bestellung3 = new Bestellung()
                {
                    Produkt = produkt3,
                    Menge = 20,
                    ProduktId = produkt3.Id,
                    Date = new DateTime(2023, 2, 7, 6, 34, 55)
                };

                Lieferung lieferung1 = new Lieferung()
                {
                    Produkt = bestellung1.Produkt,
                    Menge = bestellung1.Menge,
                    ProduktId = bestellung1.ProduktId,
                    Date = new DateTime(2023, 1, 25, 10, 20, 22)
                };

                Lieferung lieferung2 = new Lieferung()
                {
                    Produkt = bestellung2.Produkt,
                    Menge = bestellung2.Menge,
                    ProduktId = produkt2.Id,
                    Date = new DateTime(2023, 1, 27, 17, 26, 10)
                };
                Lieferung lieferung3 = new Lieferung()
                {
                    Produkt = bestellung3.Produkt,
                    Menge = bestellung3.Menge,
                    ProduktId = bestellung3.ProduktId,
                    Date = new DateTime(2023, 2, 9, 6, 34, 55)
                };

                _context.Produkte.Add(produkt1);
                _context.Produkte.Add(produkt2);
                _context.Produkte.Add(produkt3);

                _context.Bestellungen.Add(bestellung1);
                _context.Bestellungen.Add(bestellung2);
                _context.Bestellungen.Add(bestellung3);

                _context.Lieferungen.Add(lieferung1);
                _context.Lieferungen.Add(lieferung2);
                _context.Lieferungen.Add(lieferung3);

                _context.SaveChanges();

            }

            seedDatabank();
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