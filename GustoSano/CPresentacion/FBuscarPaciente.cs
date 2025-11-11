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
        private FMenus _formPrincipal;

        public FBuscarPaciente(FMenus fMenus)
        {
            InitializeComponent();
            _formPrincipal = fMenus;
        }

        ClsBuscarPaciente_L logica = new ClsBuscarPaciente_L();

        private void FBuscarPaciente_Load(object sender, EventArgs e)
        {
            mostrarPacientes();
        }

        private void mostrarPacientes()
        {
            dgvBuscarPaciente.DataSource = logica.mostrarPacientes_L();
            dgvBuscarPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscarPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscarPaciente.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvBuscarPaciente.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvBuscarPaciente.SelectedRows[0];

                _formPrincipal.fNombrePaciente = fila.Cells["Nombre"].Value.ToString();
                _formPrincipal.fApellidoPaciente = fila.Cells["Apellido"].Value.ToString();
                _formPrincipal.fObjetivo = fila.Cells["Objetivo"].Value.ToString();
                _formPrincipal.fPatologia = fila.Cells["Patologia"].Value.ToString();
                _formPrincipal.fAlergia = fila.Cells["Alergia"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
