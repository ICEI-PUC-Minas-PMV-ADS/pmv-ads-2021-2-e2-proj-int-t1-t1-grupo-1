using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MinhaSaude.Data;
using MinhaSaude.Models;

namespace MinhaSaude.Controllers
{
    public class FarmaciasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FarmaciasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Farmacias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Farmacia.ToListAsync());
        }

        // GET: Farmacias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmacia = await _context.Farmacia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (farmacia == null)
            {
                return NotFound();
            }

            return View(farmacia);
        }

        // GET: Farmacias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Farmacias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,NomeFarmacia,Email,Senha,Perfil")] Farmacia farmacia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(farmacia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(farmacia);
        }

        // GET: Farmacias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmacia = await _context.Farmacia.FindAsync(id);
            if (farmacia == null)
            {
                return NotFound();
            }
            return View(farmacia);
        }

        // POST: Farmacias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,NomeFarmacia,Email,Senha,Perfil")] Farmacia farmacia)
        {
            if (id != farmacia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(farmacia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FarmaciaExists(farmacia.Id))
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
            return View(farmacia);
        }

        // GET: Farmacias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmacia = await _context.Farmacia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (farmacia == null)
            {
                return NotFound();
            }

            return View(farmacia);
        }

        // POST: Farmacias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var farmacia = await _context.Farmacia.FindAsync(id);
            _context.Farmacia.Remove(farmacia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FarmaciaExists(int id)
        {
            return _context.Farmacia.Any(e => e.Id == id);
        }
    }
}
