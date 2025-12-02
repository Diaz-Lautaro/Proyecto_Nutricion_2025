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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ldPanel2 = new GustoSano.LDControles.LDPanel();
            this.btnLimpiar = new GustoSano.LDControles.LDButton();
            this.btnEliminar = new GustoSano.LDControles.LDButton();
            this.ldPanel1 = new GustoSano.LDControles.LDPanel();
            this.btnEditar = new GustoSano.LDControles.LDButton();
            this.btnGuardar = new GustoSano.LDControles.LDButton();
            this.txtFecha = new GustoSano.LDControles.LDTextBox();
            this.txtNombreYApellido = new GustoSano.LDControles.LDTextBox();
            this.txtBuscarAgenda = new GustoSano.LDControles.LDTextBox();
            this.btnBuscarPaciente = new GustoSano.LDControles.LDButton();
            this.ldPanel3 = new GustoSano.LDControles.LDPanel();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.ldPanel4 = new GustoSano.LDControles.LDPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.ldPanel2.SuspendLayout();
            this.ldPanel1.SuspendLayout();
            this.ldPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtHora
            // 
            this.dtHora.CalendarForeColor = System.Drawing.Color.Black;
            this.dtHora.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtHora.CalendarTitleBackColor = System.Drawing.Color.SeaGreen;
            this.dtHora.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtHora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(189, 188);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(107, 27);
            this.dtHora.TabIndex = 1;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AllowUserToResizeColumns = false;
            this.dgvAgenda.AllowUserToResizeRows = false;
            this.dgvAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.EnableHeadersVisualStyles = false;
            this.dgvAgenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dgvAgenda.Location = new System.Drawing.Point(9, 438);
            this.dgvAgenda.MultiSelect = false;
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAgenda.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(1091, 211);
            this.dgvAgenda.TabIndex = 2;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(136, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
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
            this.cmbMotivo.Location = new System.Drawing.Point(189, 227);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(306, 29);
            this.cmbMotivo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(119, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Motivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 47);
            this.label11.TabIndex = 44;
            this.label11.Text = "Agenda";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ldPanel2.Location = new System.Drawing.Point(17, 355);
            this.ldPanel2.Name = "ldPanel2";
            this.ldPanel2.Size = new System.Drawing.Size(339, 58);
            this.ldPanel2.TabIndex = 47;
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
            this.btnLimpiar.Location = new System.Drawing.Point(178, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Turno";
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Turno";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.ldPanel1.Location = new System.Drawing.Point(17, 291);
            this.ldPanel1.Name = "ldPanel1";
            this.ldPanel1.Size = new System.Drawing.Size(339, 58);
            this.ldPanel1.TabIndex = 46;
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
            this.btnEditar.Location = new System.Drawing.Point(173, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 40);
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
            this.btnGuardar.Location = new System.Drawing.Point(14, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Turno";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.txtFecha.Location = new System.Drawing.Point(189, 140);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Multiline = false;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFecha.PasswordChar = false;
            this.txtFecha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFecha.PlaceholderText = "";
            this.txtFecha.Size = new System.Drawing.Size(106, 35);
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
            this.txtNombreYApellido.Location = new System.Drawing.Point(189, 90);
            this.txtNombreYApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreYApellido.Multiline = false;
            this.txtNombreYApellido.Name = "txtNombreYApellido";
            this.txtNombreYApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreYApellido.PasswordChar = false;
            this.txtNombreYApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreYApellido.PlaceholderText = "";
            this.txtNombreYApellido.Size = new System.Drawing.Size(305, 35);
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
            this.txtBuscarAgenda.Location = new System.Drawing.Point(694, 395);
            this.txtBuscarAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarAgenda.Multiline = false;
            this.txtBuscarAgenda.Name = "txtBuscarAgenda";
            this.txtBuscarAgenda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarAgenda.PasswordChar = false;
            this.txtBuscarAgenda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarAgenda.PlaceholderText = "Buscar Turno por ID";
            this.txtBuscarAgenda.Size = new System.Drawing.Size(406, 36);
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
            this.btnBuscarPaciente.Location = new System.Drawing.Point(29, 86);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(150, 40);
            this.btnBuscarPaciente.TabIndex = 6;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.TextColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // ldPanel3
            // 
            this.ldPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel3.BorderRadius = 30;
            this.ldPanel3.Controls.Add(this.Calendario);
            this.ldPanel3.ForeColor = System.Drawing.Color.Black;
            this.ldPanel3.GradientAngle = 90F;
            this.ldPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.ldPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.ldPanel3.Location = new System.Drawing.Point(573, 38);
            this.ldPanel3.Name = "ldPanel3";
            this.ldPanel3.Size = new System.Drawing.Size(505, 329);
            this.ldPanel3.TabIndex = 48;
            // 
            // Calendario
            // 
            this.Calendario.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.Calendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario.ForeColor = System.Drawing.Color.Black;
            this.Calendario.Location = new System.Drawing.Point(23, 11);
            this.Calendario.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.Calendario.TitleForeColor = System.Drawing.Color.Black;
            this.Calendario.TrailingForeColor = System.Drawing.Color.Purple;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // ldPanel4
            // 
            this.ldPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel4.BorderRadius = 30;
            this.ldPanel4.ForeColor = System.Drawing.Color.Black;
            this.ldPanel4.GradientAngle = 90F;
            this.ldPanel4.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel4.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel4.Location = new System.Drawing.Point(17, 66);
            this.ldPanel4.Name = "ldPanel4";
            this.ldPanel4.Size = new System.Drawing.Size(503, 208);
            this.ldPanel4.TabIndex = 54;
            // 
            // FAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::GustoSano.Properties.Resources.ImgFondo_min;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 660);
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
            this.Controls.Add(this.ldPanel3);
            this.Controls.Add(this.ldPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAgenda";
            this.Text = "FAgenda";
            this.Load += new System.EventHandler(this.FAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ldPanel2.ResumeLayout(false);
            this.ldPanel1.ResumeLayout(false);
            this.ldPanel3.ResumeLayout(false);
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
        private LDControles.LDPanel ldPanel3;
        private LDControles.LDPanel ldPanel4;
    }
}