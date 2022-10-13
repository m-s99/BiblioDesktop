using BiblioDesktop.Interfaces;
using BiblioDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioDesktop.AdminData
{
    class DbAdminPrestamos : IDbAdmin
    {
        public void Actualizar(object prestamo)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Entry(prestamo).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(object prestamo)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            db.Prestamos.Add((Prestamo)prestamo);
            db.SaveChanges();
        }

        public void Eliminar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamo = db.Prestamos.Find(idSeleccionado);

            prestamo.Eliminado = true;
            prestamo.FechaHoraEliminacion = DateTime.Now;
            prestamo.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(prestamo).State = EntityState.Modified;
            var libro = db.Libros.Find(prestamo.IdLibro);
            libro.Disponible = true;
            db.Entry(libro).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Prestamos.Find(idObtener);
        }
        public IEnumerable<Prestamo> Obtener()
        {
            //instanciamos un objeto DbContext
            using BiblioDesktopContext db = new BiblioDesktopContext();
            return db.Prestamos.Where(c => c.Eliminado == false && c.LibroDevuelto == false);
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamosAListar = from prestamo in db.Prestamos
                                   join libro in db.Libros
                                   on prestamo.IdLibro equals libro.Id
                                   select new
                                   {
                                       Id = prestamo.Id,
                                       Nombre = prestamo.Socio.Nombre + " " + prestamo.Socio.Apellido,
                                       NombreLibro = libro.Titulo,
                                       FechaRetiro = prestamo.FechaRetiro,
                                       FechaEntrega = prestamo.FechaEntrega,
                                       LibroDevuelto = prestamo.LibroDevuelto,
                                       Eliminado = prestamo.Eliminado
                                   };
            return prestamosAListar.Where(c => c.Eliminado == true).ToList();
        }

        public IEnumerable<object> ObtenerTerminados()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamosAListar = from prestamo in db.Prestamos
                                   join libro in db.Libros
                                   on prestamo.IdLibro equals libro.Id
                                   select new
                                   {
                                       Id = prestamo.Id,
                                       IdLibro = prestamo.IdLibro,
                                       Nombre = prestamo.Socio.Nombre + " " + prestamo.Socio.Apellido,
                                       NombreLibro = libro.Titulo,
                                       FechaRetiro = prestamo.FechaRetiro,
                                       FechaEntrega = prestamo.FechaEntrega,
                                       LibroDevuelto = prestamo.LibroDevuelto,
                                       Eliminado = prestamo.Eliminado
                                   };
            return prestamosAListar.Where(c => c.LibroDevuelto == true).ToList();
        }
        public IEnumerable<object> ObtenerTodos()
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamosAListar = from prestamo in db.Prestamos
                                   join libro in db.Libros
                                   on prestamo.IdLibro equals libro.Id
                                   select new
                                   {
                                       Id = prestamo.Id,
                                       Nombre = prestamo.Socio.Nombre + " " + prestamo.Socio.Apellido,
                                       NombreLibro = libro.Titulo,
                                       FechaRetiro = prestamo.FechaRetiro,
                                       FechaEntrega = prestamo.FechaEntrega,
                                       LibroDevuelto = prestamo.LibroDevuelto,
                                       Eliminado = prestamo.Eliminado
                                   };
            return prestamosAListar.Where(c => c.Eliminado == false && c.LibroDevuelto == false).ToList();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using BiblioDesktopContext db = new BiblioDesktopContext();
            ////consultamos en la cadena buscada si contiene la expresion
            var prestamosAListar = from prestamo in db.Prestamos
                                   join libro in db.Libros
                                   on prestamo.IdLibro equals libro.Id
                                   select new
                                   {
                                       Id = prestamo.Id, 
                                       Nombre = prestamo.Socio.Nombre + " " + prestamo.Socio.Apellido,
                                       NombreLibro = libro.Titulo,
                                       FechaRetiro = prestamo.FechaRetiro,
                                       FechaEntrega = prestamo.FechaEntrega,
                                       LibroDevuelto = prestamo.LibroDevuelto,
                                       Eliminado = prestamo.Eliminado
                                   };
            return prestamosAListar.Where(c => c.Nombre.Contains(cadenaBuscada) && c.LibroDevuelto == false && c.Eliminado == false || c.NombreLibro.Contains(cadenaBuscada) && c.LibroDevuelto == false && c.Eliminado == false).ToList();

        }

        public IEnumerable<object> ObtenerBusquedaTerminados(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using BiblioDesktopContext db = new BiblioDesktopContext();
            ////consultamos en la cadena buscada si contiene la expresion
            var prestamosAListar = from prestamo in db.Prestamos
                                   join libro in db.Libros
                                   on prestamo.IdLibro equals libro.Id
                                   select new
                                   {
                                       Id = prestamo.Id,
                                       Nombre = prestamo.Socio.Nombre + " " + prestamo.Socio.Apellido,
                                       NombreLibro = libro.Titulo,
                                       FechaRetiro = prestamo.FechaRetiro,
                                       FechaEntrega = prestamo.FechaEntrega,
                                       LibroDevuelto = prestamo.LibroDevuelto,
                                       Eliminado = prestamo.Eliminado
                                   };
            return prestamosAListar.Where(c => c.Nombre.Contains(cadenaBuscada) && c.LibroDevuelto == true && c.Eliminado == false || c.NombreLibro.Contains(cadenaBuscada) && c.LibroDevuelto == true && c.Eliminado == false).ToList();

        }

        public IEnumerable<object> ObtenerBusquedaEliminados(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using BiblioDesktopContext db = new BiblioDesktopContext();
            ////consultamos en la cadena buscada si contiene la expresion
            var prestamosAListar = from prestamo in db.Prestamos
                                   join libro in db.Libros
                                   on prestamo.IdLibro equals libro.Id
                                   select new
                                   {
                                       Id = prestamo.Id,
                                       Nombre = prestamo.Socio.Nombre + " " + prestamo.Socio.Apellido,
                                       NombreLibro = libro.Titulo,
                                       FechaRetiro = prestamo.FechaRetiro,
                                       FechaEntrega = prestamo.FechaEntrega,
                                       LibroDevuelto = prestamo.LibroDevuelto,
                                       Eliminado = prestamo.Eliminado
                                   };
            return prestamosAListar.Where(c => c.Nombre.Contains(cadenaBuscada) && c.Eliminado == true || c.NombreLibro.Contains(cadenaBuscada) && c.Eliminado == true).ToList();

        }
        public void Restaurar(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamo = db.Prestamos.IgnoreQueryFilters().FirstOrDefault(c => c.Id == idSeleccionado);
            prestamo.Eliminado = false;
            db.Entry(prestamo).State = EntityState.Modified;
            var libro = db.Libros.Find(prestamo.IdLibro);
            libro.Disponible = false;
            db.Entry(libro).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void FinalizarPrestamo(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamo = db.Prestamos.Find(idSeleccionado);
            prestamo.LibroDevuelto = true;
            prestamo.FechaEntrega = DateTime.Now.Date;
            db.Entry(prestamo).State = EntityState.Modified;
            var libro = db.Libros.Find(prestamo.IdLibro);
            libro.Disponible = true;
            db.Entry(libro).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void RevertirPrestamo(int idSeleccionado)
        {
            using BiblioDesktopContext db = new BiblioDesktopContext();
            var prestamo = db.Prestamos.Find(idSeleccionado);
            prestamo.LibroDevuelto = false;
            db.Entry(prestamo).State = EntityState.Modified;
            var libro = db.Libros.Find(prestamo.IdLibro);
            libro.Disponible = false;
            db.Entry(libro).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
