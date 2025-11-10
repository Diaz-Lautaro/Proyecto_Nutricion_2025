namespace GustoSano
{
    partial class FMenus
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
            this.cmbObjetivoReceta = new System.Windows.Forms.ComboBox();
            this.cmbPatologiaReceta = new System.Windows.Forms.ComboBox();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.lstRecetas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoComidaReceta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAlergiaReceta = new System.Windows.Forms.ComboBox();
            this.dgvRecetasMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAlergiaPaciente = new GustoSano.LDControles.LDTextBox();
            this.txtPatologiaPaciente = new GustoSano.LDControles.LDTextBox();
            this.txtObjetivo = new GustoSano.LDControles.LDTextBox();
            this.txtNombreYApellido = new GustoSano.LDControles.LDTextBox();
            this.btnBuscarPaciente = new GustoSano.LDControles.LDButton();
            this.btnQuitarReceta = new GustoSano.LDControles.LDButton();
            this.btnGuardarMenu = new GustoSano.LDControles.LDButton();
            this.btnAgregarAlMenu = new GustoSano.LDControles.LDButton();
            this.txtNombreMenu = new GustoSano.LDControles.LDTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetasMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbObjetivoReceta
            // 
            this.cmbObjetivoReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetivoReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjetivoReceta.FormattingEnabled = true;
            this.cmbObjetivoReceta.Location = new System.Drawing.Point(575, 136);
            this.cmbObjetivoReceta.Name = "cmbObjetivoReceta";
            this.cmbObjetivoReceta.Size = new System.Drawing.Size(132, 24);
            this.cmbObjetivoReceta.TabIndex = 2;
            // 
            // cmbPatologiaReceta
            // 
            this.cmbPatologiaReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatologiaReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatologiaReceta.FormattingEnabled = true;
            this.cmbPatologiaReceta.Location = new System.Drawing.Point(575, 184);
            this.cmbPatologiaReceta.Name = "cmbPatologiaReceta";
            this.cmbPatologiaReceta.Size = new System.Drawing.Size(132, 24);
            this.cmbPatologiaReceta.TabIndex = 3;
            // 
            // dgvMenus
            // 
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Location = new System.Drawing.Point(12, 388);
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.Size = new System.Drawing.Size(1235, 364);
            this.dgvMenus.TabIndex = 8;
            // 
            // lstRecetas
            // 
            this.lstRecetas.FormattingEnabled = true;
            this.lstRecetas.Location = new System.Drawing.Point(714, 120);
            this.lstRecetas.Name = "lstRecetas";
            this.lstRecetas.Size = new System.Drawing.Size(513, 199);
            this.lstRecetas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre del menú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Objetivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Patología";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Recetas agregadas al menú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo comida";
            // 
            // cmbTipoComidaReceta
            // 
            this.cmbTipoComidaReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComidaReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoComidaReceta.FormattingEnabled = true;
            this.cmbTipoComidaReceta.Location = new System.Drawing.Point(575, 232);
            this.cmbTipoComidaReceta.Name = "cmbTipoComidaReceta";
            this.cmbTipoComidaReceta.Size = new System.Drawing.Size(132, 24);
            this.cmbTipoComidaReceta.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Alergia";
            // 
            // cmbAlergiaReceta
            // 
            this.cmbAlergiaReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlergiaReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlergiaReceta.FormattingEnabled = true;
            this.cmbAlergiaReceta.Location = new System.Drawing.Point(575, 280);
            this.cmbAlergiaReceta.Name = "cmbAlergiaReceta";
            this.cmbAlergiaReceta.Size = new System.Drawing.Size(132, 24);
            this.cmbAlergiaReceta.TabIndex = 22;
            // 
            // dgvRecetasMenu
            // 
            this.dgvRecetasMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecetasMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetasMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvRecetasMenu.Location = new System.Drawing.Point(24, 120);
            this.dgvRecetasMenu.Name = "dgvRecetasMenu";
            this.dgvRecetasMenu.Size = new System.Drawing.Size(508, 197);
            this.dgvRecetasMenu.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo comida";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            // 
            // txtAlergiaPaciente
            // 
            this.txtAlergiaPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlergiaPaciente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAlergiaPaciente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAlergiaPaciente.BorderRadius = 0;
            this.txtAlergiaPaciente.BorderSize = 2;
            this.txtAlergiaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlergiaPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.txtAlergiaPaciente.Location = new System.Drawing.Point(1043, 60);
            this.txtAlergiaPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlergiaPaciente.Multiline = false;
            this.txtAlergiaPaciente.Name = "txtAlergiaPaciente";
            this.txtAlergiaPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAlergiaPaciente.PasswordChar = false;
            this.txtAlergiaPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAlergiaPaciente.PlaceholderText = "";
            this.txtAlergiaPaciente.Size = new System.Drawing.Size(184, 31);
            this.txtAlergiaPaciente.TabIndex = 29;
            this.txtAlergiaPaciente.Texts = "";
            this.txtAlergiaPaciente.UnderlinedStyle = false;
            // 
            // txtPatologiaPaciente
            // 
            this.txtPatologiaPaciente.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatologiaPaciente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPatologiaPaciente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatologiaPaciente.BorderRadius = 0;
            this.txtPatologiaPaciente.BorderSize = 2;
            this.txtPatologiaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatologiaPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.txtPatologiaPaciente.Location = new System.Drawing.Point(766, 60);
            this.txtPatologiaPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatologiaPaciente.Multiline = false;
            this.txtPatologiaPaciente.Name = "txtPatologiaPaciente";
            this.txtPatologiaPaciente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPatologiaPaciente.PasswordChar = false;
            this.txtPatologiaPaciente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPatologiaPaciente.PlaceholderText = "";
            this.txtPatologiaPaciente.Size = new System.Drawing.Size(184, 31);
            this.txtPatologiaPaciente.TabIndex = 28;
            this.txtPatologiaPaciente.Texts = "";
            this.txtPatologiaPaciente.UnderlinedStyle = false;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.BackColor = System.Drawing.SystemColors.Window;
            this.txtObjetivo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObjetivo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtObjetivo.BorderRadius = 0;
            this.txtObjetivo.BorderSize = 2;
            this.txtObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjetivo.ForeColor = System.Drawing.Color.DimGray;
            this.txtObjetivo.Location = new System.Drawing.Point(1043, 27);
            this.txtObjetivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtObjetivo.Multiline = false;
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtObjetivo.PasswordChar = false;
            this.txtObjetivo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObjetivo.PlaceholderText = "";
            this.txtObjetivo.Size = new System.Drawing.Size(184, 31);
            this.txtObjetivo.TabIndex = 27;
            this.txtObjetivo.Texts = "";
            this.txtObjetivo.UnderlinedStyle = false;
            // 
            // txtNombreYApellido
            // 
            this.txtNombreYApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreYApellido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreYApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreYApellido.BorderRadius = 0;
            this.txtNombreYApellido.BorderSize = 2;
            this.txtNombreYApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreYApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreYApellido.Location = new System.Drawing.Point(766, 27);
            this.txtNombreYApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreYApellido.Multiline = false;
            this.txtNombreYApellido.Name = "txtNombreYApellido";
            this.txtNombreYApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreYApellido.PasswordChar = false;
            this.txtNombreYApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreYApellido.PlaceholderText = "";
            this.txtNombreYApellido.Size = new System.Drawing.Size(268, 31);
            this.txtNombreYApellido.TabIndex = 26;
            this.txtNombreYApellido.Texts = "";
            this.txtNombreYApellido.UnderlinedStyle = false;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarPaciente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarPaciente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarPaciente.BorderRadius = 20;
            this.btnBuscarPaciente.BorderSize = 0;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(575, 27);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(150, 40);
            this.btnBuscarPaciente.TabIndex = 25;
            this.btnBuscarPaciente.Text = "Buscar paciente";
            this.btnBuscarPaciente.TextColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnQuitarReceta
            // 
            this.btnQuitarReceta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuitarReceta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuitarReceta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuitarReceta.BorderRadius = 20;
            this.btnQuitarReceta.BorderSize = 0;
            this.btnQuitarReceta.FlatAppearance.BorderSize = 0;
            this.btnQuitarReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarReceta.ForeColor = System.Drawing.Color.White;
            this.btnQuitarReceta.Location = new System.Drawing.Point(188, 323);
            this.btnQuitarReceta.Name = "btnQuitarReceta";
            this.btnQuitarReceta.Size = new System.Drawing.Size(150, 40);
            this.btnQuitarReceta.TabIndex = 21;
            this.btnQuitarReceta.Text = "Quitar receta";
            this.btnQuitarReceta.TextColor = System.Drawing.Color.White;
            this.btnQuitarReceta.UseVisualStyleBackColor = false;
            // 
            // btnGuardarMenu
            // 
            this.btnGuardarMenu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardarMenu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardarMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarMenu.BorderRadius = 20;
            this.btnGuardarMenu.BorderSize = 0;
            this.btnGuardarMenu.FlatAppearance.BorderSize = 0;
            this.btnGuardarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMenu.ForeColor = System.Drawing.Color.White;
            this.btnGuardarMenu.Location = new System.Drawing.Point(32, 323);
            this.btnGuardarMenu.Name = "btnGuardarMenu";
            this.btnGuardarMenu.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarMenu.TabIndex = 20;
            this.btnGuardarMenu.Text = "Guardar menú";
            this.btnGuardarMenu.TextColor = System.Drawing.Color.White;
            this.btnGuardarMenu.UseVisualStyleBackColor = false;
            // 
            // btnAgregarAlMenu
            // 
            this.btnAgregarAlMenu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarAlMenu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarAlMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarAlMenu.BorderRadius = 20;
            this.btnAgregarAlMenu.BorderSize = 0;
            this.btnAgregarAlMenu.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlMenu.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAlMenu.Location = new System.Drawing.Point(714, 325);
            this.btnAgregarAlMenu.Name = "btnAgregarAlMenu";
            this.btnAgregarAlMenu.Size = new System.Drawing.Size(150, 40);
            this.btnAgregarAlMenu.TabIndex = 19;
            this.btnAgregarAlMenu.Text = "Agregar al menú";
            this.btnAgregarAlMenu.TextColor = System.Drawing.Color.White;
            this.btnAgregarAlMenu.UseVisualStyleBackColor = false;
            // 
            // txtNombreMenu
            // 
            this.txtNombreMenu.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreMenu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreMenu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreMenu.BorderRadius = 0;
            this.txtNombreMenu.BorderSize = 2;
            this.txtNombreMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMenu.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreMenu.Location = new System.Drawing.Point(32, 49);
            this.txtNombreMenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMenu.Multiline = false;
            this.txtNombreMenu.Name = "txtNombreMenu";
            this.txtNombreMenu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreMenu.PasswordChar = false;
            this.txtNombreMenu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreMenu.PlaceholderText = "";
            this.txtNombreMenu.Size = new System.Drawing.Size(341, 31);
            this.txtNombreMenu.TabIndex = 0;
            this.txtNombreMenu.Texts = "";
            this.txtNombreMenu.UnderlinedStyle = false;
            // 
            // FMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1259, 764);
            this.Controls.Add(this.txtAlergiaPaciente);
            this.Controls.Add(this.txtPatologiaPaciente);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.txtNombreYApellido);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAlergiaReceta);
            this.Controls.Add(this.dgvRecetasMenu);
            this.Controls.Add(this.btnQuitarReceta);
            this.Controls.Add(this.btnGuardarMenu);
            this.Controls.Add(this.btnAgregarAlMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipoComidaReceta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstRecetas);
            this.Controls.Add(this.dgvMenus);
            this.Controls.Add(this.cmbPatologiaReceta);
            this.Controls.Add(this.cmbObjetivoReceta);
            this.Controls.Add(this.txtNombreMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMenus";
            this.Text = "FMenus";
            this.Load += new System.EventHandler(this.FMenus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetasMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LDControles.LDTextBox txtNombreMenu;
        private System.Windows.Forms.ComboBox cmbObjetivoReceta;
        private System.Windows.Forms.ComboBox cmbPatologiaReceta;
        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.ListBox lstRecetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoComidaReceta;
        private LDControles.LDButton btnAgregarAlMenu;
        private LDControles.LDButton btnGuardarMenu;
        private LDControles.LDButton btnQuitarReceta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAlergiaReceta;
        private System.Windows.Forms.DataGridView dgvRecetasMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private LDControles.LDButton btnBuscarPaciente;
        private LDControles.LDTextBox txtNombreYApellido;
        private LDControles.LDTextBox txtObjetivo;
        private LDControles.LDTextBox txtPatologiaPaciente;
        private LDControles.LDTextBox txtAlergiaPaciente;
    }
}