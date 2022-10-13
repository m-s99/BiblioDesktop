﻿namespace BiblioDesktop.Presentation
{
    partial class FrmAgregarEditarLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarLibro));
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.LblTematica = new System.Windows.Forms.Label();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAgregarEditarLibro = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.CboTematica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(291, 149);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(176, 23);
            this.TxtAutor.TabIndex = 1;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(291, 100);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(176, 23);
            this.TxtTitulo.TabIndex = 0;
            // 
            // LblTematica
            // 
            this.LblTematica.AutoSize = true;
            this.LblTematica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTematica.Location = new System.Drawing.Point(135, 255);
            this.LblTematica.Name = "LblTematica";
            this.LblTematica.Size = new System.Drawing.Size(78, 21);
            this.LblTematica.TabIndex = 0;
            this.LblTematica.Text = "Temática:";
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEditorial.Location = new System.Drawing.Point(135, 200);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(74, 21);
            this.LblEditorial.TabIndex = 9;
            this.LblEditorial.Text = "Editorial:";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAutor.Location = new System.Drawing.Point(135, 147);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(57, 21);
            this.LblAutor.TabIndex = 10;
            this.LblAutor.Text = "Autor:";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.Location = new System.Drawing.Point(135, 100);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(56, 21);
            this.LblTitulo.TabIndex = 11;
            this.LblTitulo.Text = "Titulo:";
            // 
            // LblAgregarEditarLibro
            // 
            this.LblAgregarEditarLibro.AutoSize = true;
            this.LblAgregarEditarLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAgregarEditarLibro.Location = new System.Drawing.Point(163, 28);
            this.LblAgregarEditarLibro.Name = "LblAgregarEditarLibro";
            this.LblAgregarEditarLibro.Size = new System.Drawing.Size(285, 40);
            this.LblAgregarEditarLibro.TabIndex = 12;
            this.LblAgregarEditarLibro.Text = "Agregar/Editar Libro";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(174, 375);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 49);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(335, 375);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 49);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(291, 202);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(176, 23);
            this.TxtEditorial.TabIndex = 3;
            // 
            // CboTematica
            // 
            this.CboTematica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTematica.FormattingEnabled = true;
            this.CboTematica.Items.AddRange(new object[] {
            "Acción",
            "Arte",
            "Ciencia",
            "Ciencia Ficción",
            "Ciencias humanas y sociales",
            "Cómic y Manga",
            "Diccionarios",
            "Fantasía",
            "Filosofía",
            "Historia",
            "Infantil",
            "Juvenil",
            "Novela Contemporánea",
            "Novela Histórica",
            "Novela Literaria",
            "Novela Romántica",
            "Poesía",
            "Psicología",
            "Religión",
            "Teatro",
            "Terror"});
            this.CboTematica.Location = new System.Drawing.Point(291, 253);
            this.CboTematica.Name = "CboTematica";
            this.CboTematica.Size = new System.Drawing.Size(176, 23);
            this.CboTematica.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(291, 302);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(176, 23);
            this.TxtCodigo.TabIndex = 31;
            // 
            // FrmAgregarEditarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 445);
            this.ControlBox = false;
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboTematica);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblAgregarEditarLibro);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblEditorial);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTematica);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarEditarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Editar Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label LblTematica;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblAgregarEditarLibro;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.ComboBox CboTematica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
    }
}