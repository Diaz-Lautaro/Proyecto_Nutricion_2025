using GustoSano.CLogica;
using GustoSano.CPresentacion;
using System;
using System.Data;
using System.Windows.Forms;

namespace GustoSano
{
    public partial class FMenus : Form
    {
        public string fNombrePaciente { get; set; }
        public string fApellidoPaciente { get; set; }
        public string fObjetivo { get; set; }
        public string fPatologia { get; set; }
        public string fAlergia { get; set; }

        public FMenus()
        {
            InitializeComponent();
        }

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
            if(string.IsNullOrEmpty(txtNombreYApellido.Texts)) 
                FiltrarRecetas();

            logica.objetivo = txtObjetivoPaciente.Texts;
            logica.patologiaAsociada = txtPatologiaPaciente.Texts;
            logica.alergia = txtAlergiaPaciente.Texts;
            logica.tipoComida = cmbTipoComidaReceta.Text;
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

        #region --> Botones
        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            cmbObjetivoReceta.SelectedIndex = 0;
            cmbPatologiaReceta.SelectedIndex = 0;
            cmbAlergiaReceta.SelectedIndex = 0;
            cmbTipoComidaReceta.SelectedIndex = 0;
        }

        private void btnQuitarPaciente_Click(object sender, EventArgs e)
        {
            txtNombreYApellido.Texts = string.Empty;
            txtObjetivoPaciente.Texts = string.Empty;
            txtPatologiaPaciente.Texts = string.Empty;
            txtAlergiaPaciente.Texts = string.Empty;
            cmbTipoComidaReceta.SelectedIndex = 0;

            dgvRecetas.DataSource = logica.mostrarRecetas_L();
            dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecetas.ReadOnly = true;
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            FBuscarPaciente FBuscarPaciente = new FBuscarPaciente(this);

            if (FBuscarPaciente.ShowDialog() == DialogResult.OK)
            {
                cmbTipoComidaReceta.SelectedIndex = 0;
                txtNombreYApellido.Texts = fNombrePaciente + " " + fApellidoPaciente;
                logica.objetivo = txtObjetivoPaciente.Texts = fObjetivo;
                logica.patologiaAsociada = txtPatologiaPaciente.Texts = fPatologia;
                logica.alergia = txtAlergiaPaciente.Texts = fAlergia;

                dgvRecetas.DataSource = logica.filtrarReceta_L(logica);
                dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRecetas.ReadOnly = true;
            }
        }
        #endregion
    }
}
