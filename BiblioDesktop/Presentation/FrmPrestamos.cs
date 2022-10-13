using BiblioDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BiblioDesktop.Presentation;
using BiblioDesktop.ExtensionMethods;
using BiblioDesktop.Interfaces;
using Microsoft.EntityFrameworkCore;
using BiblioDesktop.AdminData;

namespace BiblioDesktop.Presentation
{
    public partial class FrmPrestamos : Form, IFormBase
    {
        DbAdminPrestamos dbAdmin = new DbAdminPrestamos();

        public int? IdEditar { get; set; }
        public string TodosEliminadosTerminados = "Todos";

        public FrmPrestamos()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            if (ChkVerEliminados.Checked) grid.DataSource = dbAdmin.ObtenerEliminados();
            else if (ChkVerTerminados.Checked) 
            { 
                grid.DataSource = dbAdmin.ObtenerTerminados();
                grid.Columns["FechaEntrega"].Visible = true;
            }
            else
            {
                grid.DataSource = dbAdmin.ObtenerTodos();
                grid.Columns["FechaEntrega"].Visible = false;
            }
            grid.OcultarColumnas();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var frmNuevoPrestamo = new FrmAgregarEditarPrestamo();
            frmNuevoPrestamo.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[1];
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (TxtBusqueda.TextLength > 0)
            { 
                if(TodosEliminadosTerminados == "Todos")
                {
                    grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
                }
                else if (TodosEliminadosTerminados == "Eliminados")
                {
                    grid.DataSource = dbAdmin.ObtenerBusquedaEliminados(TxtBusqueda.Text);
                }
                else if (TodosEliminadosTerminados == "Terminados")
                {
                    grid.DataSource = dbAdmin.ObtenerBusquedaTerminados(TxtBusqueda.Text);
                }
            }
            else
                ActualizarGrilla();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var idPrestamoSeleccionado = grid.ObtenerIdSeleccionado();
            var filaAEditar = grid.CurrentRow.Index;
            var frmAgregarEditarPrestamo = new FrmAgregarEditarPrestamo(idPrestamoSeleccionado);
            frmAgregarEditarPrestamo.ShowDialog();
            ActualizarGrilla();
            grid.CurrentCell = grid.Rows[filaAEditar].Cells[1];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var idPrestamoSeleccionado = grid.ObtenerIdSeleccionado();
            DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea {BtnEliminar.Text}? ", $"{BtnEliminar.Text}", MessageBoxButtons
                .YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar Prestamo")
            {
                dbAdmin.Eliminar(idPrestamoSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Restaurar Prestamo")
            {
                dbAdmin.Restaurar(idPrestamoSeleccionado);
                ActualizarGrilla();
            }
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
            {
                // grid.DataSource = dbAdmin.ObtenerEliminados();
                ActualizarGrilla();
                BtnEliminar.Text = "Restaurar Prestamo";
                ChkVerTerminados.Enabled = false;
                TodosEliminadosTerminados = "Eliminados";
                BtnAgregar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnFinalizar.Enabled = false;

            }
            else
            {
                BtnEliminar.Text = "Eliminar Prestamo";
                ChkVerTerminados.Enabled = true;
                ActualizarGrilla();
                TodosEliminadosTerminados = "Todos";
                BtnAgregar.Enabled = true;
                BtnEditar.Enabled = true;
                BtnFinalizar.Enabled = true;
            }
        }

        private void ChkVerTerminados_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVerTerminados.Checked)
            {
                //grid.DataSource = dbAdmin.ObtenerTerminados();
                ActualizarGrilla();
                BtnFinalizar.Text = "Revertir Prestamo";
                ChkVerEliminados.Enabled = false;
                TodosEliminadosTerminados = "Terminados";
                BtnAgregar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
            else
            {
                BtnFinalizar.Text = "Finalizar Prestamo";
                ChkVerEliminados.Enabled = true;
                ActualizarGrilla();
                TodosEliminadosTerminados = "Todos";
                BtnAgregar.Enabled = true;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var idPrestamoSeleccionado = grid.ObtenerIdSeleccionado();
            DialogResult respuesta = MessageBox.Show($"¿Estás seguro que desea {BtnFinalizar.Text}? ", $"{BtnFinalizar.Text}", MessageBoxButtons
                .YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && BtnFinalizar.Text == "Finalizar Prestamo")
            {
                dbAdmin.FinalizarPrestamo(idPrestamoSeleccionado);
                ActualizarGrilla();
            }
            if (respuesta == DialogResult.Yes && BtnFinalizar.Text == "Revertir Prestamo")
            {
                var idLibro = grid.ObtenerIdLibro();
                DbAdminLibros dbAdminLibros = new DbAdminLibros();
                Libro libro = (Libro)dbAdminLibros.Obtener(idLibro);
                if (libro.Disponible) 
                {
                    dbAdmin.RevertirPrestamo(idPrestamoSeleccionado);
                    ActualizarGrilla();
                }
                else 
                {
                    MessageBox.Show("No se puede realizar esta acción porque hay un prestamo vigente con este libro");
                }
                
            }
        }
    }
}
