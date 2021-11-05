using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RadioServer.Data;
using RadioServer.Models;

namespace RadioServer.Controllers
{
    public class RadioStationsController : Controller
    {
        private readonly RadioDbContext _context;

        public RadioStationsController(RadioDbContext context)
        {
            _context = context;
        }

        // GET: RadioStations
        public async Task<IActionResult> Index()
        {
            return View(await _context.RadioStations.ToListAsync());
        }

        // GET: RadioStations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radioStations = await _context.RadioStations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radioStations == null)
            {
                return NotFound();
            }

            return View(radioStations);
        }

        // GET: RadioStations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RadioStations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StationName,StationUrl,IconUrl")] RadioStations radioStations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radioStations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radioStations);
        }

        // GET: RadioStations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radioStations = await _context.RadioStations.FindAsync(id);
            if (radioStations == null)
            {
                return NotFound();
            }
            return View(radioStations);
        }

        // POST: RadioStations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StationName,StationUrl,IconUrl")] RadioStations radioStations)
        {
            if (id != radioStations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radioStations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadioStationsExists(radioStations.Id))
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
            return View(radioStations);
        }

        // GET: RadioStations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radioStations = await _context.RadioStations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (radioStations == null)
            {
                return NotFound();
            }

            return View(radioStations);
        }

        // POST: RadioStations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var radioStations = await _context.RadioStations.FindAsync(id);
            _context.RadioStations.Remove(radioStations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadioStationsExists(int id)
        {
            return _context.RadioStations.Any(e => e.Id == id);
        }
    }
}
