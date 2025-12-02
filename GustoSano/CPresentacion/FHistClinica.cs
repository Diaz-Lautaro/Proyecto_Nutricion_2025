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
    public partial class FHistClinica : Form
    {
        public FHistClinica()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        ClsHisClinica_L logica = new ClsHisClinica_L();
        ClsPacientes_L logicaPaciente = new ClsPacientes_L();
        ClsBuscarPaciente_L logicaBuscarPaciente = new ClsBuscarPaciente_L();

        public int idPaciente { get; set; }


        private async void FHistClinica_Load(object sender, EventArgs e)
        {
            dgvHisClinica.DataSource = await MostrarHistClinicasAsync();

            foreach (DataGridViewColumn col in dgvHisClinica.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvHisClinica.ClearSelection();

            CargarComboBox();
        }

        #region --> ComboBox
        private void CargarComboBox()
        {
            cmbPatologia.Items.AddRange(new string[]
            {
                "-",
                "Diabetes",
                "Hipertensión",
                "Celiaquía",
                "Colesterol alto",
                "Gatritis",
                "Obesidad"
            });
            cmbPatologia.SelectedIndex = 0;


            cmbAlergia.Items.AddRange(new string[]
            {
                "-",
                "Lácteos",
                "Maní",
                "Gluten",
                "Frutas cítricas"
            });
            cmbAlergia.SelectedIndex = 0;


            cmbObjetivo.Items.AddRange(new string[]
            {
                "-",
                "Aumento de masa",
                "Bajar de peso",
                "Mantener",
                "Reducir grasa corp.",
            });
            cmbObjetivo.SelectedIndex = 0;


            cmbDiagnostico.Items.AddRange(new string[]
            {
                "-",
                "Bajo peso leve",
                "Peso normal",
                "Sobrepeso leve",
                "Sobrepeso moderado",
                "Obesidad grado I",
                "Obesidad grado II",
                "Desnutrición leve",
                "Desnutrición moderada"
            });
            cmbDiagnostico.SelectedIndex = 0;
        }
        #endregion

        #region --> Metodos cargar tablas
        private async Task<DataTable> MostrarHistClinicasAsync()
        {
            return await Task.Run(() => logica.mostrarHistoriasClinicas_L());
        }

        private async Task agregarHistoriaClinicaAsync(ClsHisClinica_L logica)
        {
            await Task.Run(() => logica.agregarHistoriaClinica_L(logica));
        }

        private async Task modificarHistoriaClinicaAsync(ClsHisClinica_L logica)
        {
            await Task.Run(() => logica.modificarHistoriaClinica_L(logica));
        }
        #endregion

        #region --> Método limpiar
        private void LimpiarCampos()
        {
            txtIdPaciente.Texts = string.Empty;
            txtPeso.Texts = string.Empty;
            txtAltura.Texts = string.Empty;
            txtMedicamentos.Texts = string.Empty;
            txtTipoDieta.Texts = string.Empty;
            txtComidas.Texts = string.Empty;
            txtHorarios.Texts = string.Empty;
            txtAgua.Texts = string.Empty;
            txtActividad.Texts = string.Empty;

            cmbDiagnostico.SelectedIndex = 0;
            cmbAlergia.SelectedIndex = 0;
            cmbPatologia.SelectedIndex = 0;
            cmbObjetivo.SelectedIndex = 0;
        }
        #endregion

        #region -- Botones
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            logica.idPaciente = Convert.ToInt32(txtIdPaciente.Texts);
            logica.peso = Convert.ToDecimal(txtPeso.Texts);
            logica.altura = Convert.ToDecimal(txtAltura.Texts);
            logica.diagnostico = cmbDiagnostico.Text;
            logica.alergias = cmbAlergia.SelectedItem.ToString();
            logica.patologias = cmbPatologia.SelectedItem.ToString();
            logica.medicamentos = txtMedicamentos.Texts;
            logica.tipoDietaActual = txtTipoDieta.Texts;
            logica.comidasDiarias = Convert.ToInt32(txtComidas.Texts);
            logica.horarios = txtHorarios.Texts;
            logica.consumoAgua = txtAgua.Texts;
            logica.objetivo = cmbObjetivo.SelectedItem.ToString();
            logica.actividadFisica = txtActividad.Texts;

            await agregarHistoriaClinicaAsync(logica);
            dgvHisClinica.DataSource = await MostrarHistClinicasAsync();

            dgvHisClinica.ClearSelection();
            LimpiarCampos();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                logica.idPaciente = Convert.ToInt32(txtIdPaciente.Texts);
                logica.peso = Convert.ToDecimal(txtPeso.Texts);
                logica.altura = Convert.ToDecimal(txtAltura.Texts);
                logica.diagnostico = cmbDiagnostico.Text;
                logica.alergias = cmbAlergia.Text;
                logica.patologias = cmbPatologia.Text;
                logica.medicamentos = txtMedicamentos.Texts;
                logica.tipoDietaActual = txtTipoDieta.Texts;
                logica.comidasDiarias = Convert.ToInt32(txtComidas.Texts);
                logica.horarios = txtHorarios.Texts;
                logica.consumoAgua = txtAgua.Texts;
                logica.objetivo = cmbObjetivo.Text;
                logica.actividadFisica = txtActividad.Texts;

                await modificarHistoriaClinicaAsync(logica);
                dgvHisClinica.DataSource = MostrarHistClinicasAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

            LimpiarCampos();
        }

        private void btnLimipiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion


        private void dgvHisClinica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHisClinica.Rows[e.RowIndex].Cells["idPaciente"].Value != null)
            {
                DataGridViewRow fila = dgvHisClinica.Rows[e.RowIndex];

                if (fila.Cells["idPaciente"].Value != DBNull.Value)
                {
                    txtIdPaciente.Texts = fila.Cells["idPaciente"].Value.ToString();
                    txtPeso.Texts = fila.Cells["peso"].Value.ToString();
                    txtAltura.Texts = fila.Cells["altura"].Value.ToString();
                    cmbDiagnostico.Text = fila.Cells["diagnostico"].Value.ToString();
                    cmbAlergia.Text = fila.Cells["alergias"].Value.ToString();
                    cmbPatologia.Text = fila.Cells["patologias"].Value.ToString();
                    txtMedicamentos.Texts = fila.Cells["medicamentos"].Value.ToString();
                    txtTipoDieta.Texts = fila.Cells["tipoDietaActual"].Value.ToString();
                    txtComidas.Texts = fila.Cells["comidasDiarias"].Value.ToString();
                    txtHorarios.Texts = fila.Cells["horarios"].Value.ToString();
                    txtAgua.Texts = fila.Cells["consumoAgua"].Value.ToString();
                    cmbObjetivo.Text = fila.Cells["objetivo"].Value.ToString();
                    txtActividad.Texts = fila.Cells["actividadFisica"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro válido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtBuscarHistClinica__TextChanged(object sender, EventArgs e)
        {
            DataTable tabla;
            if (int.TryParse(txtBuscarHistoria.Texts, out int idPaciente))
            {
                tabla = logica.BuscarHistoriaPorID_L(idPaciente);
                dgvHisClinica.DataSource = tabla;
            }
            else if (string.IsNullOrWhiteSpace(txtBuscarHistoria.Texts))
            {
                dgvHisClinica.DataSource = MostrarHistClinicasAsync();
            }

            foreach (DataGridViewColumn col in dgvHisClinica.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgvHisClinica.ClearSelection();
        }


        private void btnBuscarpaciente_Click(object sender, EventArgs e)
        {
            FBuscarPaciente fBuscarPaciente = new FBuscarPaciente(this, "fhistclinica");

            if (fBuscarPaciente.ShowDialog() == DialogResult.OK)
            {
                txtIdPaciente.Texts = idPaciente.ToString();

            }
        }
    }
}
