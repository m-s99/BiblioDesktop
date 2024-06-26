﻿using System;
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
    public class apiSociosController : ControllerBase
    {
        private readonly BiblioWebContext _context;

        public apiSociosController(BiblioWebContext context)
        {
            _context = context;
        }

        // GET: api/apiSocios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Socio>>> GetSocio()
        {
            return await _context.Socios.ToListAsync();
        }

        // GET: api/apiSocios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Socio>> GetSocio(int id)
        {
            var socio = await _context.Socios.FindAsync(id);

            if (socio == null)
            {
                return NotFound();
            }

            return socio;
        }

        // PUT: api/apiSocios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSocio(int id, Socio socio)
        {
            if (id != socio.Id)
            {
                return BadRequest();
            }

            _context.Entry(socio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SocioExists(id))
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

        // POST: api/apiSocios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Socio>> PostSocio(Socio socio)
        {
            _context.Socios.Add(socio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSocio", new { id = socio.Id }, socio);
        }

        // DELETE: api/apiSocios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Socio>> DeleteSocio(int id)
        {
            var socio = await _context.Socios.FindAsync(id);
            if (socio == null)
            {
                return NotFound();
            }

            _context.Socios.Remove(socio);
            await _context.SaveChangesAsync();

            return socio;
        }

        private bool SocioExists(int id)
        {
            return _context.Socios.Any(e => e.Id == id);
        }
    }
}
