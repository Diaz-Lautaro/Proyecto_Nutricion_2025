using System.Windows.Forms;

namespace GustoSano.CPresentacion
{
    partial class FBuscarPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarPaciente = new GustoSano.LDControles.LDTextBox();
            this.ldPanel1 = new GustoSano.LDControles.LDPanel();
            this.dgvBuscarPaciente = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new GustoSano.LDControles.LDButton();
            this.btnCargarPaciente = new GustoSano.LDControles.LDButton();
            this.ldPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPaciente)).BeginInit();
            this.SuspendLayout();
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
            this.txtBuscarPaciente.Location = new System.Drawing.Point(12, 9);
            this.txtBuscarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPaciente.Multiline = false;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarPaciente.PasswordChar = false;
            this.txtBuscarPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPaciente.PlaceholderText = "ID de Paciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(434, 35);
            this.txtBuscarPaciente.TabIndex = 35;
            this.txtBuscarPaciente.Texts = "";
            this.txtBuscarPaciente.UnderlinedStyle = false;
            this.txtBuscarPaciente._TextChanged += new System.EventHandler(this.txtBuscarPaciente__TextChanged);
            // 
            // ldPanel1
            // 
            this.ldPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel1.BorderRadius = 30;
            this.ldPanel1.Controls.Add(this.dgvBuscarPaciente);
            this.ldPanel1.ForeColor = System.Drawing.Color.Black;
            this.ldPanel1.GradientAngle = 90F;
            this.ldPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.ldPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.ldPanel1.Location = new System.Drawing.Point(12, 49);
            this.ldPanel1.Name = "ldPanel1";
            this.ldPanel1.Size = new System.Drawing.Size(843, 271);
            this.ldPanel1.TabIndex = 34;
            // 
            // dgvBuscarPaciente
            // 
            this.dgvBuscarPaciente.AllowUserToAddRows = false;
            this.dgvBuscarPaciente.AllowUserToDeleteRows = false;
            this.dgvBuscarPaciente.AllowUserToResizeColumns = false;
            this.dgvBuscarPaciente.AllowUserToResizeRows = false;
            this.dgvBuscarPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuscarPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dgvBuscarPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuscarPaciente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscarPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBuscarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarPaciente.EnableHeadersVisualStyles = false;
            this.dgvBuscarPaciente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dgvBuscarPaciente.Location = new System.Drawing.Point(11, 12);
            this.dgvBuscarPaciente.MultiSelect = false;
            this.dgvBuscarPaciente.Name = "dgvBuscarPaciente";
            this.dgvBuscarPaciente.ReadOnly = true;
            this.dgvBuscarPaciente.RowHeadersVisible = false;
            this.dgvBuscarPaciente.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBuscarPaciente.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBuscarPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarPaciente.Size = new System.Drawing.Size(820, 249);
            this.dgvBuscarPaciente.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(168, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargarPaciente
            // 
            this.btnCargarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnCargarPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnCargarPaciente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCargarPaciente.BorderRadius = 20;
            this.btnCargarPaciente.BorderSize = 0;
            this.btnCargarPaciente.FlatAppearance.BorderSize = 0;
            this.btnCargarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPaciente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCargarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnCargarPaciente.Location = new System.Drawing.Point(12, 329);
            this.btnCargarPaciente.Name = "btnCargarPaciente";
            this.btnCargarPaciente.Size = new System.Drawing.Size(150, 40);
            this.btnCargarPaciente.TabIndex = 1;
            this.btnCargarPaciente.Text = "Cargar ";
            this.btnCargarPaciente.TextColor = System.Drawing.Color.White;
            this.btnCargarPaciente.UseVisualStyleBackColor = false;
            this.btnCargarPaciente.Click += new System.EventHandler(this.btnCargarPacienteMenus_Click);
            // 
            // FBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(874, 381);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.ldPanel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargarPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarPaciente";
            this.Load += new System.EventHandler(this.FBuscarPaciente_Load);
            this.ldPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarPaciente;
        private LDControles.LDButton btnCargarPaciente;
        private LDControles.LDButton btnCancelar;
        private LDControles.LDPanel ldPanel1;
        private LDControles.LDTextBox txtBuscarPaciente;
    }
}