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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAlergia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoComida = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ldPanel1 = new GustoSano.LDControles.LDPanel();
            this.btnModificar = new GustoSano.LDControles.LDButton();
            this.btnEliminar = new GustoSano.LDControles.LDButton();
            this.ldPanel2 = new GustoSano.LDControles.LDPanel();
            this.btnLimpiar = new GustoSano.LDControles.LDButton();
            this.btnAgregar = new GustoSano.LDControles.LDButton();
            this.txtBuscarReceta = new GustoSano.LDControles.LDTextBox();
            this.txtCalorias = new GustoSano.LDControles.LDTextBox();
            this.txtDescripcion = new GustoSano.LDControles.LDTextBox();
            this.txtNombreReceta = new GustoSano.LDControles.LDTextBox();
            this.ldPanel3 = new GustoSano.LDControles.LDPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).BeginInit();
            this.ldPanel1.SuspendLayout();
            this.ldPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbObjetivo
            // 
            this.cmbObjetivo.BackColor = System.Drawing.Color.White;
            this.cmbObjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbObjetivo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbObjetivo.ForeColor = System.Drawing.Color.Black;
            this.cmbObjetivo.FormattingEnabled = true;
            this.cmbObjetivo.Location = new System.Drawing.Point(156, 440);
            this.cmbObjetivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbObjetivo.Name = "cmbObjetivo";
            this.cmbObjetivo.Size = new System.Drawing.Size(200, 38);
            this.cmbObjetivo.TabIndex = 8;
            this.cmbObjetivo.SelectedIndexChanged += new System.EventHandler(this.cmbObjetivo_SelectedIndexChanged);
            // 
            // cmbPatologia
            // 
            this.cmbPatologia.BackColor = System.Drawing.Color.White;
            this.cmbPatologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatologia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPatologia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbPatologia.ForeColor = System.Drawing.Color.Black;
            this.cmbPatologia.FormattingEnabled = true;
            this.cmbPatologia.Location = new System.Drawing.Point(156, 514);
            this.cmbPatologia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPatologia.Name = "cmbPatologia";
            this.cmbPatologia.Size = new System.Drawing.Size(200, 38);
            this.cmbPatologia.TabIndex = 9;
            // 
            // dgvRecetas
            // 
            this.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetas.Location = new System.Drawing.Point(20, 602);
            this.dgvRecetas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRecetas.Name = "dgvRecetas";
            this.dgvRecetas.RowHeadersWidth = 62;
            this.dgvRecetas.Size = new System.Drawing.Size(1625, 399);
            this.dgvRecetas.TabIndex = 10;
            this.dgvRecetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecetas_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(46, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de Receta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(46, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Calorías:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(40, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Objetivo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(33, 518);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Patología:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(482, 443);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 39;
            this.label6.Text = "Alergía:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbAlergia
            // 
            this.cmbAlergia.BackColor = System.Drawing.Color.White;
            this.cmbAlergia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlergia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAlergia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbAlergia.ForeColor = System.Drawing.Color.Black;
            this.cmbAlergia.FormattingEnabled = true;
            this.cmbAlergia.Location = new System.Drawing.Point(579, 439);
            this.cmbAlergia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAlergia.Name = "cmbAlergia";
            this.cmbAlergia.Size = new System.Drawing.Size(200, 38);
            this.cmbAlergia.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(390, 517);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 32);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tipo de comida:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTipoComida
            // 
            this.cmbTipoComida.BackColor = System.Drawing.Color.White;
            this.cmbTipoComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComida.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTipoComida.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTipoComida.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoComida.FormattingEnabled = true;
            this.cmbTipoComida.Location = new System.Drawing.Point(579, 512);
            this.cmbTipoComida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoComida.Name = "cmbTipoComida";
            this.cmbTipoComida.Size = new System.Drawing.Size(200, 38);
            this.cmbTipoComida.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 70);
            this.label8.TabIndex = 42;
            this.label8.Text = "Recetas";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ldPanel1
            // 
            this.ldPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel1.BorderRadius = 30;
            this.ldPanel1.Controls.Add(this.btnModificar);
            this.ldPanel1.Controls.Add(this.btnEliminar);
            this.ldPanel1.ForeColor = System.Drawing.Color.Black;
            this.ldPanel1.GradientAngle = 90F;
            this.ldPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel1.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel1.Location = new System.Drawing.Point(892, 281);
            this.ldPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ldPanel1.Name = "ldPanel1";
            this.ldPanel1.Size = new System.Drawing.Size(593, 86);
            this.ldPanel1.TabIndex = 44;
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
            this.btnModificar.Location = new System.Drawing.Point(46, 12);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(225, 62);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Receta";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(316, 12);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(225, 62);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Receta";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ldPanel2
            // 
            this.ldPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel2.BorderRadius = 30;
            this.ldPanel2.Controls.Add(this.btnLimpiar);
            this.ldPanel2.Controls.Add(this.btnAgregar);
            this.ldPanel2.ForeColor = System.Drawing.Color.Black;
            this.ldPanel2.GradientAngle = 90F;
            this.ldPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel2.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel2.Location = new System.Drawing.Point(892, 176);
            this.ldPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ldPanel2.Name = "ldPanel2";
            this.ldPanel2.Size = new System.Drawing.Size(593, 86);
            this.ldPanel2.TabIndex = 43;
            this.ldPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.ldPanel2_Paint);
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
            this.btnLimpiar.Location = new System.Drawing.Point(315, 12);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(225, 62);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar Receta";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(46, 12);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 62);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Receta";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscarReceta
            // 
            this.txtBuscarReceta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarReceta.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscarReceta.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtBuscarReceta.BorderRadius = 9;
            this.txtBuscarReceta.BorderSize = 2;
            this.txtBuscarReceta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarReceta.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarReceta.Location = new System.Drawing.Point(1207, 538);
            this.txtBuscarReceta.Margin = new System.Windows.Forms.Padding(6);
            this.txtBuscarReceta.Multiline = false;
            this.txtBuscarReceta.Name = "txtBuscarReceta";
            this.txtBuscarReceta.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtBuscarReceta.PasswordChar = false;
            this.txtBuscarReceta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarReceta.PlaceholderText = "ID de Receta";
            this.txtBuscarReceta.Size = new System.Drawing.Size(438, 53);
            this.txtBuscarReceta.TabIndex = 3;
            this.txtBuscarReceta.Texts = "";
            this.txtBuscarReceta.UnderlinedStyle = false;
            this.txtBuscarReceta._TextChanged += new System.EventHandler(this.txtBuscarReceta__TextChanged);
            // 
            // txtCalorias
            // 
            this.txtCalorias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCalorias.BorderColor = System.Drawing.Color.DimGray;
            this.txtCalorias.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtCalorias.BorderRadius = 9;
            this.txtCalorias.BorderSize = 2;
            this.txtCalorias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorias.ForeColor = System.Drawing.Color.Black;
            this.txtCalorias.Location = new System.Drawing.Point(160, 361);
            this.txtCalorias.Margin = new System.Windows.Forms.Padding(6);
            this.txtCalorias.Multiline = false;
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtCalorias.PasswordChar = false;
            this.txtCalorias.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCalorias.PlaceholderText = "";
            this.txtCalorias.Size = new System.Drawing.Size(162, 53);
            this.txtCalorias.TabIndex = 2;
            this.txtCalorias.Texts = "";
            this.txtCalorias.UnderlinedStyle = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.BorderColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtDescripcion.BorderRadius = 7;
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(46, 205);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.PlaceholderText = "Descripción de receta...";
            this.txtDescripcion.Size = new System.Drawing.Size(695, 141);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.UnderlinedStyle = false;
            this.txtDescripcion._TextChanged += new System.EventHandler(this.txtDescripcion__TextChanged);
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombreReceta.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombreReceta.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtNombreReceta.BorderRadius = 9;
            this.txtNombreReceta.BorderSize = 2;
            this.txtNombreReceta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreReceta.ForeColor = System.Drawing.Color.Black;
            this.txtNombreReceta.Location = new System.Drawing.Point(46, 137);
            this.txtNombreReceta.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreReceta.Multiline = false;
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtNombreReceta.PasswordChar = false;
            this.txtNombreReceta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreReceta.PlaceholderText = "";
            this.txtNombreReceta.Size = new System.Drawing.Size(375, 53);
            this.txtNombreReceta.TabIndex = 0;
            this.txtNombreReceta.Texts = "";
            this.txtNombreReceta.UnderlinedStyle = false;
            // 
            // ldPanel3
            // 
            this.ldPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel3.BorderRadius = 30;
            this.ldPanel3.ForeColor = System.Drawing.Color.Black;
            this.ldPanel3.GradientAngle = 90F;
            this.ldPanel3.GradientBottomColor = System.Drawing.Color.White;
            this.ldPanel3.GradientTopColor = System.Drawing.Color.White;
            this.ldPanel3.Location = new System.Drawing.Point(21, 84);
            this.ldPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ldPanel3.Name = "ldPanel3";
            this.ldPanel3.Size = new System.Drawing.Size(770, 490);
            this.ldPanel3.TabIndex = 45;
            // 
            // FRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1668, 1015);
            this.Controls.Add(this.ldPanel1);
            this.Controls.Add(this.ldPanel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipoComida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlergia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecetas);
            this.Controls.Add(this.cmbPatologia);
            this.Controls.Add(this.cmbObjetivo);
            this.Controls.Add(this.txtBuscarReceta);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreReceta);
            this.Controls.Add(this.ldPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRecetas";
            this.Text = "FRecetas";
            this.Load += new System.EventHandler(this.FRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).EndInit();
            this.ldPanel1.ResumeLayout(false);
            this.ldPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAlergia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoComida;
        private System.Windows.Forms.Label label8;
        private LDControles.LDPanel ldPanel2;
        private LDControles.LDPanel ldPanel1;
        private LDControles.LDPanel ldPanel3;
    }
}