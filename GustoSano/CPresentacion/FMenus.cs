using GustoSano.CLogica;
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

        //        ClsMenus_L logica = new ClsMenus_L();
        //        ClsRecetas_L logicaRecetas = new ClsRecetas_L();
        //        private DataTable recetasDisponibles; 

        //        private void mostrarMenus()
        //        {
        //            dgvMenus.DataSource = logica.mostrarMenus_L();
        //            dgvMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //            dgvMenus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //            dgvMenus.ReadOnly = true;
        //        }

        //        private void mostrarRecetasDisponibles()
        //        {
        //            recetasDisponibles = logicaRecetas.mostrarReceta_L();
        //            lstRecetas.Items.Clear();

        //            foreach (DataRow fila in recetasDisponibles.Rows)
        //            {
        //                lstRecetas.Items.Add($"{fila["idReceta"]} - {fila["NombreReceta"]}");
        //            }
        //        }

        //        // 🔹 Agregar menú
        //        private void btnAgregar_Click(object sender, EventArgs e)
        //        {
        //            if (string.IsNullOrWhiteSpace(txtNombreMenu.Texts) ||
        //                cmbCategoria.SelectedIndex == -1 ||
        //                cmbTipoComida.SelectedIndex == -1)
        //            {
        //                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                return;
        //            }

        //            logica.NombreMenu = txtNombreMenu.Texts;
        //            logica.Descripcion = txtDescripcion.Texts;
        //            logica.Categoria = cmbCategoria.Text;
        //            logica.PatologiaAsociada = cmbBuscarPatologia.Text;
        //            logica.TipoComida = cmbTipoComida.Text;

        //            logica.agregarMenu_L(logica);
        //            mostrarMenus();
        //        }

        //        // 🔹 Eliminar menú seleccionado
        //        private void btnEliminar_Click(object sender, EventArgs e)
        //        {
        //            if (dgvMenus.CurrentRow == null)
        //            {
        //                MessageBox.Show("Seleccione un menú para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                return;
        //            }

        //            int idMenu = Convert.ToInt32(dgvMenus.CurrentRow.Cells["id_menu"].Value);
        //            logica.eliminarMenu_L(idMenu);
        //            mostrarMenus();
        //        }

        //        // 🔹 Agregar receta al menú
        //        private void btnAgregarReceta_Click(object sender, EventArgs e)
        //        {
        //            if (lstRecetas.SelectedItem == null)
        //            {
        //                MessageBox.Show("Seleccione una receta para agregar al menú.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                return;
        //            }

        //            string recetaSeleccionada = lstRecetas.SelectedItem.ToString();

        //            if (!lstMenuRecetas.Items.Contains(recetaSeleccionada))
        //            {
        //                lstMenuRecetas.Items.Add(recetaSeleccionada);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Esa receta ya está en el menú.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }

        //        // 🔹 Eliminar receta del menú
        //        private void btnEliminarReceta_Click(object sender, EventArgs e)
        //        {
        //            if (lstMenuRecetas.SelectedItem != null)
        //            {
        //                lstMenuRecetas.Items.Remove(lstMenuRecetas.SelectedItem);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Seleccione una receta del menú para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }

        //        // 🔹 Filtro en tiempo real por patología
        //        private void cmbBuscarPatologia_SelectedIndexChanged(object sender, EventArgs e)
        //        {
        //            string filtro = cmbBuscarPatologia.Text;

        //            DataTable recetasFiltradas = recetasDisponibles.Clone();

        //            foreach (DataRow fila in recetasDisponibles.Rows)
        //            {
        //                string patologia = fila["PatologiaAsociada"].ToString();

        //                if (filtro == "Todas" || patologia.Equals(filtro, StringComparison.OrdinalIgnoreCase))
        //                {
        //                    recetasFiltradas.ImportRow(fila);
        //                }
        //            }

        //            lstRecetas.Items.Clear();
        //            foreach (DataRow fila in recetasFiltradas.Rows)
        //            {
        //                lstRecetas.Items.Add($"{fila["idReceta"]} - {fila["NombreReceta"]}");
        //            }
        //        }
        //    }
        //}

        private void FMenus_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        #region --> ComboBox recetas
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

        
    }
}
