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
            this.pnlbtn = new GustoSano.LDControles.LDPanel();
            this.btnEliminar = new GustoSano.LDControles.LDButton();
            this.btnCargar = new GustoSano.LDControles.LDButton();
            this.btnModificar = new GustoSano.LDControles.LDButton();
            this.pnlTxt = new GustoSano.LDControles.LDPanel();
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
            this.pnlBuscador = new GustoSano.LDControles.LDPanel();
            this.txtBuscarPaciente = new GustoSano.LDControles.LDTextBox();
            this.btnLimpiar = new GustoSano.LDControles.LDButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.pnlbtn.SuspendLayout();
            this.pnlTxt.SuspendLayout();
            this.pnlBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(13, 93);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(1234, 338);
            this.dgvPacientes.TabIndex = 0;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // pnlbtn
            // 
            this.pnlbtn.BackColor = System.Drawing.Color.White;
            this.pnlbtn.BorderRadius = 30;
            this.pnlbtn.Controls.Add(this.btnLimpiar);
            this.pnlbtn.Controls.Add(this.btnEliminar);
            this.pnlbtn.Controls.Add(this.btnCargar);
            this.pnlbtn.Controls.Add(this.btnModificar);
            this.pnlbtn.ForeColor = System.Drawing.Color.Black;
            this.pnlbtn.GradientAngle = 90F;
            this.pnlbtn.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlbtn.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlbtn.Location = new System.Drawing.Point(10, 667);
            this.pnlbtn.Name = "pnlbtn";
            this.pnlbtn.Size = new System.Drawing.Size(1237, 85);
            this.pnlbtn.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(683, 32);
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
            this.btnCargar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCargar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCargar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCargar.BorderRadius = 20;
            this.btnCargar.BorderSize = 0;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(345, 32);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 40);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextColor = System.Drawing.Color.White;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(514, 32);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 40);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlTxt
            // 
            this.pnlTxt.BackColor = System.Drawing.Color.White;
            this.pnlTxt.BorderRadius = 30;
            this.pnlTxt.Controls.Add(this.txtEdad);
            this.pnlTxt.Controls.Add(this.txtNombre);
            this.pnlTxt.Controls.Add(this.txtApellido);
            this.pnlTxt.Controls.Add(this.label6);
            this.pnlTxt.Controls.Add(this.label1);
            this.pnlTxt.Controls.Add(this.label5);
            this.pnlTxt.Controls.Add(this.label2);
            this.pnlTxt.Controls.Add(this.label4);
            this.pnlTxt.Controls.Add(this.label3);
            this.pnlTxt.Controls.Add(this.txtTelefono);
            this.pnlTxt.Controls.Add(this.txtSexo);
            this.pnlTxt.Controls.Add(this.txtFechaNac);
            this.pnlTxt.ForeColor = System.Drawing.Color.Black;
            this.pnlTxt.GradientAngle = 90F;
            this.pnlTxt.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlTxt.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlTxt.Location = new System.Drawing.Point(10, 437);
            this.pnlTxt.Name = "pnlTxt";
            this.pnlTxt.Size = new System.Drawing.Size(1237, 224);
            this.pnlTxt.TabIndex = 18;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.Window;
            this.txtEdad.BorderColor = System.Drawing.Color.Gray;
            this.txtEdad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtEdad.BorderRadius = 9;
            this.txtEdad.BorderSize = 2;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.Location = new System.Drawing.Point(192, 149);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Multiline = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEdad.PasswordChar = false;
            this.txtEdad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEdad.PlaceholderText = "";
            this.txtEdad.Size = new System.Drawing.Size(250, 31);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.Texts = "";
            this.txtEdad.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.Gray;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtNombre.BorderRadius = 9;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(192, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.Size = new System.Drawing.Size(250, 31);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.BorderColor = System.Drawing.Color.Gray;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtApellido.BorderRadius = 9;
            this.txtApellido.BorderSize = 2;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(192, 107);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.Size = new System.Drawing.Size(250, 31);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(651, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha de nacimiemto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Edad";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.Gray;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtTelefono.BorderRadius = 9;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(752, 152);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(250, 31);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.SystemColors.Window;
            this.txtSexo.BorderColor = System.Drawing.Color.Gray;
            this.txtSexo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtSexo.BorderRadius = 9;
            this.txtSexo.BorderSize = 2;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.ForeColor = System.Drawing.Color.DimGray;
            this.txtSexo.Location = new System.Drawing.Point(752, 68);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexo.Multiline = false;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSexo.PasswordChar = false;
            this.txtSexo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSexo.PlaceholderText = "";
            this.txtSexo.Size = new System.Drawing.Size(250, 31);
            this.txtSexo.TabIndex = 5;
            this.txtSexo.Texts = "";
            this.txtSexo.UnderlinedStyle = false;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaNac.BorderColor = System.Drawing.Color.Gray;
            this.txtFechaNac.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtFechaNac.BorderRadius = 9;
            this.txtFechaNac.BorderSize = 2;
            this.txtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNac.ForeColor = System.Drawing.Color.DimGray;
            this.txtFechaNac.Location = new System.Drawing.Point(752, 110);
            this.txtFechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaNac.Multiline = false;
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaNac.PasswordChar = false;
            this.txtFechaNac.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFechaNac.PlaceholderText = "";
            this.txtFechaNac.Size = new System.Drawing.Size(250, 31);
            this.txtFechaNac.TabIndex = 6;
            this.txtFechaNac.Texts = "";
            this.txtFechaNac.UnderlinedStyle = false;
            // 
            // pnlBuscador
            // 
            this.pnlBuscador.BackColor = System.Drawing.Color.White;
            this.pnlBuscador.BorderRadius = 30;
            this.pnlBuscador.Controls.Add(this.txtBuscarPaciente);
            this.pnlBuscador.ForeColor = System.Drawing.Color.Black;
            this.pnlBuscador.GradientAngle = 90F;
            this.pnlBuscador.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlBuscador.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.pnlBuscador.Location = new System.Drawing.Point(10, 9);
            this.pnlBuscador.Name = "pnlBuscador";
            this.pnlBuscador.Size = new System.Drawing.Size(1237, 78);
            this.pnlBuscador.TabIndex = 17;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarPaciente.BorderColor = System.Drawing.Color.Gray;
            this.txtBuscarPaciente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtBuscarPaciente.BorderRadius = 9;
            this.txtBuscarPaciente.BorderSize = 2;
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarPaciente.Location = new System.Drawing.Point(28, 24);
            this.txtBuscarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPaciente.Multiline = false;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarPaciente.PasswordChar = false;
            this.txtBuscarPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPaciente.PlaceholderText = "ID Paciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(434, 31);
            this.txtBuscarPaciente.TabIndex = 1;
            this.txtBuscarPaciente.Texts = "";
            this.txtBuscarPaciente.UnderlinedStyle = false;
            this.txtBuscarPaciente._TextChanged += new System.EventHandler(this.txtBuscarPaciente__TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(852, 32);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1259, 764);
            this.Controls.Add(this.pnlbtn);
            this.Controls.Add(this.pnlTxt);
            this.Controls.Add(this.pnlBuscador);
            this.Controls.Add(this.dgvPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPacientes";
            this.Text = "FPacientes";
            this.Load += new System.EventHandler(this.FPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.pnlbtn.ResumeLayout(false);
            this.pnlTxt.ResumeLayout(false);
            this.pnlTxt.PerformLayout();
            this.pnlBuscador.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private LDControles.LDTextBox txtBuscarPaciente;
        private LDControles.LDTextBox txtNombre;
        private LDControles.LDTextBox txtApellido;
        private LDControles.LDTextBox txtEdad;
        private LDControles.LDTextBox txtSexo;
        private LDControles.LDTextBox txtFechaNac;
        private LDControles.LDTextBox txtTelefono;
        private LDControles.LDButton btnCargar;
        private LDControles.LDButton btnModificar;
        private LDControles.LDButton btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private LDControles.LDPanel pnlBuscador;
        private LDControles.LDPanel pnlTxt;
        private LDControles.LDPanel pnlbtn;
        private LDControles.LDButton btnLimpiar;
    }
}