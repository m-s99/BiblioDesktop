using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;
using BiblioDesktop.Models;
using System.Linq;
using BiblioDesktop.Core;
using System.Drawing;
using BiblioDesktop.Interfaces;
using BiblioDesktop.AdminData;
using BiblioDesktop.ExtensionMethods;

namespace BiblioDesktop.Presentation
{
    public partial class FrmAgregarEditarLibro : Form
    {
        DbAdminLibros dbAdmin = new DbAdminLibros();
        public int? IdEditar { get; set; }
        Libro libro = new Libro();

        public FrmAgregarEditarLibro()
        {
            InitializeComponent();
            LlenarCboTematica();
        }
        public FrmAgregarEditarLibro(int idLibroSeleccionado)
        {
            InitializeComponent();
            LlenarCboTematica();
            if (IdEditar != 0)
            {
                IdEditar = idLibroSeleccionado;
                CargarDatosDelLibro();
            }
        }

        private void CargarDatosDelLibro()
        {
            using var db = new BiblioDesktopContext();
            {
                libro = db.Libros.Find(IdEditar);
                TxtTitulo.Text = libro.Titulo;
                TxtEditorial.Text = libro.Editorial;
                TxtAutor.Text = libro.Autor;
                TxtCodigo.Text = libro.CodigoInterno;
                CboTematica.SelectedValue = libro.TematicaId;
            }
        }

        private void LlenarCboTematica()
        {
            using var db = new BiblioDesktopContext();
            var listaTematica = from tematica in db.Tematicas
                                select new
                                {
                                    id = tematica.Id,
                                    nombre = tematica.Nombre
                                };
            CboTematica.DataSource = listaTematica.ToList();
            CboTematica.DisplayMember = "nombre";
            CboTematica.ValueMember = "Id";
            CboTematica.SelectedIndex = -1;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new BiblioDesktopContext())
            {
                libro.Titulo = TxtTitulo.Text;
                libro.Autor = TxtAutor.Text;
                libro.Editorial = TxtEditorial.Text;
                libro.TematicaId = (int)CboTematica.SelectedValue;
                libro.CodigoInterno = TxtCodigo.Text;
                libro.Disponible = true;
                if (IdEditar == null)
                    dbAdmin.Agregar(libro);
                else
                {
                    dbAdmin.Actualizar(libro);
                }

                db.SaveChanges();
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (libro.Id == 0)
            {
                if (TxtTitulo.Text.Length == 0 && TxtEditorial.Text.Length == 0 && TxtAutor.Text.Length == 0)
                    this.Close();
                else
                {
                    this.MensajeAdvertenciaDeSalida();
                }
            }
            else
            {
                if (CompararDatosFormularioConLosDeBBDD())
                {
                    this.Close();
                }
                else
                {
                    this.MensajeAdvertenciaDeSalida();
                }
            }
            this.Close();
        }

        private bool CompararDatosFormularioConLosDeBBDD()
        {
            return (libro.Titulo == TxtTitulo.Text && libro.Editorial == TxtEditorial.Text && libro.Autor == TxtAutor.Text);
        }
    }
}
