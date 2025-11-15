namespace GustoSano.CPresentacion
{
    partial class FHistClinica
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
            this.cmbObjetivo = new System.Windows.Forms.ComboBox();
            this.cmbPatologia = new System.Windows.Forms.ComboBox();
            this.cmbAlergia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvHisClinica = new System.Windows.Forms.DataGridView();
            this.cmbDiagnostico = new System.Windows.Forms.ComboBox();
            this.btnLimipiar = new GustoSano.LDControles.LDButton();
            this.txtBuscarHistoria = new GustoSano.LDControles.LDTextBox();
            this.txtBuscarPaciente = new GustoSano.LDControles.LDTextBox();
            this.btnModificar = new GustoSano.LDControles.LDButton();
            this.txtTipoDieta = new GustoSano.LDControles.LDTextBox();
            this.btnGuardar = new GustoSano.LDControles.LDButton();
            this.txtActividad = new GustoSano.LDControles.LDTextBox();
            this.txtAgua = new GustoSano.LDControles.LDTextBox();
            this.txtHorarios = new GustoSano.LDControles.LDTextBox();
            this.txtComidas = new GustoSano.LDControles.LDTextBox();
            this.txtMedicamentos = new GustoSano.LDControles.LDTextBox();
            this.txtAltura = new GustoSano.LDControles.LDTextBox();
            this.txtPeso = new GustoSano.LDControles.LDTextBox();
            this.txtIdPaciente = new GustoSano.LDControles.LDTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisClinica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(13, 51);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(1050, 181);
            this.dgvPacientes.TabIndex = 18;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // cmbObjetivo
            // 
            this.cmbObjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjetivo.FormattingEnabled = true;
            this.cmbObjetivo.Location = new System.Drawing.Point(575, 267);
            this.cmbObjetivo.Name = "cmbObjetivo";
            this.cmbObjetivo.Size = new System.Drawing.Size(132, 24);
            this.cmbObjetivo.TabIndex = 30;
            // 
            // cmbPatologia
            // 
            this.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatologia.FormattingEnabled = true;
            this.cmbPatologia.Location = new System.Drawing.Point(725, 267);
            this.cmbPatologia.Name = "cmbPatologia";
            this.cmbPatologia.Size = new System.Drawing.Size(132, 24);
            this.cmbPatologia.TabIndex = 31;
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlergia.FormattingEnabled = true;
            this.cmbAlergia.Location = new System.Drawing.Point(871, 267);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(132, 24);
            this.cmbAlergia.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Diagnostico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(868, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Alergia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Patología";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Objetivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Actividad física";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Comidas diarias";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(560, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Medicamentos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(823, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Horarios";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(823, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Consumo de agua";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Tipo de dieta";
            // 
            // dgvHisClinica
            // 
            this.dgvHisClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHisClinica.Location = new System.Drawing.Point(13, 468);
            this.dgvHisClinica.Name = "dgvHisClinica";
            this.dgvHisClinica.Size = new System.Drawing.Size(1050, 170);
            this.dgvHisClinica.TabIndex = 51;
            this.dgvHisClinica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHisClinica_CellClick);
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiagnostico.FormattingEnabled = true;
            this.cmbDiagnostico.Location = new System.Drawing.Point(384, 319);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.Size = new System.Drawing.Size(151, 24);
            this.cmbDiagnostico.TabIndex = 53;
            // 
            // btnLimipiar
            // 
            this.btnLimipiar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimipiar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimipiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimipiar.BorderRadius = 20;
            this.btnLimipiar.BorderSize = 0;
            this.btnLimipiar.FlatAppearance.BorderSize = 0;
            this.btnLimipiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimipiar.ForeColor = System.Drawing.Color.White;
            this.btnLimipiar.Location = new System.Drawing.Point(32, 361);
            this.btnLimipiar.Name = "btnLimipiar";
            this.btnLimipiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimipiar.TabIndex = 54;
            this.btnLimipiar.Text = "Limpiar";
            this.btnLimipiar.TextColor = System.Drawing.Color.White;
            this.btnLimipiar.UseVisualStyleBackColor = false;
            this.btnLimipiar.Click += new System.EventHandler(this.btnLimipiar_Click);
            // 
            // txtBuscarHistoria
            // 
            this.txtBuscarHistoria.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarHistoria.BorderColor = System.Drawing.Color.Gray;
            this.txtBuscarHistoria.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtBuscarHistoria.BorderRadius = 9;
            this.txtBuscarHistoria.BorderSize = 2;
            this.txtBuscarHistoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarHistoria.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarHistoria.Location = new System.Drawing.Point(13, 430);
            this.txtBuscarHistoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarHistoria.Multiline = false;
            this.txtBuscarHistoria.Name = "txtBuscarHistoria";
            this.txtBuscarHistoria.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarHistoria.PasswordChar = false;
            this.txtBuscarHistoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarHistoria.PlaceholderText = "ID Paciente";
            this.txtBuscarHistoria.Size = new System.Drawing.Size(150, 31);
            this.txtBuscarHistoria.TabIndex = 52;
            this.txtBuscarHistoria.Texts = "";
            this.txtBuscarHistoria.UnderlinedStyle = false;
            this.txtBuscarHistoria._TextChanged += new System.EventHandler(this.txtBuscarHistClinica__TextChanged);
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
            this.txtBuscarPaciente.Location = new System.Drawing.Point(13, 13);
            this.txtBuscarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPaciente.Multiline = false;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarPaciente.PasswordChar = false;
            this.txtBuscarPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPaciente.PlaceholderText = "ID Paciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(150, 31);
            this.txtBuscarPaciente.TabIndex = 1;
            this.txtBuscarPaciente.Texts = "";
            this.txtBuscarPaciente.UnderlinedStyle = false;
            this.txtBuscarPaciente._TextChanged += new System.EventHandler(this.txtBuscarPaciente__TextChanged);
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
            this.btnModificar.Location = new System.Drawing.Point(32, 311);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 40);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtTipoDieta
            // 
            this.txtTipoDieta.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoDieta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTipoDieta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTipoDieta.BorderRadius = 0;
            this.txtTipoDieta.BorderSize = 2;
            this.txtTipoDieta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDieta.ForeColor = System.Drawing.Color.DimGray;
            this.txtTipoDieta.Location = new System.Drawing.Point(385, 378);
            this.txtTipoDieta.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoDieta.Multiline = false;
            this.txtTipoDieta.Name = "txtTipoDieta";
            this.txtTipoDieta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTipoDieta.PasswordChar = false;
            this.txtTipoDieta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipoDieta.PlaceholderText = "";
            this.txtTipoDieta.Size = new System.Drawing.Size(150, 31);
            this.txtTipoDieta.TabIndex = 49;
            this.txtTipoDieta.Texts = "";
            this.txtTipoDieta.UnderlinedStyle = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(32, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtActividad
            // 
            this.txtActividad.BackColor = System.Drawing.SystemColors.Window;
            this.txtActividad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtActividad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtActividad.BorderRadius = 0;
            this.txtActividad.BorderSize = 2;
            this.txtActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad.ForeColor = System.Drawing.Color.DimGray;
            this.txtActividad.Location = new System.Drawing.Point(216, 378);
            this.txtActividad.Margin = new System.Windows.Forms.Padding(4);
            this.txtActividad.Multiline = false;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtActividad.PasswordChar = false;
            this.txtActividad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtActividad.PlaceholderText = "";
            this.txtActividad.Size = new System.Drawing.Size(150, 31);
            this.txtActividad.TabIndex = 29;
            this.txtActividad.Texts = "";
            this.txtActividad.UnderlinedStyle = false;
            // 
            // txtAgua
            // 
            this.txtAgua.BackColor = System.Drawing.SystemColors.Window;
            this.txtAgua.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAgua.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAgua.BorderRadius = 0;
            this.txtAgua.BorderSize = 2;
            this.txtAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgua.ForeColor = System.Drawing.Color.DimGray;
            this.txtAgua.Location = new System.Drawing.Point(826, 378);
            this.txtAgua.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgua.Multiline = false;
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAgua.PasswordChar = false;
            this.txtAgua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAgua.PlaceholderText = "";
            this.txtAgua.Size = new System.Drawing.Size(150, 31);
            this.txtAgua.TabIndex = 28;
            this.txtAgua.Texts = "";
            this.txtAgua.UnderlinedStyle = false;
            // 
            // txtHorarios
            // 
            this.txtHorarios.BackColor = System.Drawing.SystemColors.Window;
            this.txtHorarios.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHorarios.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHorarios.BorderRadius = 0;
            this.txtHorarios.BorderSize = 2;
            this.txtHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorarios.ForeColor = System.Drawing.Color.DimGray;
            this.txtHorarios.Location = new System.Drawing.Point(826, 319);
            this.txtHorarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorarios.Multiline = false;
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHorarios.PasswordChar = false;
            this.txtHorarios.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHorarios.PlaceholderText = "";
            this.txtHorarios.Size = new System.Drawing.Size(150, 31);
            this.txtHorarios.TabIndex = 27;
            this.txtHorarios.Texts = "";
            this.txtHorarios.UnderlinedStyle = false;
            // 
            // txtComidas
            // 
            this.txtComidas.BackColor = System.Drawing.SystemColors.Window;
            this.txtComidas.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtComidas.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtComidas.BorderRadius = 0;
            this.txtComidas.BorderSize = 2;
            this.txtComidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComidas.ForeColor = System.Drawing.Color.DimGray;
            this.txtComidas.Location = new System.Drawing.Point(563, 378);
            this.txtComidas.Margin = new System.Windows.Forms.Padding(4);
            this.txtComidas.Multiline = false;
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtComidas.PasswordChar = false;
            this.txtComidas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComidas.PlaceholderText = "";
            this.txtComidas.Size = new System.Drawing.Size(150, 31);
            this.txtComidas.TabIndex = 26;
            this.txtComidas.Texts = "";
            this.txtComidas.UnderlinedStyle = false;
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedicamentos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMedicamentos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMedicamentos.BorderRadius = 0;
            this.txtMedicamentos.BorderSize = 2;
            this.txtMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamentos.ForeColor = System.Drawing.Color.DimGray;
            this.txtMedicamentos.Location = new System.Drawing.Point(563, 319);
            this.txtMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicamentos.Multiline = false;
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMedicamentos.PasswordChar = false;
            this.txtMedicamentos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicamentos.PlaceholderText = "";
            this.txtMedicamentos.Size = new System.Drawing.Size(150, 31);
            this.txtMedicamentos.TabIndex = 25;
            this.txtMedicamentos.Texts = "";
            this.txtMedicamentos.UnderlinedStyle = false;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.Window;
            this.txtAltura.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAltura.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAltura.BorderRadius = 0;
            this.txtAltura.BorderSize = 2;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.ForeColor = System.Drawing.Color.DimGray;
            this.txtAltura.Location = new System.Drawing.Point(385, 257);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAltura.PasswordChar = false;
            this.txtAltura.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAltura.PlaceholderText = "";
            this.txtAltura.Size = new System.Drawing.Size(150, 31);
            this.txtAltura.TabIndex = 22;
            this.txtAltura.Texts = "";
            this.txtAltura.UnderlinedStyle = false;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.Window;
            this.txtPeso.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPeso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPeso.BorderRadius = 0;
            this.txtPeso.BorderSize = 2;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.DimGray;
            this.txtPeso.Location = new System.Drawing.Point(216, 319);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPeso.PasswordChar = false;
            this.txtPeso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeso.PlaceholderText = "";
            this.txtPeso.Size = new System.Drawing.Size(150, 31);
            this.txtPeso.TabIndex = 21;
            this.txtPeso.Texts = "";
            this.txtPeso.UnderlinedStyle = false;
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdPaciente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIdPaciente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdPaciente.BorderRadius = 0;
            this.txtIdPaciente.BorderSize = 2;
            this.txtIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdPaciente.Location = new System.Drawing.Point(216, 257);
            this.txtIdPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPaciente.Multiline = false;
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIdPaciente.PasswordChar = false;
            this.txtIdPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdPaciente.PlaceholderText = "";
            this.txtIdPaciente.Size = new System.Drawing.Size(150, 31);
            this.txtIdPaciente.TabIndex = 20;
            this.txtIdPaciente.Texts = "";
            this.txtIdPaciente.UnderlinedStyle = false;
            // 
            // FHistClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1075, 650);
            this.Controls.Add(this.btnLimipiar);
            this.Controls.Add(this.cmbDiagnostico);
            this.Controls.Add(this.txtBuscarHistoria);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.dgvHisClinica);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtTipoDieta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAlergia);
            this.Controls.Add(this.cmbPatologia);
            this.Controls.Add(this.cmbObjetivo);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.txtAgua);
            this.Controls.Add(this.txtHorarios);
            this.Controls.Add(this.txtComidas);
            this.Controls.Add(this.txtMedicamentos);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.dgvPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHistClinica";
            this.Text = "FHistClinica";
            this.Load += new System.EventHandler(this.FHistClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisClinica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LDControles.LDTextBox txtBuscarPaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private LDControles.LDTextBox txtIdPaciente;
        private LDControles.LDTextBox txtPeso;
        private LDControles.LDTextBox txtAltura;
        private LDControles.LDTextBox txtMedicamentos;
        private LDControles.LDTextBox txtComidas;
        private LDControles.LDTextBox txtHorarios;
        private LDControles.LDTextBox txtAgua;
        private LDControles.LDTextBox txtActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private LDControles.LDButton btnGuardar;
        private LDControles.LDTextBox txtTipoDieta;
        private LDControles.LDButton btnModificar;
        private System.Windows.Forms.DataGridView dgvHisClinica;
        private LDControles.LDTextBox txtBuscarHistoria;
        private System.Windows.Forms.ComboBox cmbObjetivo;
        private System.Windows.Forms.ComboBox cmbPatologia;
        private System.Windows.Forms.ComboBox cmbAlergia;
        private System.Windows.Forms.ComboBox cmbDiagnostico;
        private LDControles.LDButton btnLimipiar;
    }
}