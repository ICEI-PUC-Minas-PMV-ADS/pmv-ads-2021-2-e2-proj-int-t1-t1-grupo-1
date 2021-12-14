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
    public class CaixinhaDeRemediossController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CaixinhaDeRemediossController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CaixinhaDeRemedioss
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CaixinhaDeRemedioss.Include(t => t.Medicamento);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CaixinhaDeRemedioss/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixinhaDeRemedios = await _context.CaixinhaDeRemedioss
                .Include(c => c.Medicamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caixinhaDeRemedios == null)
            {
                return NotFound();
            }

            return View(caixinhaDeRemedios);
        }

        // GET: CaixinhaDeRemedioss/Create
        public IActionResult Create()
        {
            ViewData["MedicamentoId"] = new SelectList(_context.Medicamentos, "Id", "Nome");
            return View();
        }

        // POST: CaixinhaDeRemedioss/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicamentoId,Quantidade")] CaixinhaDeRemedios caixinhaDeRemedios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caixinhaDeRemedios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MedicamentoId"] = new SelectList(_context.Medicamentos, "Id", "Nome", caixinhaDeRemedios.MedicamentoId);
            return View(caixinhaDeRemedios);
        }

        // GET: CaixinhaDeRemedioss/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixinhaDeRemedios = await _context.CaixinhaDeRemedioss.FindAsync(id);
            if (caixinhaDeRemedios == null)
            {
                return NotFound();
            }
            ViewData["MedicamentoId"] = new SelectList(_context.Medicamentos, "Id", "Nome", caixinhaDeRemedios.MedicamentoId);
            return View(caixinhaDeRemedios);
        }

        // POST: CaixinhaDeRemedioss/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedicamentoId,Quantidade")] CaixinhaDeRemedios caixinhaDeRemedios)
        {
            if (id != caixinhaDeRemedios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caixinhaDeRemedios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaixinhaDeRemediosExists(caixinhaDeRemedios.Id))
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
            ViewData["MedicamentoId"] = new SelectList(_context.Medicamentos, "Id", "Nome", caixinhaDeRemedios.MedicamentoId);
            return View(caixinhaDeRemedios);
        }

        // GET: CaixinhaDeRemedioss/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caixinhaDeRemedios = await _context.CaixinhaDeRemedioss
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caixinhaDeRemedios == null)
            {
                return NotFound();
            }

            return View(caixinhaDeRemedios);
        }

        // POST: CaixinhaDeRemedioss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caixinhaDeRemedios = await _context.CaixinhaDeRemedioss.FindAsync(id);
            _context.CaixinhaDeRemedioss.Remove(caixinhaDeRemedios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaixinhaDeRemediosExists(int id)
        {
            return _context.CaixinhaDeRemedioss.Any(e => e.Id == id);
        }
    }
}
