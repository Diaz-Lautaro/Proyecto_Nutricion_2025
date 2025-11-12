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
        private FMenus _formMenus;
        private FAgenda _formAgendas;
        private string _funcionBtn;

        public FBuscarPaciente(FMenus fMenus, string funcionBtn)
        {
            InitializeComponent();
            _formMenus = fMenus;
            _funcionBtn = funcionBtn;
        }

        public FBuscarPaciente(FAgenda fAgenda, string funcionBtn)
        {
            InitializeComponent();
            _formAgendas = fAgenda;
            _funcionBtn = funcionBtn;
        }

        ClsBuscarPaciente_L logica = new ClsBuscarPaciente_L();

        private void FBuscarPaciente_Load(object sender, EventArgs e)
        {
            mostrarPacientes();
        }

        private void mostrarPacientes()
        {
            if (_funcionBtn == "fagenda")
            {
                dgvBuscarPaciente.DataSource = logica.mostrarPacientesAgenda_L();
            }
            else
            {
                dgvBuscarPaciente.DataSource = logica.mostrarPacientesMenus_L();
            }

            dgvBuscarPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscarPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscarPaciente.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarPacienteMenus_Click(object sender, EventArgs e)
        {
            if (dgvBuscarPaciente.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvBuscarPaciente.SelectedRows[0];

                if (_funcionBtn == "fmenu")
                {
                    _formMenus.fNombrePaciente = fila.Cells["Nombre"].Value.ToString();
                    _formMenus.fApellidoPaciente = fila.Cells["Apellido"].Value.ToString();
                    _formMenus.fObjetivo = fila.Cells["Objetivo"].Value.ToString();
                    _formMenus.fPatologia = fila.Cells["Patologia"].Value.ToString();
                    _formMenus.fAlergia = fila.Cells["Alergia"].Value.ToString();
                }
                else
                {
                    _formAgendas.nombrePaciente = fila.Cells["nombrePaciente"].Value.ToString();
                    _formAgendas.apellidoPaciente = fila.Cells["apellidoPaciente"].Value.ToString();
                }

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
