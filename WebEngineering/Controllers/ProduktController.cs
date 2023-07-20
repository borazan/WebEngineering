using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebEngineering.Data;
using WebEngineering.Models;

namespace WebEngineering.Controllers
{
    [Authorize]
    public class ProduktController : Controller
    {
        private readonly IdentityContext _context;

        public ProduktController(IdentityContext context)
        {
            _context = context;
        }

        // GET: Produkt
        public async Task<IActionResult> Index()
        {
            return _context.Produkte != null ?
                        View(await _context.Produkte.ToListAsync()) :
                        Problem("Entity set 'IdentityContext.Produkte'  is null.");
        }

        public async Task<IActionResult> InventoryHistory(int? id)
        {
            if (id == null || _context.Produkte == null)
            {
                return NotFound();
            }

            var produkt = await _context.Produkte
                .FirstOrDefaultAsync(m => m.Id == id);

            if (produkt == null)
            {
                return NotFound();
            }

            var bestellungen = await _context.Bestellungen //get all Bestellungen associated with the produkt
                .Where(x => x.ProduktId == produkt.Id)
                .OrderBy(x => x.Date)
                .ToListAsync();

            var lieferungen = await _context.Lieferungen //get all Lieferungen associated with the produkt
                .Where(y => y.ProduktId == produkt.Id)
                .OrderBy(y => y.Date)
                .ToListAsync();


            var mergedList = new List<object>();
            int bestellungIndex = 0;
            int lieferungIndex = 0;


            while (bestellungIndex < bestellungen.Count && lieferungIndex < lieferungen.Count)
            {
                var bestellungDate = bestellungen[bestellungIndex].Date;
                var lieferungDate = lieferungen[lieferungIndex].Date;

                if (bestellungDate <= lieferungDate)
                {
                    mergedList.Add(bestellungen[bestellungIndex]);
                    bestellungIndex++;
                }
                else
                {
                    mergedList.Add(lieferungen[lieferungIndex]);
                    lieferungIndex++;
                }
            }

            // add remaining items
            while (bestellungIndex < bestellungen.Count)
            {
                mergedList.Add(bestellungen[bestellungIndex]);
                bestellungIndex++;
            }

            // add remaining items
            while (lieferungIndex < lieferungen.Count)
            {
                mergedList.Add(lieferungen[lieferungIndex]);
                lieferungIndex++;
            }

            List<Datapoint> datapoints = new List<Datapoint>();
            Datapoint prevDatapoint = new Datapoint()
                {
                    Bestand = 0
                };
            // Bestellung decreases, lieferung increases Bestand.
            foreach (var item in mergedList)
            {
                
                if (item is Bestellung bestellung)
                {
                    Datapoint data = new Datapoint()
                    {
                        Date = bestellung.Date.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds,
                        Bestand = prevDatapoint.Bestand - bestellung.Menge
                    };
                    datapoints.Add(data);
                    prevDatapoint = data;
                }
                else if (item is Lieferung lieferung)
                {
                    Datapoint data = new Datapoint()
                    {
                        Date = lieferung.Date.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds,
                        Bestand = prevDatapoint.Bestand + lieferung.Menge
                    };
                    datapoints.Add(data);
                    prevDatapoint = data;
                }
            }

            ProduktViewModel viewModel = new ProduktViewModel();
            viewModel.Datapoints = datapoints;
            viewModel.Produkt = produkt;
            return View(viewModel);
        }

        public async Task<IActionResult> ProductAverages()
        {
            if (_context.Produkte == null)
            {
                return NotFound();
            }

            var viewModel = new ProduktViewModel();
            var produkte = _context.Produkte.ToList();
            var lieferungAverage = 0;
            var bestellungAverage = 0;

            foreach (Produkt produkt in produkte)
            {
                var produktPlus = new ProduktPlus();

                var bestellungen = await _context.Bestellungen //get all Bestellungen associated with the produkt
                .Where(x => x.ProduktId == produkt.Id)
                .ToListAsync();

                var lieferungen = await _context.Lieferungen //get all Lieferungen associated with the produkt
                .Where(y => y.ProduktId == produkt.Id)
                .ToListAsync();

                int count = 0;
                int total = 0;

                foreach (Bestellung bestellung in bestellungen)
                {
                    count++;
                    total += bestellung.Menge;
                }

                if (total == 0) // catch division by zero
                {
                    bestellungAverage = 0;
                }
                else
                {
                    bestellungAverage = total / count;
                }

                count = 0;
                total = 0;
                foreach (Lieferung lieferung in lieferungen)
                {
                    count++;
                    total += lieferung.Menge;
                }

                if (total == 0) // catch division by zero
                {
                    lieferungAverage = 0;
                }
                else
                {
                    lieferungAverage = total / count;
                }

                produktPlus.Name = produkt.Name;
                produktPlus.LieferungAverage = lieferungAverage;
                produktPlus.BestellungAverage = bestellungAverage;
                viewModel.Produkte.Add(produktPlus);
            }

            return View(viewModel);
        }




        // GET: Produkt/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Produkte == null)
            {
                return NotFound();
            }

            var produkt = await _context.Produkte
                .FirstOrDefaultAsync(m => m.Id == id);

            if (produkt == null)
            {
                return NotFound();
            }

            return View(produkt);
        }

        // GET: Produkt/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produkt/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Produkt produkt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produkt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produkt);
        }

        // GET: Produkt/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produkte == null)
            {
                return NotFound();
            }

            var produkt = await _context.Produkte.FindAsync(id);
            if (produkt == null)
            {
                return NotFound();
            }
            return View(produkt);
        }

        // POST: Produkt/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Produkt produkt)
        {
            if (id != produkt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produkt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProduktExists(produkt.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produkt);
        }

        // GET: Produkt/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Produkte == null)
            {
                return NotFound();
            }

            var produkt = await _context.Produkte
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produkt == null)
            {
                return NotFound();
            }

            return View(produkt);
        }

        // POST: Produkt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Produkte == null)
            {
                return Problem("Entity set 'IdentityContext.Produkte'  is null.");
            }
            var produkt = await _context.Produkte.FindAsync(id);
            if (produkt != null)
            {
                _context.Produkte.Remove(produkt);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProduktExists(int id)
        {
            return (_context.Produkte?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
