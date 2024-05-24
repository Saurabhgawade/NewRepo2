using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cab_Management_System.Data;
using Cab_Management_System.Models;
using Microsoft.AspNetCore.Identity;

namespace Cab_Management_System.Controllers
{
    public class CabsController : Controller
    {
        private readonly Cab_Management_SystemContext _context;
       

        public CabsController(Cab_Management_SystemContext context)
        {
            _context = context;
        }

        // GET: Cabs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cab.ToListAsync());
        }

        // GET: Cabs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cab = await _context.Cab
                .FirstOrDefaultAsync(m => m.CabId == id);
            if (cab == null)
            {
                return NotFound();
            }

            return View(cab);
        }

        // GET: Cabs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cabs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CabId,From,Too,Amount")] Cab cab)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cab);
        }

        // GET: Cabs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cab = await _context.Cab.FindAsync(id);
            if (cab == null)
            {
                return NotFound();
            }
            return View(cab);
        }

        // POST: Cabs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CabId,From,Too,Amount")] Cab cab)
        {
            if (id != cab.CabId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cab);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CabExists(cab.CabId))
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
            return View(cab);
        }

        // GET: Cabs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cab = await _context.Cab
                .FirstOrDefaultAsync(m => m.CabId == id);
            if (cab == null)
            {
                return NotFound();
            }

            return View(cab);
        }

        // POST: Cabs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cab = await _context.Cab.FindAsync(id);
            if (cab != null)
            {
                _context.Cab.Remove(cab);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CabExists(int id)
        {
            return _context.Cab.Any(e => e.CabId == id);
        }
    }
}
