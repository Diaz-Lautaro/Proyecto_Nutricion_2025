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
    public partial class FAgenda : Form
    {
        public FAgenda()
        {
            InitializeComponent();
            Calendario.CalendarDimensions = new Size(2,2);
        }

        public string nombrePaciente { get; set; }
        public string apellidoPaciente { get; set; }

        ClsAgenda_L logica = new ClsAgenda_L();

        private void FAgenda_Load(object sender, EventArgs e)
        {
            cargarMotivo();
            mostrarTurnos();

            dtHora.Format = DateTimePickerFormat.Custom;
            dtHora.CustomFormat = "HH:mm";
            dtHora.ShowUpDown = true;

            List<DateTime> fechas = logica.obtenerFechasConTurnos_L();

            Calendario.BoldedDates = fechas.ToArray();
        }

        private void cargarMotivo()
        {
            cmbMotivo.Items.AddRange(new object[]
            {
                 "-",
                 "Control de peso semanal",
                 "Plan para aumento de masa muscular",
                 "Seguimiento de dieta hipocalórica",
                 "Consulta por hipertensión y alimentación",
                 "Evaluación por intolerancia al gluten",
                 "Revisión de plan vegetariano",
                 "Reevaluación nutricional mensual",
                 "Revisión post tratamiento médico",
                 "Inicio de plan personalizado",
                 "Entrega de nuevo plan alimentario"

            });

            cmbMotivo.SelectedIndex = 0;
        }

        private void mostrarTurnos()
        {
            dgvAgenda.DataSource = logica.mostrarTurnos_L();
            dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgenda.ReadOnly = true;
        }

        private void limpiarCampos()
        {
            txtNombreYApellido.Texts = string.Empty;
            cmbMotivo.SelectedIndex = 0;
            txtFecha.Texts = string.Empty;
            dtHora.Value = DateTime.Now;
        }

        #region --> Botones
        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            FBuscarPaciente fBuscarPaciente = new FBuscarPaciente(this, "fagenda");

            if (fBuscarPaciente.ShowDialog() == DialogResult.OK)
            {
                txtNombreYApellido.Texts = nombrePaciente + " " + apellidoPaciente;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtFecha.Texts, out DateTime fechaSeleccionada))
            {
                logica.nombreYApellido = txtNombreYApellido.Texts;
                logica.motivo = cmbMotivo.Text;
                logica.fecha = txtFecha.Texts;
                logica.hora = dtHora.Value.ToString("HH:mm");
                logica.guardarTurno_L(logica);

                List<DateTime> fechas = logica.obtenerFechasConTurnos_L();
                Calendario.BoldedDates = fechas.ToArray();
                Calendario.UpdateBoldedDates();

                mostrarTurnos();
                limpiarCampos();

                MessageBox.Show("Turno guardado correctamente.", "Turno agendado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvAgenda.SelectedRows[0];

                ClsAgenda_L logica = new ClsAgenda_L
                {
                    idAgenda = Convert.ToInt32(fila.Cells["idAgenda"].Value),
                    nombreYApellido = txtNombreYApellido.Texts,
                    motivo = cmbMotivo.Text,
                    fecha = txtFecha.Texts,
                    hora = dtHora.Value.ToString("HH:mm")
                };

                logica.editarTurno_L(logica);

                List<DateTime> fechas = logica.obtenerFechasConTurnos_L();
                Calendario.BoldedDates = fechas.ToArray();
                Calendario.UpdateBoldedDates();

                mostrarTurnos();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Seleccione un turno para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.SelectedRows.Count > 0)
            {
                int idTurno = Convert.ToInt32(dgvAgenda.SelectedRows[0].Cells["idAgenda"].Value);

                DialogResult confirm = MessageBox.Show("¿Seguro que desea eliminar este turno?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    logica.eliminarTurno_L(idTurno);

                    List<DateTime> fechas = logica.obtenerFechasConTurnos_L();
                    Calendario.BoldedDates = fechas.ToArray();
                    Calendario.UpdateBoldedDates();

                    mostrarTurnos();
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un turno para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        #endregion


        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFecha.Texts = Calendario.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvAgenda.Rows[e.RowIndex];

                txtNombreYApellido.Texts = fila.Cells["nombrePaciente"].Value.ToString();
                cmbMotivo.Text = fila.Cells["motivo"].Value.ToString();
                txtFecha.Texts = fila.Cells["fecha"].Value.ToString();
                dtHora.Value = DateTime.Parse(fila.Cells["hora"].Value.ToString());
            }
        }

        private void txtBuscarAgenda__TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscarAgenda.Texts, out int idTurno))
            {
                dgvAgenda.DataSource = logica.buscarTurnoPorId_L(idTurno);
                dgvAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvAgenda.ReadOnly = true;
            }
            else
            {
                mostrarTurnos();
            }            
        }

        private void ldPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
