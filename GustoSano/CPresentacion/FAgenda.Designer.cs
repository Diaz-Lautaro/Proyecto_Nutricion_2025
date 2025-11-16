namespace GustoSano.CPresentacion
{
    partial class FAgenda
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
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new GustoSano.LDControles.LDButton();
            this.txtFecha = new GustoSano.LDControles.LDTextBox();
            this.txtNombreYApellido = new GustoSano.LDControles.LDTextBox();
            this.txtBuscarAgenda = new GustoSano.LDControles.LDTextBox();
            this.btnBuscarPaciente = new GustoSano.LDControles.LDButton();
            this.btnEliminar = new GustoSano.LDControles.LDButton();
            this.btnEditar = new GustoSano.LDControles.LDButton();
            this.btnGuardar = new GustoSano.LDControles.LDButton();
            this.label11 = new System.Windows.Forms.Label();
            this.ldPanel1 = new GustoSano.LDControles.LDPanel();
            this.ldPanel2 = new GustoSano.LDControles.LDPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.ldPanel1.SuspendLayout();
            this.ldPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario.ForeColor = System.Drawing.Color.Black;
            this.Calendario.Location = new System.Drawing.Point(1029, 137);
            this.Calendario.Margin = new System.Windows.Forms.Padding(14);
            this.Calendario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.Calendario.TitleForeColor = System.Drawing.Color.Black;
            this.Calendario.TrailingForeColor = System.Drawing.Color.Purple;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // dtHora
            // 
            this.dtHora.CalendarForeColor = System.Drawing.Color.Black;
            this.dtHora.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtHora.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dtHora.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtHora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(283, 289);
            this.dtHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(159, 37);
            this.dtHora.TabIndex = 1;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(14, 674);
            this.dgvAgenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowHeadersWidth = 62;
            this.dgvAgenda.Size = new System.Drawing.Size(1636, 325);
            this.dgvAgenda.TabIndex = 2;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(193, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(204, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hora:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(283, 350);
            this.cmbMotivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(457, 40);
            this.cmbMotivo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(179, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Motivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(267, 14);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(225, 62);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Turno";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFecha.BorderColor = System.Drawing.Color.DimGray;
            this.txtFecha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtFecha.BorderRadius = 9;
            this.txtFecha.BorderSize = 2;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.Location = new System.Drawing.Point(283, 216);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(6);
            this.txtFecha.Multiline = false;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtFecha.PasswordChar = false;
            this.txtFecha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFecha.PlaceholderText = "";
            this.txtFecha.Size = new System.Drawing.Size(159, 53);
            this.txtFecha.TabIndex = 9;
            this.txtFecha.Texts = "";
            this.txtFecha.UnderlinedStyle = false;
            // 
            // txtNombreYApellido
            // 
            this.txtNombreYApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreYApellido.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombreYApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtNombreYApellido.BorderRadius = 9;
            this.txtNombreYApellido.BorderSize = 2;
            this.txtNombreYApellido.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreYApellido.ForeColor = System.Drawing.Color.Black;
            this.txtNombreYApellido.Location = new System.Drawing.Point(283, 139);
            this.txtNombreYApellido.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreYApellido.Multiline = false;
            this.txtNombreYApellido.Name = "txtNombreYApellido";
            this.txtNombreYApellido.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtNombreYApellido.PasswordChar = false;
            this.txtNombreYApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreYApellido.PlaceholderText = "";
            this.txtNombreYApellido.Size = new System.Drawing.Size(457, 53);
            this.txtNombreYApellido.TabIndex = 8;
            this.txtNombreYApellido.Texts = "";
            this.txtNombreYApellido.UnderlinedStyle = false;
            // 
            // txtBuscarAgenda
            // 
            this.txtBuscarAgenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarAgenda.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscarAgenda.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtBuscarAgenda.BorderRadius = 9;
            this.txtBuscarAgenda.BorderSize = 2;
            this.txtBuscarAgenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAgenda.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarAgenda.Location = new System.Drawing.Point(1041, 608);
            this.txtBuscarAgenda.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscarAgenda.Multiline = false;
            this.txtBuscarAgenda.Name = "txtBuscarAgenda";
            this.txtBuscarAgenda.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtBuscarAgenda.PasswordChar = false;
            this.txtBuscarAgenda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarAgenda.PlaceholderText = "Buscar Turno por ID";
            this.txtBuscarAgenda.Size = new System.Drawing.Size(609, 55);
            this.txtBuscarAgenda.TabIndex = 7;
            this.txtBuscarAgenda.Texts = "";
            this.txtBuscarAgenda.UnderlinedStyle = false;
            this.txtBuscarAgenda._TextChanged += new System.EventHandler(this.txtBuscarAgenda__TextChanged);
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnBuscarPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnBuscarPaciente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarPaciente.BorderRadius = 20;
            this.btnBuscarPaciente.BorderSize = 0;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(44, 133);
            this.btnBuscarPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(225, 62);
            this.btnBuscarPaciente.TabIndex = 6;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.TextColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(18, 14);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(225, 62);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Turno";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(259, 14);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(225, 62);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Modificar Turno";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(21, 14);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(225, 62);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Turno";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(13, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 70);
            this.label11.TabIndex = 44;
            this.label11.Text = "Agenda";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ldPanel1
            // 
            this.ldPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel1.BorderRadius = 30;
            this.ldPanel1.Controls.Add(this.btnEditar);
            this.ldPanel1.Controls.Add(this.btnGuardar);
            this.ldPanel1.ForeColor = System.Drawing.Color.Black;
            this.ldPanel1.GradientAngle = 90F;
            this.ldPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel1.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel1.Location = new System.Drawing.Point(44, 431);
            this.ldPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ldPanel1.Name = "ldPanel1";
            this.ldPanel1.Size = new System.Drawing.Size(508, 89);
            this.ldPanel1.TabIndex = 46;
            this.ldPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.ldPanel1_Paint);
            // 
            // ldPanel2
            // 
            this.ldPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel2.BorderRadius = 30;
            this.ldPanel2.Controls.Add(this.btnLimpiar);
            this.ldPanel2.Controls.Add(this.btnEliminar);
            this.ldPanel2.ForeColor = System.Drawing.Color.Black;
            this.ldPanel2.GradientAngle = 90F;
            this.ldPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel2.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel2.Location = new System.Drawing.Point(44, 542);
            this.ldPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ldPanel2.Name = "ldPanel2";
            this.ldPanel2.Size = new System.Drawing.Size(508, 89);
            this.ldPanel2.TabIndex = 47;
            // 
            // FAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1668, 1015);
            this.Controls.Add(this.ldPanel2);
            this.Controls.Add(this.ldPanel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNombreYApellido);
            this.Controls.Add(this.txtBuscarAgenda);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.Calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FAgenda";
            this.Text = "FAgenda";
            this.Load += new System.EventHandler(this.FAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ldPanel1.ResumeLayout(false);
            this.ldPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private LDControles.LDButton btnGuardar;
        private LDControles.LDButton btnEditar;
        private LDControles.LDButton btnEliminar;
        private LDControles.LDButton btnBuscarPaciente;
        private LDControles.LDTextBox txtBuscarAgenda;
        private LDControles.LDTextBox txtNombreYApellido;
        private LDControles.LDTextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label label3;
        private LDControles.LDButton btnLimpiar;
        private System.Windows.Forms.Label label11;
        private LDControles.LDPanel ldPanel1;
        private LDControles.LDPanel ldPanel2;
    }
}