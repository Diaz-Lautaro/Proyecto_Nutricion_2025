using GustoSano.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GustoSano.CPresentacion
{
    public partial class FBuscarMenus : Form
    {
        private FReportes _formReporte;

        public FBuscarMenus(FReportes freporte)
        {
            InitializeComponent();
            _formReporte = freporte;
        }

        ClsBuscarMenu_L logica = new ClsBuscarMenu_L();

        private void FBuscarMenus_Load(object sender, EventArgs e)
        {
            mostrarMenu();
        }

        private void mostrarMenu()
        {
            dgvBuscarMenu.DataSource = logica.mostrarMenu_L();

            foreach (DataGridViewColumn col in dgvBuscarMenu.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvBuscarMenu.ClearSelection();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarMenu__TextChanged(object sender, EventArgs e)
        {
            DataTable tabla = logica.buscarMenu_L(txtBuscarMenu.Texts);
            dgvBuscarMenu.DataSource = tabla;
            foreach (DataGridViewColumn col in dgvBuscarMenu.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvBuscarMenu.ClearSelection() ;
        }


        private void btnCargarMenu_Click(object sender, EventArgs e)
        {
            if (dgvBuscarMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvBuscarMenu.SelectedRows[0];

                _formReporte.nombreMenu  = fila.Cells["nombreMenu"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un menu de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
