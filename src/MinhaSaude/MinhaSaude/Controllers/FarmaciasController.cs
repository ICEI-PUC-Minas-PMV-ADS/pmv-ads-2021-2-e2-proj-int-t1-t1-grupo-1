using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Farmacia farmacia)
        {
            var farm = await _context.Farmacias
                .FirstOrDefaultAsync(m => m.Email == farmacia.Email);

            if (farm == null)
            {
                ViewBag.Message = "Email e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(farmacia.Senha, farm.Senha);

            if (isSenhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, farm.Email)
                };

                var farmIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(farmIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddMinutes(5),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }
            else
            {
                ViewBag.Message = "Funcionário válido!";
                return View();
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return Redirect("/");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }


        // GET: Farmacias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Farmacias.ToListAsync());
        }

        // GET: Farmacias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var farmacia = await _context.Farmacias
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
                farmacia.Senha = BCrypt.Net.BCrypt.HashPassword(farmacia.Senha);
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

            var farmacia = await _context.Farmacias.FindAsync(id);
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
                    farmacia.Senha = BCrypt.Net.BCrypt.HashPassword(farmacia.Senha);
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

            var farmacia = await _context.Farmacias
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
            var farmacia = await _context.Farmacias.FindAsync(id);
            _context.Farmacias.Remove(farmacia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FarmaciaExists(int id)
        {
            return _context.Farmacias.Any(e => e.Id == id);
        }
    }
}
