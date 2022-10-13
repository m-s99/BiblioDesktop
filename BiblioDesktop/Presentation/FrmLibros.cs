using BiblioDesktop.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BiblioDesktop.ExtensionMethods;
using BiblioDesktop.Interfaces;
using Microsoft.EntityFrameworkCore;
using BiblioDesktop.AdminData;

namespace BiblioDesktop.Presentation
{
    public partial class FrmLibros : Form
    {
        DbAdminLibros dbAdminLibro = new DbAdminLibros();
        public int? IdEditar { get; set; }

        public FrmLibros()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            if (ChkVerEliminados.Checked)
            {
                using (var db = new BiblioDesktopContext())
                {
                    var librosAListar = from libro in db.Libros
                                        select new
                                        {
                                            Id = libro.Id,
                                            Nombre = libro.Titulo,
                                            Autor = libro.Autor,
                                            Editorial = libro.Editorial,
                                            Tematica = libro.Tematica.Nombre,
                                            Eliminado = libro.Eliminado
                                        };
                    grid.DataSource = librosAListar.IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
                    grid.OcultarColumnas();
                }
            }
            else
            {
                using (var db = new BiblioDesktopContext())
                {
                    var librosAListar = from libro in db.Libros
                                        select new
                                        {
                                            Id = libro.Id,
                                            Nombre = libro.Titulo,
                                            Autor = libro.Autor,
                                            Editorial = libro.Editorial,
                                            Tematica = libro.Tematica.Nombre,
                                            Eliminado = libro.Eliminado,
                                            Disponible = libro.Disponible,
                                            Disponibilidad = libro.Disponibilidad
                                        };
                    grid.DataSource = librosAListar.IgnoreQueryFilters().Where(c => c.Eliminado == false).ToList();
                    grid.OcultarColumnas();
                }
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var frmAgregarLibro = new FrmAgregarEditarLibro();
            frmAgregarLibro.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[1];
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            grid.DataSource = dbAdminLibro.ObtenerTodos(TxtBusqueda.Text);
            grid.OcultarColumnas();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idLibroSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;
            var frmEditarLibro = new FrmAgregarEditarLibro(idLibroSeleccionado);
            frmEditarLibro.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var idLibroSeleccionado = grid.ObtenerIdSeleccionado();
            var tituloLibroSeleccionado = grid.CurrentRow.Cells[1].Value.ToString();
            if (BtnEliminar.Text == "Eliminar Libro") 
            {
                DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea borrar {tituloLibroSeleccionado}?", "Eliminar Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dbAdminLibro.Eliminar(idLibroSeleccionado);
                    ActualizarGrilla();
                }
            }
            else 
            {
                DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea Restaurar {tituloLibroSeleccionado}?", "Restaurar Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    dbAdminLibro.Restaurar(idLibroSeleccionado);
                    ActualizarGrilla();
                }
            }
            
        }

        private void BtnListaLibros_Click(object sender, EventArgs e)
        {
            var frmListaLibros = new FrmListaLibros();
            frmListaLibros.ShowDialog();
            ActualizarGrilla();
        }

        public void CargarDatosEnPantalla()
        {
            throw new NotImplementedException();
        }

        public void LimpiarDatosDeLaPantalla()
        {
            throw new NotImplementedException();
        }

        private void ChkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVerEliminados.Checked)
                BtnEliminar.Text = "Restaurar Libro";
            else
                BtnEliminar.Text = "Eliminar Libro";
            ActualizarGrilla();
        }
    }
}
