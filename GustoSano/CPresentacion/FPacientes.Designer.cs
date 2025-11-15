namespace GustoSano.CPresentacion
{
    partial class FPacientes
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
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new GustoSano.LDControles.LDButton();
            this.btnEliminar = new GustoSano.LDControles.LDButton();
            this.btnCargar = new GustoSano.LDControles.LDButton();
            this.btnModificar = new GustoSano.LDControles.LDButton();
            this.txtBuscarPaciente = new GustoSano.LDControles.LDTextBox();
            this.txtEdad = new GustoSano.LDControles.LDTextBox();
            this.txtNombre = new GustoSano.LDControles.LDTextBox();
            this.txtApellido = new GustoSano.LDControles.LDTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new GustoSano.LDControles.LDTextBox();
            this.txtSexo = new GustoSano.LDControles.LDTextBox();
            this.txtFechaNac = new GustoSano.LDControles.LDTextBox();
            this.ldPanel1 = new GustoSano.LDControles.LDPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.ldPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 59);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 62;
            this.dgvPacientes.Size = new System.Drawing.Size(1051, 298);
            this.dgvPacientes.TabIndex = 0;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(492, 33);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(260, 552);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnCargar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnCargar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCargar.BorderRadius = 20;
            this.btnCargar.BorderSize = 0;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(672, 46);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 40);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.TextColor = System.Drawing.Color.White;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(58, 552);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 40);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarPaciente.BorderColor = System.Drawing.Color.Gray;
            this.txtBuscarPaciente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtBuscarPaciente.BorderRadius = 9;
            this.txtBuscarPaciente.BorderSize = 2;
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarPaciente.Location = new System.Drawing.Point(13, 17);
            this.txtBuscarPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarPaciente.Multiline = false;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarPaciente.PasswordChar = false;
            this.txtBuscarPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPaciente.PlaceholderText = "ID Paciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(434, 35);
            this.txtBuscarPaciente.TabIndex = 1;
            this.txtBuscarPaciente.Texts = "";
            this.txtBuscarPaciente.UnderlinedStyle = false;
            this.txtBuscarPaciente._TextChanged += new System.EventHandler(this.txtBuscarPaciente__TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdad.BorderColor = System.Drawing.Color.Gray;
            this.txtEdad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtEdad.BorderRadius = 9;
            this.txtEdad.BorderSize = 2;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.Black;
            this.txtEdad.Location = new System.Drawing.Point(175, 473);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdad.Multiline = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEdad.PasswordChar = false;
            this.txtEdad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEdad.PlaceholderText = "";
            this.txtEdad.Size = new System.Drawing.Size(250, 35);
            this.txtEdad.TabIndex = 22;
            this.txtEdad.Texts = "";
            this.txtEdad.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderColor = System.Drawing.Color.Gray;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtNombre.BorderRadius = 9;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(175, 389);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(250, 35);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.BorderColor = System.Drawing.Color.Gray;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtApellido.BorderRadius = 9;
            this.txtApellido.BorderSize = 2;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(175, 431);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.Size = new System.Drawing.Size(250, 35);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(551, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Teléfono:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(102, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(463, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha de Nacimiento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(102, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(579, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sexo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(126, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Edad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.BorderColor = System.Drawing.Color.Gray;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtTelefono.BorderRadius = 9;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(627, 476);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(250, 35);
            this.txtTelefono.TabIndex = 25;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSexo.BorderColor = System.Drawing.Color.Gray;
            this.txtSexo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtSexo.BorderRadius = 9;
            this.txtSexo.BorderSize = 2;
            this.txtSexo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.ForeColor = System.Drawing.Color.Black;
            this.txtSexo.Location = new System.Drawing.Point(627, 392);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSexo.Multiline = false;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSexo.PasswordChar = false;
            this.txtSexo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSexo.PlaceholderText = "";
            this.txtSexo.Size = new System.Drawing.Size(250, 35);
            this.txtSexo.TabIndex = 23;
            this.txtSexo.Texts = "";
            this.txtSexo.UnderlinedStyle = false;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaNac.BorderColor = System.Drawing.Color.Gray;
            this.txtFechaNac.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtFechaNac.BorderRadius = 9;
            this.txtFechaNac.BorderSize = 2;
            this.txtFechaNac.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNac.ForeColor = System.Drawing.Color.Black;
            this.txtFechaNac.Location = new System.Drawing.Point(627, 434);
            this.txtFechaNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaNac.Multiline = false;
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaNac.PasswordChar = false;
            this.txtFechaNac.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFechaNac.PlaceholderText = "";
            this.txtFechaNac.Size = new System.Drawing.Size(250, 35);
            this.txtFechaNac.TabIndex = 24;
            this.txtFechaNac.Texts = "";
            this.txtFechaNac.UnderlinedStyle = false;
            // 
            // ldPanel1
            // 
            this.ldPanel1.BackColor = System.Drawing.Color.White;
            this.ldPanel1.BorderRadius = 30;
            this.ldPanel1.Controls.Add(this.btnLimpiar);
            this.ldPanel1.Controls.Add(this.btnCargar);
            this.ldPanel1.ForeColor = System.Drawing.Color.Black;
            this.ldPanel1.GradientAngle = 90F;
            this.ldPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel1.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel1.Location = new System.Drawing.Point(13, 530);
            this.ldPanel1.Name = "ldPanel1";
            this.ldPanel1.Size = new System.Drawing.Size(1042, 108);
            this.ldPanel1.TabIndex = 32;
            // 
            // FPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1075, 650);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.ldPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPacientes";
            this.Text = "FPacientes";
            this.Load += new System.EventHandler(this.FPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ldPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private LDControles.LDTextBox txtBuscarPaciente;
        private LDControles.LDButton btnCargar;
        private LDControles.LDButton btnModificar;
        private LDControles.LDButton btnEliminar;
        private LDControles.LDButton btnLimpiar;
        private LDControles.LDTextBox txtEdad;
        private LDControles.LDTextBox txtNombre;
        private LDControles.LDTextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private LDControles.LDTextBox txtTelefono;
        private LDControles.LDTextBox txtSexo;
        private LDControles.LDTextBox txtFechaNac;
        private LDControles.LDPanel ldPanel1;
    }
}