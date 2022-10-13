using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Windows.Forms;
using BiblioDesktop.Models;
using System.Linq;
using System.Collections.Generic;

namespace BiblioDesktop.Presentation
{
    public partial class FrmAgregarEditarPrestamo : Form
    {
        public int IdSocio { get; set; }
        public int IdLibro { get; set; }
        public int? IdEditar { get; set; }
        Prestamo prestamo = new Prestamo();
        Libro libro = new Libro();
        public FrmAgregarEditarPrestamo()
        {
            InitializeComponent();
            DtpFechaRetiro.Value = DateTime.Now;
            DtpFechaEntrega.Value = DateTime.Now;

        }
        public FrmAgregarEditarPrestamo(int? idPrestamoSeleccionado = null)
        {
            InitializeComponent();
            LlenarCboLibros();
            LlenarCboSocios();
            IdEditar = idPrestamoSeleccionado;
            CargarDatosDelPrestamoEnPantalla();
        }
        private void CargarDatosDelPrestamoEnPantalla()
        {
            using var db = new BiblioDesktopContext();
            prestamo = db.Prestamos.Find(IdEditar);
            CboSocios.SelectedValue = prestamo.SocioId;
            CboLibros.SelectedValue = prestamo.IdLibro;
            DtpFechaRetiro.Value = prestamo.FechaRetiro;
            if (prestamo.FechaEntrega.ToString() != "1/1/0001 00:00:00" )
            {
                DtpFechaEntrega.Value = prestamo.FechaEntrega;
            }
            else DtpFechaEntrega.Value = prestamo.FechaRetiro;
        }

        private void LlenarCboLibros()
        {
            using var db = new BiblioDesktopContext();
            var listaLibros = from libro in db.Libros
                              select new { id = libro.Id, nombre = libro.Titulo,disponible=libro.Disponible,Eliminado = libro.Eliminado };
            CboLibros.DataSource = listaLibros.Where(c=>c.id == IdLibro).ToList();
            CboLibros.DisplayMember = "nombre";
            CboLibros.ValueMember = "id";
        }
        private void LlenarCboSocios()
        {
            using var db = new BiblioDesktopContext();
            var listaSocios = from socio in db.Socios
                              select new { id = socio.Id, nombre =  (socio.Nombre+ " " + socio.Apellido),eliminado = socio.Eliminado};
            CboSocios.DataSource = listaSocios.Where(c=> c.id == IdSocio).ToList();
            CboSocios.DisplayMember = "nombre";
            CboSocios.ValueMember = "id";
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new BiblioDesktopContext())
            {
                prestamo.SocioId = (int)CboSocios.SelectedValue;
                prestamo.IdLibro = (int)CboLibros.SelectedValue;
                prestamo.FechaRetiro = DtpFechaRetiro.Value.Date;
                if (IdEditar == null) 
                {
                    libro = db.Libros.Find((int)CboLibros.SelectedValue);
                    libro.Disponible = false;
                    db.Prestamos.Add(prestamo);
                }
                    
                else
                {
                    libro = db.Libros.Find((int)CboLibros.SelectedValue);
                    libro.Disponible = true;
                    db.Entry(prestamo).State = EntityState.Modified;
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (prestamo.Id == 0)
            {
                if (CboLibros.Text.Length == 0 && CboSocios.Text.Length == 0 && DtpFechaEntrega.Text.Length == 0 && DtpFechaRetiro.Text.Length == 0)
                    this.Close();
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
            else
            {
                if (CompararDatosForumarioConLosDeBBDD())
                {
                    this.Close();
                }
                else
                {
                    PreguntarSiSaleSinGuardar();
                }
            }
        }
        private void PreguntarSiSaleSinGuardar()
        {
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea salir del formulario sin guardar los datos?", "Datos sin Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool CompararDatosForumarioConLosDeBBDD()
        {
            return (prestamo.Libro == CboLibros.SelectedValue && prestamo.Socio == CboSocios.SelectedValue && prestamo.FechaEntrega == DtpFechaEntrega.Value.Date && prestamo.FechaRetiro == DtpFechaRetiro.Value.Date);
        }

        private void BtnBuscarSocio_Click(object sender, EventArgs e)
        {
            FrmSeleccionar frmSeleccionar = new FrmSeleccionar( this, "Socio" );
            frmSeleccionar.ShowDialog();
            LlenarCboSocios();
        }

        private void BtnBuscarlibro_Click(object sender, EventArgs e)
        {
            FrmSeleccionar frmSeleccionar = new FrmSeleccionar(this, "Libro");
            frmSeleccionar.ShowDialog();
            LlenarCboLibros();
        }
    }
}
