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
    public partial class FPacientes : Form
    {
        public FPacientes()
        {
            InitializeComponent();
        }

        ClsPacientes_L logica = new ClsPacientes_L();
        private int idPacienteSeleccionado = 0;

        private void FPacientes_Load(object sender, EventArgs e)
        {
            mostrarPacientes();
        }

        #region --> Método Limpiar
        private void LimpiarCampos()
        {
            txtNombre.Texts = string.Empty;
            txtApellido.Texts = string.Empty;
            txtEdad.Texts = string.Empty;
            txtSexo.Texts = string.Empty;
            txtFechaNac.Texts = string.Empty;
            txtTelefono.Texts = string.Empty;
        }
        #endregion

        #region --> Botones
        private void btnCargar_Click(object sender, EventArgs e)
        {
            logica.nombrePaciente = txtNombre.Texts;
            logica.apellidoPaciente = txtApellido.Texts;
            logica.edadPaciente = Convert.ToInt32(txtEdad.Texts);
            logica.sexoPaciente = txtSexo.Texts;
            logica.fechaNacPaciente = txtFechaNac.Texts;
            logica.telefonoPaciente = txtTelefono.Texts;

            logica.agregarPaciente(logica);
            mostrarPacientes();

            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idPacienteSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un paciente antes de modificar.");
                return;
            }

            logica.idPaciente = idPacienteSeleccionado;
            logica.nombrePaciente = txtNombre.Texts;
            logica.apellidoPaciente = txtApellido.Texts;
            logica.edadPaciente = Convert.ToInt32(txtEdad.Texts);
            logica.sexoPaciente = txtSexo.Texts;
            logica.fechaNacPaciente = txtFechaNac.Texts;
            logica.telefonoPaciente = txtTelefono.Texts;

            logica.modificarPaciente_L(logica);
            mostrarPacientes();
            idPacienteSeleccionado = 0;

            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPacienteSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un paciente antes de eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este paciente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                logica.eliminarPaciente_L(idPacienteSeleccionado);

                mostrarPacientes();
                idPacienteSeleccionado = 0;
            }

            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion

        private void mostrarPacientes()
        {
            dgvPacientes.DataSource = logica.cargarPacientes_L();
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.ReadOnly = true;
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPacientes.Rows[e.RowIndex];

                idPacienteSeleccionado = Convert.ToInt32(fila.Cells["idPaciente"].Value);
                txtNombre.Texts = fila.Cells["nombrePaciente"].Value.ToString();
                txtApellido.Texts = fila.Cells["apellidoPaciente"].Value.ToString();
                txtEdad.Texts = fila.Cells["edadPaciente"].Value.ToString();
                txtSexo.Texts = fila.Cells["sexoPaciente"].Value.ToString();
                txtFechaNac.Texts = fila.Cells["sexoPaciente"].Value.ToString();
                txtTelefono.Texts = fila.Cells["telefonoPaciente"].Value.ToString();
            }
        }

        private void txtBuscarPaciente__TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarPaciente.Texts, out int idPaciente))
            {
                DataTable tabla = logica.buscarPacientePorID_L(idPaciente);
                dgvPacientes.DataSource = tabla;
            }
            else if (string.IsNullOrWhiteSpace(txtBuscarPaciente.Texts))
            {
                mostrarPacientes();
            }
        }
    }
}
