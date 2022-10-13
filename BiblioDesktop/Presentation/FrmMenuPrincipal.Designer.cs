
namespace BiblioDesktop
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTematicas = new System.Windows.Forms.Label();
            this.LabelPrestamos = new System.Windows.Forms.Label();
            this.LblSocios = new System.Windows.Forms.Label();
            this.LblLibros = new System.Windows.Forms.Label();
            this.PictureBoxTematicas = new System.Windows.Forms.PictureBox();
            this.PictureBoxPrestamos = new System.Windows.Forms.PictureBox();
            this.PictureBoxSocios = new System.Windows.Forms.PictureBox();
            this.PictureBoxLibros = new System.Windows.Forms.PictureBox();
            this.PbxUsuarios = new System.Windows.Forms.PictureBox();
            this.PictureBoxSalir = new System.Windows.Forms.PictureBox();
            this.PictureBoxConfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTematicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(82, 21);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1212, 187);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LblTematicas);
            this.panel1.Controls.Add(this.LabelPrestamos);
            this.panel1.Controls.Add(this.LblSocios);
            this.panel1.Controls.Add(this.LblLibros);
            this.panel1.Controls.Add(this.PictureBoxTematicas);
            this.panel1.Controls.Add(this.PictureBoxPrestamos);
            this.panel1.Controls.Add(this.PictureBoxSocios);
            this.panel1.Controls.Add(this.PictureBoxLibros);
            this.panel1.Location = new System.Drawing.Point(13, 237);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 395);
            this.panel1.TabIndex = 18;
            // 
            // LblTematicas
            // 
            this.LblTematicas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTematicas.AutoSize = true;
            this.LblTematicas.BackColor = System.Drawing.Color.Transparent;
            this.LblTematicas.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTematicas.Location = new System.Drawing.Point(1042, 326);
            this.LblTematicas.Name = "LblTematicas";
            this.LblTematicas.Size = new System.Drawing.Size(189, 45);
            this.LblTematicas.TabIndex = 25;
            this.LblTematicas.Text = "TEMÁTICAS";
            this.LblTematicas.Click += new System.EventHandler(this.LblTematicas_Click);
            // 
            // LabelPrestamos
            // 
            this.LabelPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelPrestamos.AutoSize = true;
            this.LabelPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrestamos.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPrestamos.Location = new System.Drawing.Point(733, 326);
            this.LabelPrestamos.Name = "LabelPrestamos";
            this.LabelPrestamos.Size = new System.Drawing.Size(201, 45);
            this.LabelPrestamos.TabIndex = 24;
            this.LabelPrestamos.Text = "PRÉSTAMOS";
            this.LabelPrestamos.Click += new System.EventHandler(this.LabelPrestamos_Click);
            // 
            // LblSocios
            // 
            this.LblSocios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblSocios.AutoSize = true;
            this.LblSocios.BackColor = System.Drawing.Color.Transparent;
            this.LblSocios.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSocios.Location = new System.Drawing.Point(464, 326);
            this.LblSocios.Name = "LblSocios";
            this.LblSocios.Size = new System.Drawing.Size(131, 45);
            this.LblSocios.TabIndex = 23;
            this.LblSocios.Text = "SOCIOS";
            this.LblSocios.Click += new System.EventHandler(this.LblSocios_Click);
            // 
            // LblLibros
            // 
            this.LblLibros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblLibros.AutoSize = true;
            this.LblLibros.BackColor = System.Drawing.Color.Transparent;
            this.LblLibros.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLibros.Location = new System.Drawing.Point(158, 326);
            this.LblLibros.Name = "LblLibros";
            this.LblLibros.Size = new System.Drawing.Size(125, 45);
            this.LblLibros.TabIndex = 22;
            this.LblLibros.Text = "LIBROS";
            this.LblLibros.Click += new System.EventHandler(this.LblLibros_Click);
            // 
            // PictureBoxTematicas
            // 
            this.PictureBoxTematicas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBoxTematicas.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxTematicas.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxTematicas.Image")));
            this.PictureBoxTematicas.Location = new System.Drawing.Point(1019, 109);
            this.PictureBoxTematicas.Name = "PictureBoxTematicas";
            this.PictureBoxTematicas.Size = new System.Drawing.Size(234, 188);
            this.PictureBoxTematicas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTematicas.TabIndex = 21;
            this.PictureBoxTematicas.TabStop = false;
            this.PictureBoxTematicas.Click += new System.EventHandler(this.PictureBoxTematicas_Click);
            // 
            // PictureBoxPrestamos
            // 
            this.PictureBoxPrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBoxPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxPrestamos.Image")));
            this.PictureBoxPrestamos.Location = new System.Drawing.Point(711, 109);
            this.PictureBoxPrestamos.Name = "PictureBoxPrestamos";
            this.PictureBoxPrestamos.Size = new System.Drawing.Size(234, 188);
            this.PictureBoxPrestamos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPrestamos.TabIndex = 20;
            this.PictureBoxPrestamos.TabStop = false;
            this.PictureBoxPrestamos.Click += new System.EventHandler(this.PictureBoxPrestamos_Click);
            // 
            // PictureBoxSocios
            // 
            this.PictureBoxSocios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBoxSocios.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxSocios.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSocios.Image")));
            this.PictureBoxSocios.Location = new System.Drawing.Point(407, 109);
            this.PictureBoxSocios.Name = "PictureBoxSocios";
            this.PictureBoxSocios.Size = new System.Drawing.Size(234, 188);
            this.PictureBoxSocios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSocios.TabIndex = 19;
            this.PictureBoxSocios.TabStop = false;
            this.PictureBoxSocios.Click += new System.EventHandler(this.PictureBoxSocios_Click);
            // 
            // PictureBoxLibros
            // 
            this.PictureBoxLibros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBoxLibros.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLibros.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLibros.Image")));
            this.PictureBoxLibros.Location = new System.Drawing.Point(99, 109);
            this.PictureBoxLibros.Name = "PictureBoxLibros";
            this.PictureBoxLibros.Size = new System.Drawing.Size(234, 188);
            this.PictureBoxLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLibros.TabIndex = 18;
            this.PictureBoxLibros.TabStop = false;
            this.PictureBoxLibros.Click += new System.EventHandler(this.PictureBoxLibros_Click);
            // 
            // PbxUsuarios
            // 
            this.PbxUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.PbxUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("PbxUsuarios.Image")));
            this.PbxUsuarios.Location = new System.Drawing.Point(1042, 654);
            this.PbxUsuarios.Name = "PbxUsuarios";
            this.PbxUsuarios.Size = new System.Drawing.Size(105, 83);
            this.PbxUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxUsuarios.TabIndex = 28;
            this.PbxUsuarios.TabStop = false;
            this.PbxUsuarios.Click += new System.EventHandler(this.PbxUsuarios_Click);
            // 
            // PictureBoxSalir
            // 
            this.PictureBoxSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxSalir.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxSalir.ErrorImage = null;
            this.PictureBoxSalir.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSalir.Image")));
            this.PictureBoxSalir.Location = new System.Drawing.Point(1267, 654);
            this.PictureBoxSalir.Name = "PictureBoxSalir";
            this.PictureBoxSalir.Size = new System.Drawing.Size(91, 83);
            this.PictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSalir.TabIndex = 27;
            this.PictureBoxSalir.TabStop = false;
            this.PictureBoxSalir.Click += new System.EventHandler(this.PictureBoxSalir_Click);
            // 
            // PictureBoxConfig
            // 
            this.PictureBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxConfig.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxConfig.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxConfig.Image")));
            this.PictureBoxConfig.Location = new System.Drawing.Point(1153, 654);
            this.PictureBoxConfig.Name = "PictureBoxConfig";
            this.PictureBoxConfig.Size = new System.Drawing.Size(99, 83);
            this.PictureBoxConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxConfig.TabIndex = 26;
            this.PictureBoxConfig.TabStop = false;
            this.PictureBoxConfig.Click += new System.EventHandler(this.PictureBoxConfig_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PbxUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBoxSalir);
            this.Controls.Add(this.PictureBoxConfig);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiblioDesktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTematicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbxUsuarios;
        private System.Windows.Forms.PictureBox PictureBoxSalir;
        private System.Windows.Forms.PictureBox PictureBoxConfig;
        private System.Windows.Forms.Label LblTematicas;
        private System.Windows.Forms.Label LabelPrestamos;
        private System.Windows.Forms.Label LblSocios;
        private System.Windows.Forms.Label LblLibros;
        private System.Windows.Forms.PictureBox PictureBoxTematicas;
        private System.Windows.Forms.PictureBox PictureBoxPrestamos;
        private System.Windows.Forms.PictureBox PictureBoxSocios;
        private System.Windows.Forms.PictureBox PictureBoxLibros;
    }
}

