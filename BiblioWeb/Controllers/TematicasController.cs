using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BiblioWeb.Data;
using BiblioWeb.Models;

namespace BiblioWeb.Controllers
{
    public class TematicasController : Controller
    {
        private readonly BiblioWebContext _context;

        public TematicasController(BiblioWebContext context)
        {
            _context = context;
        }

        // GET: Tematicas
        public async Task<IActionResult> Index()
        {
            var biblioWebContext = _context.Tematicas.Include(t => t.Usuario);
            return View(await biblioWebContext.ToListAsync());
        }

        // GET: Tematicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tematica = await _context.Tematicas
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tematica == null)
            {
                return NotFound();
            }

            return View(tematica);
        }

        // GET: Tematicas/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre");
            return View();
        }

        // POST: Tematicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,UsuarioId,FechaHoraEliminacion,Eliminado")] Tematica tematica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tematica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", tematica.UsuarioId);
            return View(tematica);
        }

        // GET: Tematicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tematica = await _context.Tematicas.FindAsync(id);
            if (tematica == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", tematica.UsuarioId);
            return View(tematica);
        }

        // POST: Tematicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,UsuarioId,FechaHoraEliminacion,Eliminado")] Tematica tematica)
        {
            if (id != tematica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tematica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TematicaExists(tematica.Id))
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
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", tematica.UsuarioId);
            return View(tematica);
        }

        // GET: Tematicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tematica = await _context.Tematicas
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tematica == null)
            {
                return NotFound();
            }

            return View(tematica);
        }

        // POST: Tematicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tematica = await _context.Tematicas.FindAsync(id);
            _context.Tematicas.Remove(tematica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TematicaExists(int id)
        {
            return _context.Tematicas.Any(e => e.Id == id);
        }
    }
}
