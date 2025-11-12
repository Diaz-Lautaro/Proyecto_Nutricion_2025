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
        }

        public string nombrePaciente { get; set; }
        public string apellidoPaciente { get; set; }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            FBuscarPaciente fBuscarPaciente = new FBuscarPaciente(this, "fagenda");

            if (fBuscarPaciente.ShowDialog() == DialogResult.OK)
            {
                txtNombreYApellido.Texts = nombrePaciente + " " + apellidoPaciente;
            }
        }
    }
}
