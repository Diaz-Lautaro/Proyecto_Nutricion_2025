using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHisClinica = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.ldPanel2 = new GustoSano.LDControles.LDPanel();
            this.txtTipoDieta = new GustoSano.LDControles.LDTextBox();
            this.btnBuscarpaciente = new GustoSano.LDControles.LDButton();
            this.txtComidas = new GustoSano.LDControles.LDTextBox();
            this.txtMedicamentos = new GustoSano.LDControles.LDTextBox();
            this.cmbObjetivo = new System.Windows.Forms.ComboBox();
            this.txtAltura = new GustoSano.LDControles.LDTextBox();
            this.cmbPatologia = new System.Windows.Forms.ComboBox();
            this.cmbAlergia = new System.Windows.Forms.ComboBox();
            this.txtPeso = new GustoSano.LDControles.LDTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPaciente = new GustoSano.LDControles.LDTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDiagnostico = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHorarios = new GustoSano.LDControles.LDTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgua = new GustoSano.LDControles.LDTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtActividad = new GustoSano.LDControles.LDTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ldPanel1 = new GustoSano.LDControles.LDPanel();
            this.btnModificar = new GustoSano.LDControles.LDButton();
            this.btnLimipiar = new GustoSano.LDControles.LDButton();
            this.btnGuardar = new GustoSano.LDControles.LDButton();
            this.txtBuscarHistoria = new GustoSano.LDControles.LDTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisClinica)).BeginInit();
            this.ldPanel2.SuspendLayout();
            this.ldPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHisClinica
            // 
            this.dgvHisClinica.AllowUserToAddRows = false;
            this.dgvHisClinica.AllowUserToDeleteRows = false;
            this.dgvHisClinica.AllowUserToResizeColumns = false;
            this.dgvHisClinica.AllowUserToResizeRows = false;
            this.dgvHisClinica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHisClinica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dgvHisClinica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHisClinica.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHisClinica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHisClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHisClinica.EnableHeadersVisualStyles = false;
            this.dgvHisClinica.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dgvHisClinica.Location = new System.Drawing.Point(13, 455);
            this.dgvHisClinica.MultiSelect = false;
            this.dgvHisClinica.Name = "dgvHisClinica";
            this.dgvHisClinica.ReadOnly = true;
            this.dgvHisClinica.RowHeadersVisible = false;
            this.dgvHisClinica.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHisClinica.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHisClinica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHisClinica.Size = new System.Drawing.Size(1081, 196);
            this.dgvHisClinica.TabIndex = 51;
            this.dgvHisClinica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHisClinica_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 47);
            this.label9.TabIndex = 55;
            this.label9.Text = "Historias clínicas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ldPanel2
            // 
            this.ldPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel2.BorderRadius = 30;
            this.ldPanel2.Controls.Add(this.txtTipoDieta);
            this.ldPanel2.Controls.Add(this.btnBuscarpaciente);
            this.ldPanel2.Controls.Add(this.txtComidas);
            this.ldPanel2.Controls.Add(this.txtMedicamentos);
            this.ldPanel2.Controls.Add(this.cmbObjetivo);
            this.ldPanel2.Controls.Add(this.txtAltura);
            this.ldPanel2.Controls.Add(this.cmbPatologia);
            this.ldPanel2.Controls.Add(this.cmbAlergia);
            this.ldPanel2.Controls.Add(this.txtPeso);
            this.ldPanel2.Controls.Add(this.label1);
            this.ldPanel2.Controls.Add(this.label2);
            this.ldPanel2.Controls.Add(this.txtIdPaciente);
            this.ldPanel2.Controls.Add(this.label4);
            this.ldPanel2.Controls.Add(this.cmbDiagnostico);
            this.ldPanel2.Controls.Add(this.label5);
            this.ldPanel2.Controls.Add(this.label3);
            this.ldPanel2.Controls.Add(this.label12);
            this.ldPanel2.Controls.Add(this.txtHorarios);
            this.ldPanel2.Controls.Add(this.label6);
            this.ldPanel2.Controls.Add(this.label8);
            this.ldPanel2.Controls.Add(this.txtAgua);
            this.ldPanel2.Controls.Add(this.label7);
            this.ldPanel2.Controls.Add(this.txtActividad);
            this.ldPanel2.Controls.Add(this.label14);
            this.ldPanel2.Controls.Add(this.label13);
            this.ldPanel2.Controls.Add(this.label11);
            this.ldPanel2.Controls.Add(this.label10);
            this.ldPanel2.ForeColor = System.Drawing.Color.Black;
            this.ldPanel2.GradientAngle = 90F;
            this.ldPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel2.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel2.Location = new System.Drawing.Point(35, 66);
            this.ldPanel2.Name = "ldPanel2";
            this.ldPanel2.Size = new System.Drawing.Size(1035, 305);
            this.ldPanel2.TabIndex = 57;
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
            this.txtTipoDieta.Location = new System.Drawing.Point(507, 61);
            this.txtTipoDieta.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoDieta.Multiline = false;
            this.txtTipoDieta.Name = "txtTipoDieta";
            this.txtTipoDieta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTipoDieta.PasswordChar = false;
            this.txtTipoDieta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipoDieta.PlaceholderText = "";
            this.txtTipoDieta.Size = new System.Drawing.Size(190, 35);
            this.txtTipoDieta.TabIndex = 49;
            this.txtTipoDieta.Texts = "";
            this.txtTipoDieta.UnderlinedStyle = false;
            // 
            // btnBuscarpaciente
            // 
            this.btnBuscarpaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnBuscarpaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnBuscarpaciente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarpaciente.BorderRadius = 20;
            this.btnBuscarpaciente.BorderSize = 0;
            this.btnBuscarpaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarpaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarpaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarpaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarpaciente.Location = new System.Drawing.Point(835, 22);
            this.btnBuscarpaciente.Name = "btnBuscarpaciente";
            this.btnBuscarpaciente.Size = new System.Drawing.Size(150, 40);
            this.btnBuscarpaciente.TabIndex = 55;
            this.btnBuscarpaciente.Text = "Buscar paciente";
            this.btnBuscarpaciente.TextColor = System.Drawing.Color.White;
            this.btnBuscarpaciente.UseVisualStyleBackColor = false;
            this.btnBuscarpaciente.Click += new System.EventHandler(this.btnBuscarpaciente_Click);
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
            this.txtComidas.Location = new System.Drawing.Point(162, 150);
            this.txtComidas.Margin = new System.Windows.Forms.Padding(4);
            this.txtComidas.Multiline = false;
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtComidas.PasswordChar = false;
            this.txtComidas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComidas.PlaceholderText = "";
            this.txtComidas.Size = new System.Drawing.Size(93, 35);
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
            this.txtMedicamentos.Location = new System.Drawing.Point(162, 193);
            this.txtMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicamentos.Multiline = true;
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMedicamentos.PasswordChar = false;
            this.txtMedicamentos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicamentos.PlaceholderText = "";
            this.txtMedicamentos.Size = new System.Drawing.Size(190, 94);
            this.txtMedicamentos.TabIndex = 25;
            this.txtMedicamentos.Texts = "";
            this.txtMedicamentos.UnderlinedStyle = false;
            // 
            // cmbObjetivo
            // 
            this.cmbObjetivo.BackColor = System.Drawing.Color.White;
            this.cmbObjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetivo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjetivo.ForeColor = System.Drawing.Color.Black;
            this.cmbObjetivo.FormattingEnabled = true;
            this.cmbObjetivo.Location = new System.Drawing.Point(850, 112);
            this.cmbObjetivo.Name = "cmbObjetivo";
            this.cmbObjetivo.Size = new System.Drawing.Size(135, 28);
            this.cmbObjetivo.TabIndex = 30;
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
            this.txtAltura.Location = new System.Drawing.Point(162, 107);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAltura.PasswordChar = false;
            this.txtAltura.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAltura.PlaceholderText = "";
            this.txtAltura.Size = new System.Drawing.Size(93, 35);
            this.txtAltura.TabIndex = 22;
            this.txtAltura.Texts = "";
            this.txtAltura.UnderlinedStyle = false;
            // 
            // cmbPatologia
            // 
            this.cmbPatologia.BackColor = System.Drawing.Color.White;
            this.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatologia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatologia.ForeColor = System.Drawing.Color.Black;
            this.cmbPatologia.FormattingEnabled = true;
            this.cmbPatologia.Location = new System.Drawing.Point(850, 161);
            this.cmbPatologia.Name = "cmbPatologia";
            this.cmbPatologia.Size = new System.Drawing.Size(135, 28);
            this.cmbPatologia.TabIndex = 31;
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.BackColor = System.Drawing.Color.White;
            this.cmbAlergia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlergia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbAlergia.ForeColor = System.Drawing.Color.Black;
            this.cmbAlergia.FormattingEnabled = true;
            this.cmbAlergia.Location = new System.Drawing.Point(850, 210);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(135, 28);
            this.cmbAlergia.TabIndex = 32;
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
            this.txtPeso.Location = new System.Drawing.Point(162, 64);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPeso.PasswordChar = false;
            this.txtPeso.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeso.PlaceholderText = "";
            this.txtPeso.Size = new System.Drawing.Size(93, 35);
            this.txtPeso.TabIndex = 21;
            this.txtPeso.Texts = "";
            this.txtPeso.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Altura:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Peso:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtIdPaciente.Location = new System.Drawing.Point(162, 22);
            this.txtIdPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPaciente.Multiline = false;
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIdPaciente.PasswordChar = false;
            this.txtIdPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdPaciente.PlaceholderText = "";
            this.txtIdPaciente.Size = new System.Drawing.Size(93, 35);
            this.txtIdPaciente.TabIndex = 20;
            this.txtIdPaciente.Texts = "";
            this.txtIdPaciente.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(749, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Diagnostico:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.BackColor = System.Drawing.Color.White;
            this.cmbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnostico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiagnostico.ForeColor = System.Drawing.Color.Black;
            this.cmbDiagnostico.FormattingEnabled = true;
            this.cmbDiagnostico.Location = new System.Drawing.Point(850, 259);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.Size = new System.Drawing.Size(135, 28);
            this.cmbDiagnostico.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(782, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Alergía:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID Paciente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(432, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 44;
            this.label12.Text = "Horarios:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtHorarios.Location = new System.Drawing.Point(507, 206);
            this.txtHorarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorarios.Multiline = true;
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHorarios.PasswordChar = false;
            this.txtHorarios.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHorarios.PlaceholderText = "";
            this.txtHorarios.Size = new System.Drawing.Size(190, 81);
            this.txtHorarios.TabIndex = 27;
            this.txtHorarios.Texts = "";
            this.txtHorarios.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(767, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Patología:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(386, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Actividad física:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtAgua.Location = new System.Drawing.Point(507, 22);
            this.txtAgua.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgua.Multiline = false;
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAgua.PasswordChar = false;
            this.txtAgua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAgua.PlaceholderText = "";
            this.txtAgua.Size = new System.Drawing.Size(108, 35);
            this.txtAgua.TabIndex = 28;
            this.txtAgua.Texts = "";
            this.txtAgua.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(772, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Objetivo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtActividad.Location = new System.Drawing.Point(507, 104);
            this.txtActividad.Margin = new System.Windows.Forms.Padding(4);
            this.txtActividad.Multiline = true;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtActividad.PasswordChar = false;
            this.txtActividad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtActividad.PlaceholderText = "";
            this.txtActividad.Size = new System.Drawing.Size(190, 94);
            this.txtActividad.TabIndex = 29;
            this.txtActividad.Texts = "";
            this.txtActividad.UnderlinedStyle = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(397, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 21);
            this.label14.TabIndex = 47;
            this.label14.Text = "Tipo de dieta:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(361, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 21);
            this.label13.TabIndex = 45;
            this.label13.Text = "Consumo de agua:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(40, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 21);
            this.label11.TabIndex = 43;
            this.label11.Text = "Medicamentos:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(35, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 42;
            this.label10.Text = "Comidas diarias:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ldPanel1.Location = new System.Drawing.Point(13, 389);
            this.ldPanel1.Name = "ldPanel1";
            this.ldPanel1.Size = new System.Drawing.Size(513, 60);
            this.ldPanel1.TabIndex = 56;
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
            this.btnModificar.Location = new System.Drawing.Point(164, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 40);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar Historial";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnLimipiar.Location = new System.Drawing.Point(355, 10);
            this.btnLimipiar.Name = "btnLimipiar";
            this.btnLimipiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimipiar.TabIndex = 54;
            this.btnLimipiar.Text = "Limpiar Historial";
            this.btnLimipiar.TextColor = System.Drawing.Color.White;
            this.btnLimipiar.UseVisualStyleBackColor = false;
            this.btnLimipiar.Click += new System.EventHandler(this.btnLimipiar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(8, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar Historial";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.txtBuscarHistoria.Location = new System.Drawing.Point(778, 413);
            this.txtBuscarHistoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarHistoria.Multiline = false;
            this.txtBuscarHistoria.Name = "txtBuscarHistoria";
            this.txtBuscarHistoria.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarHistoria.PasswordChar = false;
            this.txtBuscarHistoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarHistoria.PlaceholderText = "ID de Paciente";
            this.txtBuscarHistoria.Size = new System.Drawing.Size(316, 35);
            this.txtBuscarHistoria.TabIndex = 52;
            this.txtBuscarHistoria.Texts = "";
            this.txtBuscarHistoria.UnderlinedStyle = false;
            this.txtBuscarHistoria._TextChanged += new System.EventHandler(this.txtBuscarHistClinica__TextChanged);
            // 
            // FHistClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::GustoSano.Properties.Resources.ImgFondo_min;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 660);
            this.Controls.Add(this.ldPanel2);
            this.Controls.Add(this.ldPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscarHistoria);
            this.Controls.Add(this.dgvHisClinica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHistClinica";
            this.Text = "FHistClinica";
            this.Load += new System.EventHandler(this.FHistClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisClinica)).EndInit();
            this.ldPanel2.ResumeLayout(false);
            this.ldPanel2.PerformLayout();
            this.ldPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private LDControles.LDButton btnBuscarpaciente;
        private LDControles.LDPanel ldPanel2;
    }
}