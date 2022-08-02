using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using csharp_boolflix.Database;
using csharp_boolflix.Models;

namespace csharp_boolflix.Controllers
{
    public class ProfiloesController : Controller
    {
        private readonly BoolflixContext _context;

        public ProfiloesController(BoolflixContext context)
        {
            _context = context;
        }

        // GET: Profiloes
        public async Task<IActionResult> Index()
        {
              return _context.Profili != null ? 
                          View(await _context.Profili.ToListAsync()) :
                          Problem("Entity set 'BoolflixContext.Profili'  is null.");
        }

        // GET: Profiloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Profili == null)
            {
                return NotFound();
            }

            var profilo = await _context.Profili
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profilo == null)
            {
                return NotFound();
            }

            return View(profilo);
        }

        // GET: Profiloes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profiloes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeProfilo,Bambino")] Profilo profilo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profilo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profilo);
        }

        // GET: Profiloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Profili == null)
            {
                return NotFound();
            }

            var profilo = await _context.Profili.FindAsync(id);
            if (profilo == null)
            {
                return NotFound();
            }
            return View(profilo);
        }

        // POST: Profiloes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeProfilo,Bambino")] Profilo profilo)
        {
            if (id != profilo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profilo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfiloExists(profilo.Id))
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
            return View(profilo);
        }

        // GET: Profiloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Profili == null)
            {
                return NotFound();
            }

            var profilo = await _context.Profili
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profilo == null)
            {
                return NotFound();
            }

            return View(profilo);
        }

        // POST: Profiloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Profili == null)
            {
                return Problem("Entity set 'BoolflixContext.Profili'  is null.");
            }
            var profilo = await _context.Profili.FindAsync(id);
            if (profilo != null)
            {
                _context.Profili.Remove(profilo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfiloExists(int id)
        {
          return (_context.Profili?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
