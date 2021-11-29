using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MInhaSaude.Models;

namespace MInhaSaude.Controllers
{
    public class CaixinhaRemediosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CaixinhaRemediosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CaixinhaRemedios
        public async Task<IActionResult> Index()
        {
            return View(await _context.CxRemedios.ToListAsync());
        }

        // GET: CaixinhaRemedios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixinhaRemedio = await _context.CxRemedios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caixinhaRemedio == null)
            {
                return NotFound();
            }

            return View(caixinhaRemedio);
        }

        // GET: CaixinhaRemedios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CaixinhaRemedios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nome,Tipo,Quantidade")] CaixinhaRemedio caixinhaRemedio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caixinhaRemedio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caixinhaRemedio);
        }

        // GET: CaixinhaRemedios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixinhaRemedio = await _context.CxRemedios.FindAsync(id);
            if (caixinhaRemedio == null)
            {
                return NotFound();
            }
            return View(caixinhaRemedio);
        }

        // POST: CaixinhaRemedios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nome,Tipo,Quantidade")] CaixinhaRemedio caixinhaRemedio)
        {
            if (id != caixinhaRemedio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caixinhaRemedio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaixinhaRemedioExists(caixinhaRemedio.Id))
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
            return View(caixinhaRemedio);
        }

        // GET: CaixinhaRemedios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixinhaRemedio = await _context.CxRemedios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caixinhaRemedio == null)
            {
                return NotFound();
            }

            return View(caixinhaRemedio);
        }

        // POST: CaixinhaRemedios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caixinhaRemedio = await _context.CxRemedios.FindAsync(id);
            _context.CxRemedios.Remove(caixinhaRemedio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaixinhaRemedioExists(int id)
        {
            return _context.CxRemedios.Any(e => e.Id == id);
        }
    }
}
