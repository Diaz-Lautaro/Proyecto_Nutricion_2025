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
            this.dgvBuscarPaciente.Location = new System.Drawing.Point(12, 12);
            this.dgvBuscarPaciente.Name = "dgvBuscarPaciente";
            this.dgvBuscarPaciente.Size = new System.Drawing.Size(850, 262);
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
            this.btnCargarPaciente.Location = new System.Drawing.Point(12, 280);
            this.btnCargarPaciente.Name = "btnCargarPaciente";
            this.btnCargarPaciente.Size = new System.Drawing.Size(150, 40);
            this.btnCargarPaciente.TabIndex = 1;
            this.btnCargarPaciente.Text = "Cargar ";
            this.btnCargarPaciente.TextColor = System.Drawing.Color.White;
            this.btnCargarPaciente.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(168, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 332);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargarPaciente);
            this.Controls.Add(this.dgvBuscarPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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