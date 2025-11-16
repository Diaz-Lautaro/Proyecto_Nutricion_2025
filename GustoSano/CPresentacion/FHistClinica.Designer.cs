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
            this.label9 = new System.Windows.Forms.Label();
            this.ldPanel1 = new GustoSano.LDControles.LDPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisClinica)).BeginInit();
            this.ldPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(20, 84);
            this.dgvPacientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 62;
            this.dgvPacientes.Size = new System.Drawing.Size(1621, 278);
            this.dgvPacientes.TabIndex = 18;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // cmbObjetivo
            // 
            this.cmbObjetivo.BackColor = System.Drawing.Color.White;
            this.cmbObjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetivo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjetivo.ForeColor = System.Drawing.Color.Black;
            this.cmbObjetivo.FormattingEnabled = true;
            this.cmbObjetivo.Location = new System.Drawing.Point(997, 388);
            this.cmbObjetivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbObjetivo.Name = "cmbObjetivo";
            this.cmbObjetivo.Size = new System.Drawing.Size(200, 38);
            this.cmbObjetivo.TabIndex = 30;
            this.cmbObjetivo.SelectedIndexChanged += new System.EventHandler(this.cmbObjetivo_SelectedIndexChanged);
            // 
            // cmbPatologia
            // 
            this.cmbPatologia.BackColor = System.Drawing.Color.White;
            this.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatologia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatologia.ForeColor = System.Drawing.Color.Black;
            this.cmbPatologia.FormattingEnabled = true;
            this.cmbPatologia.Location = new System.Drawing.Point(997, 452);
            this.cmbPatologia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPatologia.Name = "cmbPatologia";
            this.cmbPatologia.Size = new System.Drawing.Size(200, 38);
            this.cmbPatologia.TabIndex = 31;
            this.cmbPatologia.SelectedIndexChanged += new System.EventHandler(this.cmbPatologia_SelectedIndexChanged);
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.BackColor = System.Drawing.Color.White;
            this.cmbAlergia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlergia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbAlergia.ForeColor = System.Drawing.Color.Black;
            this.cmbAlergia.FormattingEnabled = true;
            this.cmbAlergia.Location = new System.Drawing.Point(997, 521);
            this.cmbAlergia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(200, 38);
            this.cmbAlergia.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(131, 518);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Altura:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(145, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Peso:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(171, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(846, 591);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 36;
            this.label4.Text = "Diagnostico:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(898, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "Alergía:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(874, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.TabIndex = 38;
            this.label6.Text = "Patología:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(881, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 39;
            this.label7.Text = "Objetivo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(437, 518);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 32);
            this.label8.TabIndex = 40;
            this.label8.Text = "Actividad física:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(27, 647);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 32);
            this.label10.TabIndex = 42;
            this.label10.Text = "Comidas diarias:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(36, 584);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 32);
            this.label11.TabIndex = 43;
            this.label11.Text = "Medicamentos:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(506, 388);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 32);
            this.label12.TabIndex = 44;
            this.label12.Text = "Horarios:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(400, 453);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 32);
            this.label13.TabIndex = 45;
            this.label13.Text = "Consumo de agua:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(454, 584);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 32);
            this.label14.TabIndex = 47;
            this.label14.Text = "Tipo de dieta:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvHisClinica
            // 
            this.dgvHisClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHisClinica.Location = new System.Drawing.Point(20, 726);
            this.dgvHisClinica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHisClinica.Name = "dgvHisClinica";
            this.dgvHisClinica.RowHeadersWidth = 62;
            this.dgvHisClinica.Size = new System.Drawing.Size(1621, 275);
            this.dgvHisClinica.TabIndex = 51;
            this.dgvHisClinica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHisClinica_CellClick);
            this.dgvHisClinica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHisClinica_CellContentClick);
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.BackColor = System.Drawing.Color.White;
            this.cmbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnostico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiagnostico.ForeColor = System.Drawing.Color.Black;
            this.cmbDiagnostico.FormattingEnabled = true;
            this.cmbDiagnostico.Location = new System.Drawing.Point(997, 587);
            this.cmbDiagnostico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.Size = new System.Drawing.Size(200, 38);
            this.cmbDiagnostico.TabIndex = 53;
            // 
            // btnLimipiar
            // 
            this.btnLimipiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnLimipiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnLimipiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimipiar.BorderRadius = 20;
            this.btnLimipiar.BorderSize = 0;
            this.btnLimipiar.FlatAppearance.BorderSize = 0;
            this.btnLimipiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimipiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimipiar.ForeColor = System.Drawing.Color.White;
            this.btnLimipiar.Location = new System.Drawing.Point(39, 166);
            this.btnLimipiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimipiar.Name = "btnLimipiar";
            this.btnLimipiar.Size = new System.Drawing.Size(225, 62);
            this.btnLimipiar.TabIndex = 54;
            this.btnLimipiar.Text = "Limpiar Historial";
            this.btnLimipiar.TextColor = System.Drawing.Color.White;
            this.btnLimipiar.UseVisualStyleBackColor = false;
            this.btnLimipiar.Click += new System.EventHandler(this.btnLimipiar_Click);
            // 
            // txtBuscarHistoria
            // 
            this.txtBuscarHistoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarHistoria.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscarHistoria.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtBuscarHistoria.BorderRadius = 9;
            this.txtBuscarHistoria.BorderSize = 2;
            this.txtBuscarHistoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarHistoria.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarHistoria.Location = new System.Drawing.Point(1309, 662);
            this.txtBuscarHistoria.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscarHistoria.Multiline = false;
            this.txtBuscarHistoria.Name = "txtBuscarHistoria";
            this.txtBuscarHistoria.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtBuscarHistoria.PasswordChar = false;
            this.txtBuscarHistoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarHistoria.PlaceholderText = "ID de Paciente";
            this.txtBuscarHistoria.Size = new System.Drawing.Size(332, 53);
            this.txtBuscarHistoria.TabIndex = 52;
            this.txtBuscarHistoria.Texts = "";
            this.txtBuscarHistoria.UnderlinedStyle = false;
            this.txtBuscarHistoria._TextChanged += new System.EventHandler(this.txtBuscarHistClinica__TextChanged);
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarPaciente.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscarPaciente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtBuscarPaciente.BorderRadius = 9;
            this.txtBuscarPaciente.BorderSize = 2;
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarPaciente.Location = new System.Drawing.Point(1308, 21);
            this.txtBuscarPaciente.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscarPaciente.Multiline = false;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtBuscarPaciente.PasswordChar = false;
            this.txtBuscarPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPaciente.PlaceholderText = "ID de Paciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(333, 53);
            this.txtBuscarPaciente.TabIndex = 1;
            this.txtBuscarPaciente.Texts = "";
            this.txtBuscarPaciente.UnderlinedStyle = false;
            this.txtBuscarPaciente._TextChanged += new System.EventHandler(this.txtBuscarPaciente__TextChanged);
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
            this.btnModificar.Location = new System.Drawing.Point(39, 91);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(225, 62);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar Historial";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtTipoDieta
            // 
            this.txtTipoDieta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTipoDieta.BorderColor = System.Drawing.Color.DimGray;
            this.txtTipoDieta.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtTipoDieta.BorderRadius = 9;
            this.txtTipoDieta.BorderSize = 2;
            this.txtTipoDieta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDieta.ForeColor = System.Drawing.Color.Black;
            this.txtTipoDieta.Location = new System.Drawing.Point(618, 572);
            this.txtTipoDieta.Margin = new System.Windows.Forms.Padding(6);
            this.txtTipoDieta.Multiline = false;
            this.txtTipoDieta.Name = "txtTipoDieta";
            this.txtTipoDieta.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtTipoDieta.PasswordChar = false;
            this.txtTipoDieta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipoDieta.PlaceholderText = "";
            this.txtTipoDieta.Size = new System.Drawing.Size(162, 53);
            this.txtTipoDieta.TabIndex = 49;
            this.txtTipoDieta.Texts = "";
            this.txtTipoDieta.UnderlinedStyle = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(39, 19);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(225, 62);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar Historial";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtActividad
            // 
            this.txtActividad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtActividad.BorderColor = System.Drawing.Color.DimGray;
            this.txtActividad.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtActividad.BorderRadius = 9;
            this.txtActividad.BorderSize = 2;
            this.txtActividad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad.ForeColor = System.Drawing.Color.Black;
            this.txtActividad.Location = new System.Drawing.Point(618, 507);
            this.txtActividad.Margin = new System.Windows.Forms.Padding(6);
            this.txtActividad.Multiline = false;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtActividad.PasswordChar = false;
            this.txtActividad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtActividad.PlaceholderText = "";
            this.txtActividad.Size = new System.Drawing.Size(162, 53);
            this.txtActividad.TabIndex = 29;
            this.txtActividad.Texts = "";
            this.txtActividad.UnderlinedStyle = false;
            // 
            // txtAgua
            // 
            this.txtAgua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAgua.BorderColor = System.Drawing.Color.DimGray;
            this.txtAgua.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtAgua.BorderRadius = 9;
            this.txtAgua.BorderSize = 2;
            this.txtAgua.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAgua.ForeColor = System.Drawing.Color.Black;
            this.txtAgua.Location = new System.Drawing.Point(618, 442);
            this.txtAgua.Margin = new System.Windows.Forms.Padding(6);
            this.txtAgua.Multiline = false;
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtAgua.PasswordChar = false;
            this.txtAgua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAgua.PlaceholderText = "";
            this.txtAgua.Size = new System.Drawing.Size(162, 53);
            this.txtAgua.TabIndex = 28;
            this.txtAgua.Texts = "";
            this.txtAgua.UnderlinedStyle = false;
            this.txtAgua._TextChanged += new System.EventHandler(this.txtAgua__TextChanged);
            // 
            // txtHorarios
            // 
            this.txtHorarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHorarios.BorderColor = System.Drawing.Color.DimGray;
            this.txtHorarios.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtHorarios.BorderRadius = 9;
            this.txtHorarios.BorderSize = 2;
            this.txtHorarios.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHorarios.ForeColor = System.Drawing.Color.Black;
            this.txtHorarios.Location = new System.Drawing.Point(618, 377);
            this.txtHorarios.Margin = new System.Windows.Forms.Padding(6);
            this.txtHorarios.Multiline = false;
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtHorarios.PasswordChar = false;
            this.txtHorarios.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHorarios.PlaceholderText = "";
            this.txtHorarios.Size = new System.Drawing.Size(162, 53);
            this.txtHorarios.TabIndex = 27;
            this.txtHorarios.Texts = "";
            this.txtHorarios.UnderlinedStyle = false;
            // 
            // txtComidas
            // 
            this.txtComidas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtComidas.BorderColor = System.Drawing.Color.DimGray;
            this.txtComidas.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtComidas.BorderRadius = 9;
            this.txtComidas.BorderSize = 2;
            this.txtComidas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtComidas.ForeColor = System.Drawing.Color.Black;
            this.txtComidas.Location = new System.Drawing.Point(217, 637);
            this.txtComidas.Margin = new System.Windows.Forms.Padding(6);
            this.txtComidas.Multiline = false;
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtComidas.PasswordChar = false;
            this.txtComidas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComidas.PlaceholderText = "";
            this.txtComidas.Size = new System.Drawing.Size(162, 53);
            this.txtComidas.TabIndex = 26;
            this.txtComidas.Texts = "";
            this.txtComidas.UnderlinedStyle = false;
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedicamentos.BorderColor = System.Drawing.Color.DimGray;
            this.txtMedicamentos.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtMedicamentos.BorderRadius = 9;
            this.txtMedicamentos.BorderSize = 2;
            this.txtMedicamentos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMedicamentos.ForeColor = System.Drawing.Color.Black;
            this.txtMedicamentos.Location = new System.Drawing.Point(217, 572);
            this.txtMedicamentos.Margin = new System.Windows.Forms.Padding(6);
            this.txtMedicamentos.Multiline = false;
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtMedicamentos.PasswordChar = false;
            this.txtMedicamentos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicamentos.PlaceholderText = "";
            this.txtMedicamentos.Size = new System.Drawing.Size(162, 53);
            this.txtMedicamentos.TabIndex = 25;
            this.txtMedicamentos.Texts = "";
            this.txtMedicamentos.UnderlinedStyle = false;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAltura.BorderColor = System.Drawing.Color.DimGray;
            this.txtAltura.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtAltura.BorderRadius = 9;
            this.txtAltura.BorderSize = 2;
            this.txtAltura.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.ForeColor = System.Drawing.Color.Black;
            this.txtAltura.Location = new System.Drawing.Point(217, 507);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(6);
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtAltura.PasswordChar = false;
            this.txtAltura.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAltura.PlaceholderText = "";
            this.txtAltura.Size = new System.Drawing.Size(162, 53);
            this.txtAltura.TabIndex = 22;
            this.txtAltura.Texts = "";
            this.txtAltura.UnderlinedStyle = false;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeso.BorderColor = System.Drawing.Color.DimGray;
            this.txtPeso.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtPeso.BorderRadius = 9;
            this.txtPeso.BorderSize = 2;
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.Black;
            this.txtPeso.Location = new System.Drawing.Point(217, 442);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(6);
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtPeso.PasswordChar = false;
            this.txtPeso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeso.PlaceholderText = "";
            this.txtPeso.Size = new System.Drawing.Size(162, 53);
            this.txtPeso.TabIndex = 21;
            this.txtPeso.Texts = "";
            this.txtPeso.UnderlinedStyle = false;
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdPaciente.BorderColor = System.Drawing.Color.DimGray;
            this.txtIdPaciente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtIdPaciente.BorderRadius = 9;
            this.txtIdPaciente.BorderSize = 2;
            this.txtIdPaciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtIdPaciente.Location = new System.Drawing.Point(217, 377);
            this.txtIdPaciente.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdPaciente.Multiline = false;
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtIdPaciente.PasswordChar = false;
            this.txtIdPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdPaciente.PlaceholderText = "";
            this.txtIdPaciente.Size = new System.Drawing.Size(162, 53);
            this.txtIdPaciente.TabIndex = 20;
            this.txtIdPaciente.Texts = "";
            this.txtIdPaciente.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(407, 70);
            this.label9.TabIndex = 55;
            this.label9.Text = "Historias clínicas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ldPanel1
            // 
            this.ldPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel1.BorderRadius = 30;
            this.ldPanel1.Controls.Add(this.btnModificar);
            this.ldPanel1.Controls.Add(this.btnLimipiar);
            this.ldPanel1.Controls.Add(this.btnGuardar);
            this.ldPanel1.ForeColor = System.Drawing.Color.Black;
            this.ldPanel1.GradientAngle = 90F;
            this.ldPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel1.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel1.Location = new System.Drawing.Point(1270, 377);
            this.ldPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ldPanel1.Name = "ldPanel1";
            this.ldPanel1.Size = new System.Drawing.Size(301, 246);
            this.ldPanel1.TabIndex = 56;
            this.ldPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.ldPanel1_Paint);
            // 
            // FHistClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1668, 1015);
            this.Controls.Add(this.ldPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbDiagnostico);
            this.Controls.Add(this.txtBuscarHistoria);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.dgvHisClinica);
            this.Controls.Add(this.txtTipoDieta);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FHistClinica";
            this.Text = "FHistClinica";
            this.Load += new System.EventHandler(this.FHistClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisClinica)).EndInit();
            this.ldPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label9;
        private LDControles.LDPanel ldPanel1;
    }
}