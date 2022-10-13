using BiblioDesktop.AdminData;
using BiblioDesktop.ExtensionMethods;
using BiblioDesktop.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BiblioDesktop.Presentation
{
    public partial class FrmSeleccionar : Form
    {
        FrmAgregarEditarPrestamo frmAgregarEditarPrestamo;
        DbAdminSocios dbAdminSocios = new DbAdminSocios();
        string busqueda;
        public FrmSeleccionar(FrmAgregarEditarPrestamo form,string tipoBusqueda)
        {
            InitializeComponent();
            frmAgregarEditarPrestamo = form;
            busqueda = tipoBusqueda;
            CargarDataGrid();
        }

        private void CargarDataGrid()
        {
            if(busqueda == "Socio")
            {
                LblTitulo.Text = "Socios";
                LblBuscar.Text = "Buscar Socio: ";
                grid.DataSource = dbAdminSocios.ObtenerTodos();
                grid.OcultarColumnas();
            }
            else
            {
                LblTitulo.Text = "Libros";
                LblBuscar.Text = "Buscar Libro: ";
                //DbAdminLibros dbAdminLibros = new DbAdminLibros();
                //grid.DataSource = dbAdminLibros.ObtenerTodos();
                using var db = new BiblioDesktopContext();
                var listaLibros = from libro in db.Libros
                                  select new { id = libro.Id, Nombre = libro.Titulo, Editorial = libro.Editorial, Autor = libro.Autor, disponible = libro.Disponible,Eliminado = libro.Eliminado };
                grid.DataSource = listaLibros.Where(c => c.disponible == true && c.Eliminado == false).ToList();
                grid.OcultarColumnas();
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            var idSeleccionado = grid.ObtenerIdSeleccionado();
            if (busqueda == "Socio")
            {
                frmAgregarEditarPrestamo.IdSocio = idSeleccionado;
            }
            else
            {
                frmAgregarEditarPrestamo.IdLibro = idSeleccionado;
            }
            
            
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (busqueda == "Socio")
            {
                grid.DataSource = dbAdminSocios.ObtenerTodos(TxtBusqueda.Text);
            }
            else
            {
                using var db = new BiblioDesktopContext();
                var listaLibros = from libro in db.Libros
                                  select new { id = libro.Id, Nombre = libro.Titulo, Editorial = libro.Editorial, Autor = libro.Autor, disponible = libro.Disponible, Eliminado = libro.Eliminado };
                grid.DataSource = listaLibros.Where(c => c.Nombre.Contains(TxtBusqueda.Text) && c.disponible == true && c.Eliminado == false).ToList();
            }
        }
    }
}
