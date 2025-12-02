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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrPanel = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalir = new GustoSano.LDControles.LDButton();
            this.btnPacientes = new GustoSano.LDControles.LDButton();
            this.btnHisClinica = new GustoSano.LDControles.LDButton();
            this.btnReceta = new GustoSano.LDControles.LDButton();
            this.btnComida = new GustoSano.LDControles.LDButton();
            this.btnConfiguracion = new GustoSano.LDControles.LDButton();
            this.btnAgenda = new GustoSano.LDControles.LDButton();
            this.btnGrafico = new GustoSano.LDControles.LDButton();
            this.btnReporte = new GustoSano.LDControles.LDButton();
            this.pnlMenu = new GustoSano.LDControles.LDPanel();
            this.btnAbrirMenu = new GustoSano.LDControles.LDButton();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContenedor.Location = new System.Drawing.Point(88, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1112, 660);
            this.pnlContenedor.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnPacientes);
            this.panel1.Controls.Add(this.btnHisClinica);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnReceta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnComida);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnConfiguracion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAgenda);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnGrafico);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.MaximumSize = new System.Drawing.Size(182, 578);
            this.panel1.MinimumSize = new System.Drawing.Size(62, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 578);
            this.panel1.TabIndex = 0;
            // 
            // tmrPanel
            // 
            this.tmrPanel.Interval = 10;
            this.tmrPanel.Tick += new System.EventHandler(this.tmrPanel_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(58, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 28);
            this.label8.TabIndex = 52;
            this.label8.Text = "Salir";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(58, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 28);
            this.label7.TabIndex = 51;
            this.label7.Text = "Estadística";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(58, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "Hist. clinicas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(58, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Recetas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(58, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Menús";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Agenda";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "Reportes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ajustes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(58, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 28);
            this.label11.TabIndex = 44;
            this.label11.Text = "Pacientes";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSalir.Location = new System.Drawing.Point(5, 514);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 47);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnPacientes.Location = new System.Drawing.Point(5, 16);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(50, 47);
            this.btnPacientes.TabIndex = 13;
            this.btnPacientes.TextColor = System.Drawing.Color.White;
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
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
            this.btnHisClinica.Location = new System.Drawing.Point(5, 69);
            this.btnHisClinica.Name = "btnHisClinica";
            this.btnHisClinica.Size = new System.Drawing.Size(50, 47);
            this.btnHisClinica.TabIndex = 14;
            this.btnHisClinica.TextColor = System.Drawing.Color.White;
            this.btnHisClinica.UseVisualStyleBackColor = false;
            this.btnHisClinica.Click += new System.EventHandler(this.btnHisClinica_Click);
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
            this.btnReceta.Location = new System.Drawing.Point(5, 122);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(50, 47);
            this.btnReceta.TabIndex = 15;
            this.btnReceta.TextColor = System.Drawing.Color.White;
            this.btnReceta.UseVisualStyleBackColor = false;
            this.btnReceta.Click += new System.EventHandler(this.btnReceta_Click);
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
            this.btnComida.Location = new System.Drawing.Point(5, 175);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(50, 47);
            this.btnComida.TabIndex = 16;
            this.btnComida.TextColor = System.Drawing.Color.White;
            this.btnComida.UseVisualStyleBackColor = false;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
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
            this.btnConfiguracion.Location = new System.Drawing.Point(5, 387);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(50, 47);
            this.btnConfiguracion.TabIndex = 17;
            this.btnConfiguracion.TextColor = System.Drawing.Color.White;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
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
            this.btnAgenda.Location = new System.Drawing.Point(5, 228);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(50, 47);
            this.btnAgenda.TabIndex = 18;
            this.btnAgenda.TextColor = System.Drawing.Color.White;
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
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
            this.btnGrafico.Location = new System.Drawing.Point(5, 281);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(50, 47);
            this.btnGrafico.TabIndex = 19;
            this.btnGrafico.TextColor = System.Drawing.Color.White;
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
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
            this.btnReporte.Location = new System.Drawing.Point(5, 334);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(50, 47);
            this.btnReporte.TabIndex = 20;
            this.btnReporte.TextColor = System.Drawing.Color.White;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
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
            this.pnlMenu.Location = new System.Drawing.Point(12, 7);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(62, 62);
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
            this.btnAbrirMenu.Location = new System.Drawing.Point(6, 8);
            this.btnAbrirMenu.Name = "btnAbrirMenu";
            this.btnAbrirMenu.Size = new System.Drawing.Size(50, 47);
            this.btnAbrirMenu.TabIndex = 12;
            this.btnAbrirMenu.TextColor = System.Drawing.Color.White;
            this.btnAbrirMenu.UseVisualStyleBackColor = false;
            this.btnAbrirMenu.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1200, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrPanel;
    }
}

