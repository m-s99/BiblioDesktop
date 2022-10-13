using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BiblioWeb.Models;

namespace BiblioWeb.Data
{
    public class BiblioWebContext : DbContext
    {
        public BiblioWebContext (DbContextOptions<BiblioWebContext> options)
            : base(options)
        {
        }

        public DbSet<BiblioWeb.Models.Libro> Libros { get; set; }

        public DbSet<BiblioWeb.Models.Socio> Socios { get; set; }
    }
}
