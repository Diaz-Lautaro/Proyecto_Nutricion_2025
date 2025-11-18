namespace GustoSano.CPresentacion
{
    partial class FReportes
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreMenu = new GustoSano.LDControles.LDTextBox();
            this.btnBuscarMenu = new GustoSano.LDControles.LDButton();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaciente = new GustoSano.LDControles.LDTextBox();
            this.btnBuscarPaciente = new GustoSano.LDControles.LDButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new GustoSano.LDControles.LDButton();
            this.btnPdf = new GustoSano.LDControles.LDButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNombreMenu);
            this.groupBox2.Controls.Add(this.btnBuscarMenu);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(30, 411);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1593, 142);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menú del Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(61, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 41;
            this.label3.Text = "Menú:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreMenu
            // 
            this.txtNombreMenu.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreMenu.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombreMenu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtNombreMenu.BorderRadius = 9;
            this.txtNombreMenu.BorderSize = 2;
            this.txtNombreMenu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreMenu.ForeColor = System.Drawing.Color.Black;
            this.txtNombreMenu.Location = new System.Drawing.Point(147, 66);
            this.txtNombreMenu.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreMenu.Multiline = false;
            this.txtNombreMenu.Name = "txtNombreMenu";
            this.txtNombreMenu.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtNombreMenu.PasswordChar = false;
            this.txtNombreMenu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreMenu.PlaceholderText = "";
            this.txtNombreMenu.Size = new System.Drawing.Size(490, 53);
            this.txtNombreMenu.TabIndex = 40;
            this.txtNombreMenu.Texts = "";
            this.txtNombreMenu.UnderlinedStyle = false;
            // 
            // btnBuscarMenu
            // 
            this.btnBuscarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnBuscarMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnBuscarMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarMenu.BorderRadius = 20;
            this.btnBuscarMenu.BorderSize = 0;
            this.btnBuscarMenu.FlatAppearance.BorderSize = 0;
            this.btnBuscarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBuscarMenu.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMenu.Location = new System.Drawing.Point(1341, 52);
            this.btnBuscarMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarMenu.Name = "btnBuscarMenu";
            this.btnBuscarMenu.Size = new System.Drawing.Size(225, 62);
            this.btnBuscarMenu.TabIndex = 39;
            this.btnBuscarMenu.Text = "Buscar Menú";
            this.btnBuscarMenu.TextColor = System.Drawing.Color.White;
            this.btnBuscarMenu.UseVisualStyleBackColor = false;
            this.btnBuscarMenu.Click += new System.EventHandler(this.btnBuscarMenu_Click);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(30, 648);
            this.dgvTurnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowHeadersWidth = 62;
            this.dgvTurnos.Size = new System.Drawing.Size(998, 311);
            this.dgvTurnos.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(24, 611);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 32);
            this.label4.TabIndex = 42;
            this.label4.Text = "Próximos Turnos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPaciente);
            this.groupBox1.Controls.Add(this.btnBuscarPaciente);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(30, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1593, 142);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú del Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Paciente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPaciente.BorderColor = System.Drawing.Color.DimGray;
            this.txtPaciente.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtPaciente.BorderRadius = 9;
            this.txtPaciente.BorderSize = 2;
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtPaciente.Location = new System.Drawing.Point(147, 55);
            this.txtPaciente.Margin = new System.Windows.Forms.Padding(6);
            this.txtPaciente.Multiline = false;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtPaciente.PasswordChar = false;
            this.txtPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPaciente.PlaceholderText = "";
            this.txtPaciente.Size = new System.Drawing.Size(490, 53);
            this.txtPaciente.TabIndex = 1;
            this.txtPaciente.Texts = "";
            this.txtPaciente.UnderlinedStyle = false;
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
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(1341, 42);
            this.btnBuscarPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(225, 62);
            this.btnBuscarPaciente.TabIndex = 0;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.TextColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(23, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 41);
            this.label1.TabIndex = 44;
            this.label1.Text = "Historia clínica cargada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnExcel);
            this.groupBox3.Controls.Add(this.btnPdf);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(1110, 648);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(512, 309);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opción de Descarga";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcel.BorderRadius = 20;
            this.btnExcel.BorderSize = 0;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(132, 191);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(225, 62);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "EXCEL (en desarrollo)";
            this.btnExcel.TextColor = System.Drawing.Color.White;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnPdf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnPdf.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPdf.BorderRadius = 20;
            this.btnPdf.BorderSize = 0;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(132, 92);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(225, 62);
            this.btnPdf.TabIndex = 42;
            this.btnPdf.Text = "Descargar PDF";
            this.btnPdf.TextColor = System.Drawing.Color.White;
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(13, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(509, 70);
            this.label11.TabIndex = 46;
            this.label11.Text = "Reporte de Pacientes";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1668, 1015);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FReportes";
            this.Text = "FReportes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LDControles.LDButton btnBuscarPaciente;
        private LDControles.LDTextBox txtPaciente;
        private System.Windows.Forms.GroupBox groupBox2;
        private LDControles.LDTextBox txtNombreMenu;
        private LDControles.LDButton btnBuscarMenu;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label label4;
        private LDControles.LDButton btnPdf;
        private LDControles.LDButton btnExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}