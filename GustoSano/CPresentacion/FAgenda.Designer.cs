namespace GustoSano.CPresentacion
{
    partial class FAgenda
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
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new GustoSano.LDControles.LDButton();
            this.txtFecha = new GustoSano.LDControles.LDTextBox();
            this.txtNombreYApellido = new GustoSano.LDControles.LDTextBox();
            this.txtBuscarAgenda = new GustoSano.LDControles.LDTextBox();
            this.btnBuscarPaciente = new GustoSano.LDControles.LDButton();
            this.btnEliminar = new GustoSano.LDControles.LDButton();
            this.btnEditar = new GustoSano.LDControles.LDButton();
            this.btnGuardar = new GustoSano.LDControles.LDButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.Calendario.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.Calendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario.Location = new System.Drawing.Point(164, 79);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // dtHora
            // 
            this.dtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(798, 212);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(87, 26);
            this.dtHora.TabIndex = 1;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(12, 488);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(1235, 264);
            this.dgvAgenda.TabIndex = 2;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(735, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hora";
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(798, 249);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(283, 24);
            this.cmbMotivo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Motivo";
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
            this.btnLimpiar.Location = new System.Drawing.Point(894, 338);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Window;
            this.txtFecha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFecha.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFecha.BorderRadius = 0;
            this.txtFecha.BorderSize = 2;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.DimGray;
            this.txtFecha.Location = new System.Drawing.Point(798, 165);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Multiline = false;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFecha.PasswordChar = false;
            this.txtFecha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFecha.PlaceholderText = "";
            this.txtFecha.Size = new System.Drawing.Size(283, 31);
            this.txtFecha.TabIndex = 9;
            this.txtFecha.Texts = "";
            this.txtFecha.UnderlinedStyle = false;
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
            this.txtNombreYApellido.Location = new System.Drawing.Point(738, 123);
            this.txtNombreYApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreYApellido.Multiline = false;
            this.txtNombreYApellido.Name = "txtNombreYApellido";
            this.txtNombreYApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreYApellido.PasswordChar = false;
            this.txtNombreYApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreYApellido.PlaceholderText = "";
            this.txtNombreYApellido.Size = new System.Drawing.Size(343, 31);
            this.txtNombreYApellido.TabIndex = 8;
            this.txtNombreYApellido.Texts = "";
            this.txtNombreYApellido.UnderlinedStyle = false;
            // 
            // txtBuscarAgenda
            // 
            this.txtBuscarAgenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarAgenda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBuscarAgenda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscarAgenda.BorderRadius = 0;
            this.txtBuscarAgenda.BorderSize = 2;
            this.txtBuscarAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAgenda.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscarAgenda.Location = new System.Drawing.Point(13, 450);
            this.txtBuscarAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarAgenda.Multiline = false;
            this.txtBuscarAgenda.Name = "txtBuscarAgenda";
            this.txtBuscarAgenda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarAgenda.PasswordChar = false;
            this.txtBuscarAgenda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarAgenda.PlaceholderText = "Buscar turno por id";
            this.txtBuscarAgenda.Size = new System.Drawing.Size(406, 31);
            this.txtBuscarAgenda.TabIndex = 7;
            this.txtBuscarAgenda.Texts = "";
            this.txtBuscarAgenda.UnderlinedStyle = false;
            this.txtBuscarAgenda._TextChanged += new System.EventHandler(this.txtBuscarAgenda__TextChanged);
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
            this.btnBuscarPaciente.Location = new System.Drawing.Point(738, 76);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(150, 40);
            this.btnBuscarPaciente.TabIndex = 6;
            this.btnBuscarPaciente.Text = "Buscar paciente";
            this.btnBuscarPaciente.TextColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(738, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(894, 292);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(738, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 764);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNombreYApellido);
            this.Controls.Add(this.txtBuscarAgenda);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.Calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAgenda";
            this.Text = "FAgenda";
            this.Load += new System.EventHandler(this.FAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private LDControles.LDButton btnGuardar;
        private LDControles.LDButton btnEditar;
        private LDControles.LDButton btnEliminar;
        private LDControles.LDButton btnBuscarPaciente;
        private LDControles.LDTextBox txtBuscarAgenda;
        private LDControles.LDTextBox txtNombreYApellido;
        private LDControles.LDTextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label label3;
        private LDControles.LDButton btnLimpiar;
    }
}