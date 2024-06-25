using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BiblioWeb.Data;
using BiblioWeb.Models;

namespace BiblioWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class apiTematicasController : ControllerBase
    {
        private readonly BiblioWebContext _context;

        public apiTematicasController(BiblioWebContext context)
        {
            _context = context;
        }

        // GET: api/apiTematicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tematica>>> GetTematica()
        {
            return await _context.Tematicas.ToListAsync();
        }

        // GET: api/apiTematicas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tematica>> GetTematica(int id)
        {
            var tematica = await _context.Tematicas.FindAsync(id);

            if (tematica == null)
            {
                return NotFound();
            }

            return tematica;
        }

        // PUT: api/apiTematicas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTematica(int id, Tematica tematica)
        {
            if (id != tematica.Id)
            {
                return BadRequest();
            }

            _context.Entry(tematica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TematicaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/apiTematicas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tematica>> PostTematica(Tematica tematica)
        {
            _context.Tematicas.Add(tematica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTematica", new { id = tematica.Id }, tematica);
        }

        // DELETE: api/apiTematicas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tematica>> DeleteTematica(int id)
        {
            var tematica = await _context.Tematicas.FindAsync(id);
            if (tematica == null)
            {
                return NotFound();
            }

            _context.Tematicas.Remove(tematica);
            await _context.SaveChangesAsync();

            return tematica;
        }

        private bool TematicaExists(int id)
        {
            return _context.Tematicas.Any(e => e.Id == id);
        }
    }
}
