using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GustoSano.CDatos;
using GustoSano.CLogica;

namespace GustoSano.CPresentacion
{
    public partial class FRecetas : Form
    {
        public FRecetas()
        {
            InitializeComponent();
        }

        ClsRecetas_L logica = new ClsRecetas_L();


        private void FRecetas_Load(object sender, EventArgs e)
        {
            mostrarRecetas();
            cargarComboBox();
        }

        #region --> Método limpiar
        private void limpiarCampos()
        {
            txtNombreReceta.Texts = string.Empty;
            txtDescripcion.Texts = string.Empty;
            txtCalorias.Texts = string.Empty;
            cmbObjetivo.SelectedIndex = 0;
            cmbPatologia.SelectedIndex = 0;
            cmbAlergia.SelectedIndex = 0;
            cmbTipoComida.SelectedIndex = 0;
        }
        #endregion

        #region --> ComboBox recetas
        //🔹 Cargar categorías 
        private void cargarComboBox()
        {
            cmbObjetivo.Items.AddRange(new object[]
           {
                "-",
                "Aumento de masa",
                "Bajar de peso",
                "Mantener",
                "Reducir grasa corp.",
           });
            cmbObjetivo.SelectedIndex = 0;


            cmbPatologia.Items.AddRange(new object[]
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


            cmbTipoComida.Items.AddRange(new object[]
            {
                "-",
                "Desayuno",
                "Almuerzo",
                "Merienda",
                "Cena",
            });
            cmbTipoComida.SelectedIndex = 0;


            cmbAlergia.Items.AddRange(new string[]
            {
                "-",
                "Lácteos",
                "Maní",
                "Gluten",
                "Frutas cítricas"
            });
            cmbAlergia.SelectedIndex = 0;

        }
        #endregion

        #region --> Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            logica.nombreReceta = txtNombreReceta.Texts;
            logica.descripcion = txtDescripcion.Texts;
            logica.calorias = int.Parse(txtCalorias.Texts);
            logica.tipoComida = cmbTipoComida.Text;
            logica.patologiaAsociada = cmbPatologia.Text;
            logica.alergia = cmbAlergia.Text;
            logica.objetivo = cmbObjetivo.Text;

            logica.agregarReceta_L(logica);
            mostrarRecetas();

            limpiarCampos();
        }

        private int idReceta;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            logica.idReceta = idReceta;
            logica.nombreReceta = txtNombreReceta.Texts;
            logica.descripcion = txtDescripcion.Texts;
            logica.calorias = int.Parse(txtCalorias.Texts);
            logica.tipoComida = cmbTipoComida.Text;
            logica.patologiaAsociada = cmbPatologia.Text;
            logica.alergia = cmbAlergia.Text;
            logica.objetivo = cmbObjetivo.Text;

            logica.modificarReceta_L(logica);
            mostrarRecetas();

            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRecetas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRecetas.CurrentRow.Cells["IdReceta"].Value);
                logica.eliminarReceta_L(id);

                mostrarRecetas();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        #endregion

        public void mostrarRecetas()
        {
            dgvRecetas.DataSource = logica.mostrarReceta_L();
            dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecetas.ReadOnly = true;
        }

        private void dgvRecetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idReceta = Convert.ToInt32(dgvRecetas.CurrentRow.Cells["idReceta"].Value.ToString());
                txtNombreReceta.Texts = dgvRecetas.CurrentRow.Cells["nombreReceta"].Value.ToString();
                txtDescripcion.Texts = dgvRecetas.CurrentRow.Cells["descripcion"].Value.ToString();
                txtCalorias.Texts = dgvRecetas.CurrentRow.Cells["calorias"].Value.ToString();
                cmbTipoComida.Text = dgvRecetas.CurrentRow.Cells["tipoComida"].Value.ToString();
                cmbPatologia.Text = dgvRecetas.CurrentRow.Cells["patologiaAsociada"].Value.ToString();
                cmbAlergia.Text = dgvRecetas.CurrentRow.Cells["alergia"].Value.ToString();
                cmbObjetivo.Text = dgvRecetas.CurrentRow.Cells["objetivo"].Value.ToString();
            }
        }

        private void txtBuscarReceta__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarReceta.Texts))
            {
                dgvRecetas.DataSource = logica.mostrarReceta_L();
            }
            else
            {
                dgvRecetas.DataSource = logica.buscarReceta_L(Convert.ToInt32(txtBuscarReceta.Texts));
                dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRecetas.ReadOnly = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion__TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ldPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbObjetivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

