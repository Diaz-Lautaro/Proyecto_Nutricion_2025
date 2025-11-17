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
            this.dgvBuscarPaciente = new System.Windows.Forms.DataGridView();
            this.btnCargarPaciente = new GustoSano.LDControles.LDButton();
            this.btnCancelar = new GustoSano.LDControles.LDButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarPaciente
            // 
            this.dgvBuscarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarPaciente.Location = new System.Drawing.Point(18, 18);
            this.dgvBuscarPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBuscarPaciente.Name = "dgvBuscarPaciente";
            this.dgvBuscarPaciente.RowHeadersWidth = 62;
            this.dgvBuscarPaciente.Size = new System.Drawing.Size(1275, 403);
            this.dgvBuscarPaciente.TabIndex = 0;
            // 
            // btnCargarPaciente
            // 
            this.btnCargarPaciente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCargarPaciente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCargarPaciente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCargarPaciente.BorderRadius = 20;
            this.btnCargarPaciente.BorderSize = 0;
            this.btnCargarPaciente.FlatAppearance.BorderSize = 0;
            this.btnCargarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnCargarPaciente.Location = new System.Drawing.Point(18, 431);
            this.btnCargarPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarPaciente.Name = "btnCargarPaciente";
            this.btnCargarPaciente.Size = new System.Drawing.Size(225, 62);
            this.btnCargarPaciente.TabIndex = 1;
            this.btnCargarPaciente.Text = "Cargar ";
            this.btnCargarPaciente.TextColor = System.Drawing.Color.White;
            this.btnCargarPaciente.UseVisualStyleBackColor = false;
            this.btnCargarPaciente.Click += new System.EventHandler(this.btnCargarPacienteMenus_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(252, 431);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(225, 62);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(230)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1311, 511);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargarPaciente);
            this.Controls.Add(this.dgvBuscarPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FBuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarPaciente";
            this.Load += new System.EventHandler(this.FBuscarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarPaciente;
        private LDControles.LDButton btnCargarPaciente;
        private LDControles.LDButton btnCancelar;
    }
}