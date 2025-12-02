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
        private FReportes _formReportes;
        private FHistClinica _formHistClinica;
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

        public FBuscarPaciente(FReportes freporte, string funcionBtn)
        {
            InitializeComponent();
            _formReportes = freporte;
            _funcionBtn = funcionBtn;
        }

        public FBuscarPaciente(FHistClinica fHistClinica, string funcionBtn)
        {
            InitializeComponent();
            _formHistClinica = fHistClinica;
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
            else if (_funcionBtn == "fmenu")
            {
                dgvBuscarPaciente.DataSource = logica.mostrarPacientesMenus_L();
            }
            else
            {
                dgvBuscarPaciente.DataSource = logica.mostrarPacientesReportes_L();
            }

            foreach (DataGridViewColumn col in dgvBuscarPaciente.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvBuscarPaciente.ClearSelection();
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
                else if (_funcionBtn == "fagenda")
                {
                    _formAgendas.nombrePaciente = fila.Cells["nombrePaciente"].Value.ToString();
                    _formAgendas.apellidoPaciente = fila.Cells["apellidoPaciente"].Value.ToString();
                }
                else if (_funcionBtn == "fhistclinica")
                {
                    _formHistClinica.idPaciente = Convert.ToInt32(fila.Cells["idPaciente"].Value.ToString());
                }
                else
                {
                    _formReportes.idPaciente = Convert.ToInt32(fila.Cells["idPaciente"].Value.ToString());
                    _formReportes.nombrePaciente = fila.Cells["nombrePaciente"].Value.ToString();
                    _formReportes.apellidoPaciente = fila.Cells["apellidoPaciente"].Value.ToString();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un paciente de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<DataTable> buscarPacienteMenusAsync(string nombrePaciente)
        {
            return await Task.Run(() => logica.buscarPacienteMenus_L(nombrePaciente));
        }

        private async Task<DataTable> buscarPacienteAgendaAsync(string nombrePaciente)
        {
            return await Task.Run(() => logica.buscarPacienteAgenda_L(nombrePaciente));
        }

        private async Task<DataTable> buscarPacienteReporteAsync(string nombrePaciente)
        {
            return await Task.Run(() => logica.buscarPacienteReportes_L(nombrePaciente));
        }

        private async void txtBuscarPaciente__TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBuscarPaciente.Texts))
            {
                DataTable tabla;

                if (_funcionBtn == "fmenu")
                {
                    tabla = await buscarPacienteMenusAsync(txtBuscarPaciente.Texts);
                    dgvBuscarPaciente.DataSource = tabla;
                }
                else if (_funcionBtn == "fagenda")
                {
                    tabla = await buscarPacienteAgendaAsync(txtBuscarPaciente.Texts);
                    dgvBuscarPaciente.DataSource = tabla;
                }
                else
                {
                    tabla = await buscarPacienteReporteAsync(txtBuscarPaciente.Texts);
                    dgvBuscarPaciente.DataSource = tabla;
                }

                foreach (DataGridViewColumn col in dgvBuscarPaciente.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                dgvBuscarPaciente.ClearSelection();

                return;
            }

            mostrarPacientes();
        }
    }
}
