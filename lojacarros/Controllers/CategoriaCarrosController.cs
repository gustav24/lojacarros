using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lojacarros.Models;

namespace lojacarros.Controllers
{
    public class CategoriaCarrosController : Controller
    {
        private readonly Contexto _context;

        public CategoriaCarrosController(Contexto context)
        {
            _context = context;
        }

        // GET: CategoriaCarros
        public async Task<IActionResult> Index()
        {
            return View(await _context.CategoriasCarros.ToListAsync());
        }

        // GET: CategoriaCarros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaCarro = await _context.CategoriasCarros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaCarro == null)
            {
                return NotFound();
            }

            return View(categoriaCarro);
        }

        // GET: CategoriaCarros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriaCarros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao")] CategoriaCarro categoriaCarro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriaCarro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaCarro);
        }

        // GET: CategoriaCarros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaCarro = await _context.CategoriasCarros.FindAsync(id);
            if (categoriaCarro == null)
            {
                return NotFound();
            }
            return View(categoriaCarro);
        }

        // POST: CategoriaCarros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao")] CategoriaCarro categoriaCarro)
        {
            if (id != categoriaCarro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaCarro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaCarroExists(categoriaCarro.Id))
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
            return View(categoriaCarro);
        }

        // GET: CategoriaCarros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaCarro = await _context.CategoriasCarros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriaCarro == null)
            {
                return NotFound();
            }

            return View(categoriaCarro);
        }

        // POST: CategoriaCarros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaCarro = await _context.CategoriasCarros.FindAsync(id);
            if (categoriaCarro != null)
            {
                _context.CategoriasCarros.Remove(categoriaCarro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaCarroExists(int id)
        {
            return _context.CategoriasCarros.Any(e => e.Id == id);
        }
    }
}
