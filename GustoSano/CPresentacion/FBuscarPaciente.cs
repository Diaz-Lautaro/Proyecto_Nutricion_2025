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
    public partial class FBuscarPaciente : Form
    {
        public FBuscarPaciente()
        {
            InitializeComponent();
        }

        ClsPacientes_L logica = new ClsPacientes_L();

        private void FBuscarPaciente_Load(object sender, EventArgs e)
        {
            mostrarPacientes();
        }

        private void mostrarPacientes()
        {
            dgvBuscarPaciente.DataSource = logica.cargarPacientes_L();
            dgvBuscarPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscarPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscarPaciente.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
