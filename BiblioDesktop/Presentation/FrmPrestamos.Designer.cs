
namespace BiblioDesktop.Presentation
{
    partial class FrmPrestamos
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
            this.LblPrestamos = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.ChkVerTerminados = new System.Windows.Forms.CheckBox();
            this.ChkVerEliminados = new System.Windows.Forms.CheckBox();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPrestamos
            // 
            this.LblPrestamos.AutoSize = true;
            this.LblPrestamos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPrestamos.Location = new System.Drawing.Point(341, 25);
            this.LblPrestamos.Name = "LblPrestamos";
            this.LblPrestamos.Size = new System.Drawing.Size(209, 45);
            this.LblPrestamos.TabIndex = 0;
            this.LblPrestamos.Text = "PRESTAMOS";
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(43, 98);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 25;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(801, 229);
            this.grid.TabIndex = 1;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(251, 372);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(240, 23);
            this.TxtBusqueda.TabIndex = 5;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBuscar.Location = new System.Drawing.Point(43, 363);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(202, 32);
            this.LblBuscar.TabIndex = 4;
            this.LblBuscar.Text = "Buscar Prestamo:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.Location = new System.Drawing.Point(74, 426);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(143, 58);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "Nuevo Prestamo";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.Location = new System.Drawing.Point(653, 426);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(143, 58);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar Prestamo";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(267, 426);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(143, 58);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "Editar Prestamo";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // ChkVerTerminados
            // 
            this.ChkVerTerminados.AutoSize = true;
            this.ChkVerTerminados.BackColor = System.Drawing.Color.Transparent;
            this.ChkVerTerminados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChkVerTerminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChkVerTerminados.Location = new System.Drawing.Point(535, 370);
            this.ChkVerTerminados.Name = "ChkVerTerminados";
            this.ChkVerTerminados.Size = new System.Drawing.Size(141, 25);
            this.ChkVerTerminados.TabIndex = 14;
            this.ChkVerTerminados.Text = "Ver Terminados";
            this.ChkVerTerminados.UseVisualStyleBackColor = false;
            this.ChkVerTerminados.CheckedChanged += new System.EventHandler(this.ChkVerTerminados_CheckedChanged);
            // 
            // ChkVerEliminados
            // 
            this.ChkVerEliminados.AutoSize = true;
            this.ChkVerEliminados.BackColor = System.Drawing.Color.Transparent;
            this.ChkVerEliminados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChkVerEliminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChkVerEliminados.Location = new System.Drawing.Point(682, 370);
            this.ChkVerEliminados.Name = "ChkVerEliminados";
            this.ChkVerEliminados.Size = new System.Drawing.Size(135, 25);
            this.ChkVerEliminados.TabIndex = 15;
            this.ChkVerEliminados.Text = "Ver Eliminados";
            this.ChkVerEliminados.UseVisualStyleBackColor = false;
            this.ChkVerEliminados.CheckedChanged += new System.EventHandler(this.ChkVerEliminados_CheckedChanged);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFinalizar.Location = new System.Drawing.Point(460, 426);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(143, 58);
            this.BtnFinalizar.TabIndex = 16;
            this.BtnFinalizar.Text = "Finalizar Prestamo";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(886, 536);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.ChkVerEliminados);
            this.Controls.Add(this.ChkVerTerminados);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.LblPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPrestamos;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.CheckBox ChkVerTerminados;
        private System.Windows.Forms.CheckBox ChkVerEliminados;
        private System.Windows.Forms.Button BtnFinalizar;
    }
}