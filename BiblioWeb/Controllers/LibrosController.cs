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
    public class LibrosController : Controller
    {
        private readonly BiblioWebContext _context;

        public LibrosController(BiblioWebContext context)
        {
            _context = context;
        }

        // GET: Libros
        public async Task<IActionResult> Index()
        {
            var biblioWebContext = _context.Libros.Include(l => l.Tematica).Include(l => l.Usuario);
            return View(await biblioWebContext.ToListAsync());
        }

        // GET: Libros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libros
                .Include(l => l.Tematica)
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // GET: Libros/Create
        public IActionResult Create()
        {
            ViewData["TematicaId"] = new SelectList(_context.Tematicas, "Id", "Nombre");
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre");
            return View();
        }

        // POST: Libros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CodigoInterno,Titulo,Autor,Editorial,Disponible,Imagen,TematicaId,UsuarioId,FechaHoraEliminacion,Eliminado")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(libro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TematicaId"] = new SelectList(_context.Tematicas, "Id", "Nombre", libro.TematicaId);
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", libro.UsuarioId);
            return View(libro);
        }

        // GET: Libros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libros.FindAsync(id);
            if (libro == null)
            {
                return NotFound();
            }
            ViewData["TematicaId"] = new SelectList(_context.Tematicas, "Id", "Nombre", libro.TematicaId);
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", libro.UsuarioId);
            return View(libro);
        }

        // POST: Libros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CodigoInterno,Titulo,Autor,Editorial,Disponible,Imagen,TematicaId,UsuarioId,FechaHoraEliminacion,Eliminado")] Libro libro)
        {
            if (id != libro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(libro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LibroExists(libro.Id))
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
            ViewData["TematicaId"] = new SelectList(_context.Tematicas, "Id", "Nombre", libro.TematicaId);
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", libro.UsuarioId);
            return View(libro);
        }

        // GET: Libros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = await _context.Libros
                .Include(l => l.Tematica)
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // POST: Libros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LibroExists(int id)
        {
            return _context.Libros.Any(e => e.Id == id);
        }
    }
}
