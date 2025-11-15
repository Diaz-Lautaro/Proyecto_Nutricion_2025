namespace GustoSano.CPresentacion
{
    partial class FRecetas
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
            this.cmbObjetivo = new System.Windows.Forms.ComboBox();
            this.cmbPatologia = new System.Windows.Forms.ComboBox();
            this.dgvRecetas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAlergia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoComida = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new GustoSano.LDControles.LDButton();
            this.btnEliminar = new GustoSano.LDControles.LDButton();
            this.btnModificar = new GustoSano.LDControles.LDButton();
            this.btnAgregar = new GustoSano.LDControles.LDButton();
            this.txtBuscarReceta = new GustoSano.LDControles.LDTextBox();
            this.txtCalorias = new GustoSano.LDControles.LDTextBox();
            this.txtDescripcion = new GustoSano.LDControles.LDTextBox();
            this.txtNombreReceta = new GustoSano.LDControles.LDTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbObjetivo
            // 
            this.cmbObjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjetivo.FormattingEnabled = true;
            this.cmbObjetivo.Location = new System.Drawing.Point(637, 84);
            this.cmbObjetivo.Name = "cmbObjetivo";
            this.cmbObjetivo.Size = new System.Drawing.Size(132, 24);
            this.cmbObjetivo.TabIndex = 8;
            // 
            // cmbPatologia
            // 
            this.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatologia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPatologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatologia.FormattingEnabled = true;
            this.cmbPatologia.Location = new System.Drawing.Point(637, 132);
            this.cmbPatologia.Name = "cmbPatologia";
            this.cmbPatologia.Size = new System.Drawing.Size(132, 24);
            this.cmbPatologia.TabIndex = 9;
            // 
            // dgvRecetas
            // 
            this.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetas.Location = new System.Drawing.Point(12, 377);
            this.dgvRecetas.Name = "dgvRecetas";
            this.dgvRecetas.Size = new System.Drawing.Size(1051, 261);
            this.dgvRecetas.TabIndex = 10;
            this.dgvRecetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecetas_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Calorias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Objetivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Patologia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(821, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Alergia";
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlergia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlergia.FormattingEnabled = true;
            this.cmbAlergia.Location = new System.Drawing.Point(892, 84);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(132, 24);
            this.cmbAlergia.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(821, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tipo comida";
            // 
            // cmbTipoComida
            // 
            this.cmbTipoComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComida.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTipoComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoComida.FormattingEnabled = true;
            this.cmbTipoComida.Location = new System.Drawing.Point(892, 132);
            this.cmbTipoComida.Name = "cmbTipoComida";
            this.cmbTipoComida.Size = new System.Drawing.Size(132, 24);
            this.cmbTipoComida.TabIndex = 40;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(570, 255);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(415, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(260, 255);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 40);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(105, 255);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscarReceta
            // 
            this.txtBuscarReceta.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarReceta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscarReceta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscarReceta.BorderRadius = 0;
            this.txtBuscarReceta.BorderSize = 2;
            this.txtBuscarReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarReceta.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarReceta.Location = new System.Drawing.Point(24, 339);
            this.txtBuscarReceta.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarReceta.Multiline = false;
            this.txtBuscarReceta.Name = "txtBuscarReceta";
            this.txtBuscarReceta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarReceta.PasswordChar = false;
            this.txtBuscarReceta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarReceta.PlaceholderText = "Buscar por id";
            this.txtBuscarReceta.Size = new System.Drawing.Size(474, 31);
            this.txtBuscarReceta.TabIndex = 3;
            this.txtBuscarReceta.Texts = "";
            this.txtBuscarReceta.UnderlinedStyle = false;
            this.txtBuscarReceta._TextChanged += new System.EventHandler(this.txtBuscarReceta__TextChanged);
            // 
            // txtCalorias
            // 
            this.txtCalorias.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalorias.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCalorias.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCalorias.BorderRadius = 0;
            this.txtCalorias.BorderSize = 2;
            this.txtCalorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorias.ForeColor = System.Drawing.Color.DimGray;
            this.txtCalorias.Location = new System.Drawing.Point(181, 181);
            this.txtCalorias.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalorias.Multiline = false;
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCalorias.PasswordChar = false;
            this.txtCalorias.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCalorias.PlaceholderText = "";
            this.txtCalorias.Size = new System.Drawing.Size(83, 31);
            this.txtCalorias.TabIndex = 2;
            this.txtCalorias.Texts = "";
            this.txtCalorias.UnderlinedStyle = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescripcion.BorderRadius = 0;
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(181, 95);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(347, 73);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.UnderlinedStyle = false;
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreReceta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreReceta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreReceta.BorderRadius = 0;
            this.txtNombreReceta.BorderSize = 2;
            this.txtNombreReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreReceta.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreReceta.Location = new System.Drawing.Point(181, 47);
            this.txtNombreReceta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreReceta.Multiline = false;
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreReceta.PasswordChar = false;
            this.txtNombreReceta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreReceta.PlaceholderText = "";
            this.txtNombreReceta.Size = new System.Drawing.Size(250, 31);
            this.txtNombreReceta.TabIndex = 0;
            this.txtNombreReceta.Texts = "";
            this.txtNombreReceta.UnderlinedStyle = false;
            // 
            // FRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1112, 660);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipoComida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlergia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecetas);
            this.Controls.Add(this.cmbPatologia);
            this.Controls.Add(this.cmbObjetivo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscarReceta);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreReceta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRecetas";
            this.Text = "FRecetas";
            this.Load += new System.EventHandler(this.FRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LDControles.LDTextBox txtNombreReceta;
        private LDControles.LDTextBox txtDescripcion;
        private LDControles.LDTextBox txtCalorias;
        private LDControles.LDTextBox txtBuscarReceta;
        private LDControles.LDButton btnAgregar;
        private LDControles.LDButton btnModificar;
        private LDControles.LDButton btnEliminar;
        private LDControles.LDButton btnLimpiar;
        private System.Windows.Forms.ComboBox cmbObjetivo;
        private System.Windows.Forms.ComboBox cmbPatologia;
        private System.Windows.Forms.DataGridView dgvRecetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAlergia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoComida;
    }
}