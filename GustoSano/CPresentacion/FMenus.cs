using GustoSano.CLogica;
using GustoSano.CPresentacion;
using System;
using System.Data;
using System.Windows.Forms;

namespace GustoSano
{
    public partial class FMenus : Form
    {
        public FMenus()
        {
            InitializeComponent();
        }

        FBuscarPaciente FBuscarPaciente = new FBuscarPaciente();
        ClsMenus_L logica = new ClsMenus_L();

        private void FMenus_Load(object sender, EventArgs e)
        {
            cargarComboBox();
            mostrarRecetas();
        }

        #region --> ComboBox datos
        //🔹 Cargar categorías 
        private void cargarComboBox()
        {
            cmbObjetivoReceta.Items.AddRange(new object[]
           {
                "-",
                "Aumento de masa",
                "Bajar de peso",
                "Mantener",
                "Reducir grasa corp.",
           });
            cmbObjetivoReceta.SelectedIndex = 0;


            cmbPatologiaReceta.Items.AddRange(new object[]
            {
                "-",
                "Diabetes",
                "Hipertensión",
                "Celiaquía",
                "Colesterol alto",
                "Gatritis",
                "Obesidad"
            });
            cmbPatologiaReceta.SelectedIndex = 0;


            cmbTipoComidaReceta.Items.AddRange(new object[]
            {
                "-",
                "Desayuno",
                "Almuerzo",
                "Merienda",
                "Cena",
            });
            cmbTipoComidaReceta.SelectedIndex = 0;


            cmbAlergiaReceta.Items.AddRange(new string[]
            {
                "-",
                "Lácteos",
                "Maní",
                "Gluten",
                "Frutas cítricas"
            });
            cmbAlergiaReceta.SelectedIndex = 0;

        }
        #endregion

        #region --> Filtros comboBox

        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            cmbObjetivoReceta.SelectedIndex = 0;
            cmbPatologiaReceta.SelectedIndex = 0;
            cmbAlergiaReceta.SelectedIndex = 0;
            cmbTipoComidaReceta.SelectedIndex = 0;
        }

        private void mostrarRecetas()
        {
            dgvRecetas.DataSource = logica.mostrarRecetas_L();
            dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecetas.ReadOnly = true;
        }

        private void cmbObjetivoReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarRecetas();
        }

        private void cmbPatologiaReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarRecetas();
        }

        private void cmbAlergiaReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarRecetas();
        }

        private void cmbTipoComidaReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarRecetas();
        }

        private void FiltrarRecetas()
        {
            logica.objetivo = cmbObjetivoReceta.Text != "-" ? cmbObjetivoReceta.Text : string.Empty;
            logica.patologiaAsociada = cmbPatologiaReceta.Text != "-" ? cmbPatologiaReceta.Text : string.Empty;
            logica.alergia = cmbAlergiaReceta.Text != "-" ? cmbAlergiaReceta.Text : string.Empty;
            logica.tipoComida = cmbTipoComidaReceta.Text != "-" ? cmbTipoComidaReceta.Text : string.Empty;

            if (string.IsNullOrEmpty(logica.objetivo) &&
                string.IsNullOrEmpty(logica.patologiaAsociada) &&
                string.IsNullOrEmpty(logica.alergia) &&
                string.IsNullOrEmpty(logica.tipoComida))
            {
                dgvRecetas.DataSource = logica.mostrarRecetas_L();
            }
            else
            {
                dgvRecetas.DataSource = logica.filtrarReceta_L(logica);
            }

            dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecetas.ReadOnly = true;
        }
        #endregion

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            FBuscarPaciente.ShowDialog();
        }
    }
}
