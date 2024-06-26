﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using BiblioDesktop.Core;
using BiblioDesktop.ExtensionMethods;

namespace BiblioDesktop.Presentation
{
    public partial class FrmParámetros : Form
    {
        Form FrmMenuPrincipal;
        public FrmParámetros(Form form)
        {
            InitializeComponent();
            CargarDatosEnPantalla();
            FrmMenuPrincipal = form;
        }

        private void CargarDatosEnPantalla()
        {
            TxtUsuario.Text= Properties.Settings.Default.usuario;
            TxtServidor.Text = Properties.Settings.Default.servidor;
            TxtBbdd.Text = Properties.Settings.Default.bbdd;
            TxtContraseña.Text = Properties.Settings.Default.contraseña;
            if (Properties.Settings.Default.imagenFondo != "")
            {
               // PbxImagen.Image = Image.FromFile(Properties.Settings.Default.imagenFondo);
                PbxImagen.Image = Helper.RecuperarImagenDeArchivoDeRecursos("fondoSistema");
                TxtImagen.Text = Properties.Settings.Default.imagenFondo;
            }     
        }

        private void BtnGuardarModificar_Click(object sender, EventArgs e)
        {
            if (BtnGuardarModificar.Text == "Modificar")
            {
                BtnGuardarModificar.Text = "Guardar";
                BtnExaminar.Enabled = true;
                this.HabilitarDeshabilitarTextBox(true);
            }
            else
            {
                BtnExaminar.Enabled = false;
                Properties.Settings.Default.usuario = TxtUsuario.Text;
                Properties.Settings.Default.servidor = TxtServidor.Text;
                Properties.Settings.Default.bbdd = TxtBbdd.Text;
                Properties.Settings.Default.contraseña = TxtContraseña.Text;
                Properties.Settings.Default.imagenFondo = TxtImagen.Text;
                Properties.Settings.Default.Save();
                BtnGuardarModificar.Text = "Modificar";
                this.HabilitarDeshabilitarTextBox(false);
                if (Properties.Settings.Default.imagenFondo != "")
                {
                    Helper.AlmacenarImagenEnArchivoDeRecursos(Image.FromFile(Properties.Settings.Default.imagenFondo), "fondoSistema");
                    FrmMenuPrincipal.BackgroundImage = Image.FromFile(Properties.Settings.Default.imagenFondo);
                }
            }
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrirArchivo = new OpenFileDialog();
            string filtro = "Todas las imágenes|*.jpg;*.gif;*.png;*.bmp";
            filtro += "|JPG (*.jpg)|*.jpg";
            filtro += "|GIF* (*.gif)|*.gif";
            filtro += "|PNG* (*.png)|*.png";
            filtro += "|BMP (*.bmp)|*.bmp";
            ofdAbrirArchivo.Filter = filtro;
            ofdAbrirArchivo.ShowDialog();
            if (ofdAbrirArchivo.FileName != "")
            {
                PbxImagen.Image = new Bitmap(ofdAbrirArchivo.FileName);
                TxtImagen.Text = ofdAbrirArchivo.FileName.ToString();
            }
        }
    }
}
