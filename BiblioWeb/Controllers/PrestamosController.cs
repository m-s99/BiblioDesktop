﻿using System;
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
    public class PrestamosController : Controller
    {
        private readonly BiblioWebContext _context;

        public PrestamosController(BiblioWebContext context)
        {
            _context = context;
        }

        // GET: Prestamos
        public async Task<IActionResult> Index()
        {
            var biblioWebContext = _context.Prestamos.Include(p => p.Socio).Include(p => p.Usuario);
            return View(await biblioWebContext.ToListAsync());
        }

        // GET: Prestamos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamos
                .Include(p => p.Socio)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // GET: Prestamos/Create
        public IActionResult Create()
        {
            ViewData["SocioId"] = new SelectList(_context.Socios, "Id", "Apellido");
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre");
            return View();
        }

        // POST: Prestamos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaRetiro,FechaEntrega,SocioId,IdLibro,LibroDevuelto,UsuarioId,FechaHoraEliminacion,Eliminado")] Prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestamo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SocioId"] = new SelectList(_context.Socios, "Id", "Apellido", prestamo.SocioId);
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", prestamo.UsuarioId);
            return View(prestamo);
        }

        // GET: Prestamos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null)
            {
                return NotFound();
            }
            ViewData["SocioId"] = new SelectList(_context.Socios, "Id", "Apellido", prestamo.SocioId);
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", prestamo.UsuarioId);
            return View(prestamo);
        }

        // POST: Prestamos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaRetiro,FechaEntrega,SocioId,IdLibro,LibroDevuelto,UsuarioId,FechaHoraEliminacion,Eliminado")] Prestamo prestamo)
        {
            if (id != prestamo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestamoExists(prestamo.Id))
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
            ViewData["SocioId"] = new SelectList(_context.Socios, "Id", "Apellido", prestamo.SocioId);
            ViewData["UsuarioId"] = new SelectList(_context.Set<Usuario>(), "Id", "Nombre", prestamo.UsuarioId);
            return View(prestamo);
        }

        // GET: Prestamos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamos
                .Include(p => p.Socio)
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // POST: Prestamos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            _context.Prestamos.Remove(prestamo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestamoExists(int id)
        {
            return _context.Prestamos.Any(e => e.Id == id);
        }
    }
}
