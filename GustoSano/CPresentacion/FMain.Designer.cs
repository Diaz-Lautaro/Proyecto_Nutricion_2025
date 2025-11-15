namespace GustoSano
{
    partial class FMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu = new GustoSano.LDControles.LDPanel();
            this.btnAbrirMenu = new GustoSano.LDControles.LDButton();
            this.pnlFunciones = new GustoSano.LDControles.LDPanel();
            this.btnReporte = new GustoSano.LDControles.LDButton();
            this.btnGrafico = new GustoSano.LDControles.LDButton();
            this.btnAgenda = new GustoSano.LDControles.LDButton();
            this.btnConfiguracion = new GustoSano.LDControles.LDButton();
            this.btnComida = new GustoSano.LDControles.LDButton();
            this.btnReceta = new GustoSano.LDControles.LDButton();
            this.btnHisClinica = new GustoSano.LDControles.LDButton();
            this.btnPacientes = new GustoSano.LDControles.LDButton();
            this.btnSalir = new GustoSano.LDControles.LDButton();
            this.pnlMenu.SuspendLayout();
            this.pnlFunciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContenedor.Location = new System.Drawing.Point(88, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1112, 660);
            this.pnlContenedor.TabIndex = 14;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BorderRadius = 50;
            this.pnlMenu.Controls.Add(this.btnAbrirMenu);
            this.pnlMenu.ForeColor = System.Drawing.Color.Black;
            this.pnlMenu.GradientAngle = 90F;
            this.pnlMenu.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlMenu.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlMenu.Location = new System.Drawing.Point(8, 5);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(74, 67);
            this.pnlMenu.TabIndex = 13;
            // 
            // btnAbrirMenu
            // 
            this.btnAbrirMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnAbrirMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnAbrirMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAbrirMenu.BorderRadius = 20;
            this.btnAbrirMenu.BorderSize = 0;
            this.btnAbrirMenu.FlatAppearance.BorderSize = 0;
            this.btnAbrirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirMenu.ForeColor = System.Drawing.Color.White;
            this.btnAbrirMenu.Image = global::GustoSano.Properties.Resources.Menu2;
            this.btnAbrirMenu.Location = new System.Drawing.Point(13, 10);
            this.btnAbrirMenu.Name = "btnAbrirMenu";
            this.btnAbrirMenu.Size = new System.Drawing.Size(49, 47);
            this.btnAbrirMenu.TabIndex = 12;
            this.btnAbrirMenu.TextColor = System.Drawing.Color.White;
            this.btnAbrirMenu.UseVisualStyleBackColor = false;
            this.btnAbrirMenu.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // pnlFunciones
            // 
            this.pnlFunciones.BackColor = System.Drawing.Color.White;
            this.pnlFunciones.BorderRadius = 50;
            this.pnlFunciones.Controls.Add(this.btnReporte);
            this.pnlFunciones.Controls.Add(this.btnGrafico);
            this.pnlFunciones.Controls.Add(this.btnAgenda);
            this.pnlFunciones.Controls.Add(this.btnConfiguracion);
            this.pnlFunciones.Controls.Add(this.btnComida);
            this.pnlFunciones.Controls.Add(this.btnReceta);
            this.pnlFunciones.Controls.Add(this.btnHisClinica);
            this.pnlFunciones.Controls.Add(this.btnPacientes);
            this.pnlFunciones.Controls.Add(this.btnSalir);
            this.pnlFunciones.ForeColor = System.Drawing.Color.Black;
            this.pnlFunciones.GradientAngle = 90F;
            this.pnlFunciones.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlFunciones.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlFunciones.Location = new System.Drawing.Point(8, 76);
            this.pnlFunciones.Name = "pnlFunciones";
            this.pnlFunciones.Size = new System.Drawing.Size(74, 578);
            this.pnlFunciones.TabIndex = 2;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnReporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReporte.BorderRadius = 20;
            this.btnReporte.BorderSize = 0;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(13, 332);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(49, 47);
            this.btnReporte.TabIndex = 20;
            this.btnReporte.TextColor = System.Drawing.Color.White;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnGrafico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnGrafico.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGrafico.BorderRadius = 20;
            this.btnGrafico.BorderSize = 0;
            this.btnGrafico.FlatAppearance.BorderSize = 0;
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.ForeColor = System.Drawing.Color.White;
            this.btnGrafico.Image = ((System.Drawing.Image)(resources.GetObject("btnGrafico.Image")));
            this.btnGrafico.Location = new System.Drawing.Point(13, 279);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(49, 47);
            this.btnGrafico.TabIndex = 19;
            this.btnGrafico.TextColor = System.Drawing.Color.White;
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnAgenda.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgenda.BorderRadius = 20;
            this.btnAgenda.BorderSize = 0;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAgenda.Image = global::GustoSano.Properties.Resources.Calendario2;
            this.btnAgenda.Location = new System.Drawing.Point(13, 226);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(49, 47);
            this.btnAgenda.TabIndex = 18;
            this.btnAgenda.TextColor = System.Drawing.Color.White;
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnConfiguracion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnConfiguracion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfiguracion.BorderRadius = 20;
            this.btnConfiguracion.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Image")));
            this.btnConfiguracion.Location = new System.Drawing.Point(13, 385);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(49, 47);
            this.btnConfiguracion.TabIndex = 17;
            this.btnConfiguracion.TextColor = System.Drawing.Color.White;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnComida
            // 
            this.btnComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnComida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnComida.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnComida.BorderRadius = 20;
            this.btnComida.BorderSize = 0;
            this.btnComida.FlatAppearance.BorderSize = 0;
            this.btnComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComida.ForeColor = System.Drawing.Color.White;
            this.btnComida.Image = ((System.Drawing.Image)(resources.GetObject("btnComida.Image")));
            this.btnComida.Location = new System.Drawing.Point(13, 173);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(49, 47);
            this.btnComida.TabIndex = 16;
            this.btnComida.TextColor = System.Drawing.Color.White;
            this.btnComida.UseVisualStyleBackColor = false;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // btnReceta
            // 
            this.btnReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnReceta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnReceta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReceta.BorderRadius = 20;
            this.btnReceta.BorderSize = 0;
            this.btnReceta.FlatAppearance.BorderSize = 0;
            this.btnReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceta.ForeColor = System.Drawing.Color.White;
            this.btnReceta.Image = ((System.Drawing.Image)(resources.GetObject("btnReceta.Image")));
            this.btnReceta.Location = new System.Drawing.Point(13, 120);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(49, 47);
            this.btnReceta.TabIndex = 15;
            this.btnReceta.TextColor = System.Drawing.Color.White;
            this.btnReceta.UseVisualStyleBackColor = false;
            this.btnReceta.Click += new System.EventHandler(this.btnReceta_Click);
            // 
            // btnHisClinica
            // 
            this.btnHisClinica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnHisClinica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnHisClinica.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHisClinica.BorderRadius = 20;
            this.btnHisClinica.BorderSize = 0;
            this.btnHisClinica.FlatAppearance.BorderSize = 0;
            this.btnHisClinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHisClinica.ForeColor = System.Drawing.Color.White;
            this.btnHisClinica.Image = global::GustoSano.Properties.Resources.HistClinica2;
            this.btnHisClinica.Location = new System.Drawing.Point(13, 67);
            this.btnHisClinica.Name = "btnHisClinica";
            this.btnHisClinica.Size = new System.Drawing.Size(49, 47);
            this.btnHisClinica.TabIndex = 14;
            this.btnHisClinica.TextColor = System.Drawing.Color.White;
            this.btnHisClinica.UseVisualStyleBackColor = false;
            this.btnHisClinica.Click += new System.EventHandler(this.btnHisClinica_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnPacientes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPacientes.BorderRadius = 20;
            this.btnPacientes.BorderSize = 0;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Image = global::GustoSano.Properties.Resources.Paciente1;
            this.btnPacientes.Location = new System.Drawing.Point(13, 14);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(49, 47);
            this.btnPacientes.TabIndex = 13;
            this.btnPacientes.TextColor = System.Drawing.Color.White;
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(13, 512);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 47);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1200, 660);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlFunciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlFunciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LDControles.LDPanel pnlFunciones;
        private LDControles.LDButton btnSalir;
        private LDControles.LDPanel pnlMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private LDControles.LDButton btnAbrirMenu;
        private LDControles.LDButton btnReporte;
        private LDControles.LDButton btnGrafico;
        private LDControles.LDButton btnAgenda;
        private LDControles.LDButton btnConfiguracion;
        private LDControles.LDButton btnComida;
        private LDControles.LDButton btnReceta;
        private LDControles.LDButton btnHisClinica;
        private LDControles.LDButton btnPacientes;
    }
}

