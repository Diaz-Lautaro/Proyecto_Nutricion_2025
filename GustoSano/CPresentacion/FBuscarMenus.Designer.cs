using System.Windows.Forms;

namespace GustoSano.CPresentacion
{
    partial class FBuscarMenus
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
            this.dgvBuscarMenu = new System.Windows.Forms.DataGridView();
            this.txtBuscarMenu = new GustoSano.LDControles.LDTextBox();
            this.btnCancelar = new GustoSano.LDControles.LDButton();
            this.btnCargarMenu = new GustoSano.LDControles.LDButton();
            this.ldPanel1 = new GustoSano.LDControles.LDPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMenu)).BeginInit();
            this.ldPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarMenu
            // 
            this.dgvBuscarMenu.AllowUserToAddRows = false;
            this.dgvBuscarMenu.AllowUserToDeleteRows = false;
            this.dgvBuscarMenu.AllowUserToResizeColumns = false;
            this.dgvBuscarMenu.AllowUserToResizeRows = false;
            this.dgvBuscarMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuscarMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dgvBuscarMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuscarMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscarMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscarMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMenu.EnableHeadersVisualStyles = false;
            this.dgvBuscarMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.dgvBuscarMenu.Location = new System.Drawing.Point(11, 10);
            this.dgvBuscarMenu.MultiSelect = false;
            this.dgvBuscarMenu.Name = "dgvBuscarMenu";
            this.dgvBuscarMenu.ReadOnly = true;
            this.dgvBuscarMenu.RowHeadersVisible = false;
            this.dgvBuscarMenu.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBuscarMenu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscarMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarMenu.Size = new System.Drawing.Size(820, 249);
            this.dgvBuscarMenu.TabIndex = 3;
            // 
            // txtBuscarMenu
            // 
            this.txtBuscarMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarMenu.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscarMenu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.txtBuscarMenu.BorderRadius = 9;
            this.txtBuscarMenu.BorderSize = 2;
            this.txtBuscarMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBuscarMenu.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarMenu.Location = new System.Drawing.Point(12, 9);
            this.txtBuscarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarMenu.Multiline = false;
            this.txtBuscarMenu.Name = "txtBuscarMenu";
            this.txtBuscarMenu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarMenu.PasswordChar = false;
            this.txtBuscarMenu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarMenu.PlaceholderText = "Buscar Menú";
            this.txtBuscarMenu.Size = new System.Drawing.Size(471, 36);
            this.txtBuscarMenu.TabIndex = 6;
            this.txtBuscarMenu.Texts = "";
            this.txtBuscarMenu.UnderlinedStyle = false;
            this.txtBuscarMenu._TextChanged += new System.EventHandler(this.txtBuscarMenu__TextChanged);
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
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargarMenu
            // 
            this.btnCargarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnCargarMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnCargarMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCargarMenu.BorderRadius = 20;
            this.btnCargarMenu.BorderSize = 0;
            this.btnCargarMenu.FlatAppearance.BorderSize = 0;
            this.btnCargarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCargarMenu.ForeColor = System.Drawing.Color.White;
            this.btnCargarMenu.Location = new System.Drawing.Point(12, 329);
            this.btnCargarMenu.Name = "btnCargarMenu";
            this.btnCargarMenu.Size = new System.Drawing.Size(150, 40);
            this.btnCargarMenu.TabIndex = 4;
            this.btnCargarMenu.Text = "Cargar ";
            this.btnCargarMenu.TextColor = System.Drawing.Color.White;
            this.btnCargarMenu.UseVisualStyleBackColor = false;
            this.btnCargarMenu.Click += new System.EventHandler(this.btnCargarMenu_Click);
            // 
            // ldPanel1
            // 
            this.ldPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ldPanel1.BorderRadius = 30;
            this.ldPanel1.Controls.Add(this.dgvBuscarMenu);
            this.ldPanel1.ForeColor = System.Drawing.Color.Black;
            this.ldPanel1.GradientAngle = 90F;
            this.ldPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.ldPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.ldPanel1.Location = new System.Drawing.Point(12, 49);
            this.ldPanel1.Name = "ldPanel1";
            this.ldPanel1.Size = new System.Drawing.Size(843, 271);
            this.ldPanel1.TabIndex = 33;
            // 
            // FBuscarMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(874, 381);
            this.Controls.Add(this.txtBuscarMenu);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCargarMenu);
            this.Controls.Add(this.ldPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBuscarMenus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarMenus";
            this.Load += new System.EventHandler(this.FBuscarMenus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMenu)).EndInit();
            this.ldPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LDControles.LDButton btnCancelar;
        private LDControles.LDButton btnCargarMenu;
        private System.Windows.Forms.DataGridView dgvBuscarMenu;
        private LDControles.LDTextBox txtBuscarMenu;
        private LDControles.LDPanel ldPanel1;
    }
}