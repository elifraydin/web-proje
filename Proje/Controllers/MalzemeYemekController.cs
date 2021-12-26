using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proje.Data;
using Proje.Models;

namespace Proje.Controllers
{
    public class MalzemeYemekController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MalzemeYemekController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MalzemeYemek
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MalzemeYemek.Include(m => m.Malzeme).Include(m => m.Yemek);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MalzemeYemek/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var malzemeYemek = await _context.MalzemeYemek
                .Include(m => m.Malzeme)
                .Include(m => m.Yemek)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (malzemeYemek == null)
            {
                return NotFound();
            }

            return View(malzemeYemek);
        }

        // GET: MalzemeYemek/Create
        public IActionResult Create()
        {
            ViewData["MalzemeId"] = new SelectList(_context.Malzeme, "Id", "Id");
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id");
            return View();
        }

        // POST: MalzemeYemek/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MalzemeMiktari,YemekId,MalzemeId")] MalzemeYemek malzemeYemek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(malzemeYemek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MalzemeId"] = new SelectList(_context.Malzeme, "Id", "Id", malzemeYemek.MalzemeId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", malzemeYemek.YemekId);
            return View(malzemeYemek);
        }

        // GET: MalzemeYemek/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var malzemeYemek = await _context.MalzemeYemek.FindAsync(id);
            if (malzemeYemek == null)
            {
                return NotFound();
            }
            ViewData["MalzemeId"] = new SelectList(_context.Malzeme, "Id", "Id", malzemeYemek.MalzemeId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", malzemeYemek.YemekId);
            return View(malzemeYemek);
        }

        // POST: MalzemeYemek/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MalzemeMiktari,YemekId,MalzemeId")] MalzemeYemek malzemeYemek)
        {
            if (id != malzemeYemek.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(malzemeYemek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MalzemeYemekExists(malzemeYemek.Id))
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
            ViewData["MalzemeId"] = new SelectList(_context.Malzeme, "Id", "Id", malzemeYemek.MalzemeId);
            ViewData["YemekId"] = new SelectList(_context.Yemek, "Id", "Id", malzemeYemek.YemekId);
            return View(malzemeYemek);
        }

        // GET: MalzemeYemek/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var malzemeYemek = await _context.MalzemeYemek
                .Include(m => m.Malzeme)
                .Include(m => m.Yemek)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (malzemeYemek == null)
            {
                return NotFound();
            }

            return View(malzemeYemek);
        }

        // POST: MalzemeYemek/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var malzemeYemek = await _context.MalzemeYemek.FindAsync(id);
            _context.MalzemeYemek.Remove(malzemeYemek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MalzemeYemekExists(int id)
        {
            return _context.MalzemeYemek.Any(e => e.Id == id);
        }
    }
}
