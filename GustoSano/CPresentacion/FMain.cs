using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using GustoSano.CPresentacion;

namespace GustoSano
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        List<Button> botonesMenu;
        private int cambiarbtn;
        private void FMain_Load(object sender, EventArgs e)
        {
            btnPacientes.BackColor = Color.FromArgb(62, 39, 66);
            btnPacientes.Image = Properties.Resources.Paciente2;
            cambiarbtn = 1;
            FPacientes fPacientes = new FPacientes();
            abrirFormularioEnPanel(fPacientes);

            botonesMenu = new List<Button> { btnAbrirMenu, btnPacientes, btnHisClinica, btnReceta, btnComida, btnAgenda, btnGrafico, btnReporte, btnConfiguracion, btnSalir };
        }

        private void CambiarColorBtn(Button btnActivo)
        {
            foreach (Button btn in botonesMenu)
            {
                // Si es el botón presionado
                if (btn == btnActivo)
                {
                    btn.BackColor = Color.FromArgb(62, 39, 66);
                    if (btn.Name == "btnAbrirMenu")
                        btn.Image = Properties.Resources.Menu1;
                    else if (btn.Name == "btnPacientes")
                        btn.Image = Properties.Resources.Paciente2;
                    else if (btn.Name == "btnHisClinica")
                        btn.Image = Properties.Resources.HistClinica1;
                    else if (btn.Name == "btnReceta")
                        btn.Image = Properties.Resources.Receta1;
                    else if (btn.Name == "btnComida")
                        btn.Image = Properties.Resources.Comida1;
                    else if (btn.Name == "btnAgenda")
                        btn.Image = Properties.Resources.Calendario1;
                    else if (btn.Name == "btnGrafico")
                        btn.Image = Properties.Resources.Grafico1;
                    else if (btn.Name == "btnReporte")
                        btn.Image = Properties.Resources.Reporte1;
                    else if (btn.Name == "btnConfiguracion")
                        btn.Image = Properties.Resources.Config1;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(220, 226, 224);
                    if (btn.Name == "btnAbrirMenu")
                        btn.Image = Properties.Resources.Menu2;
                    else if (btn.Name == "btnPacientes")
                        btn.Image = Properties.Resources.Paciente1;
                    else if (btn.Name == "btnHisClinica")
                        btn.Image = Properties.Resources.HistClinica2;
                    else if (btn.Name == "btnReceta")
                        btn.Image = Properties.Resources.Receta2;
                    else if (btn.Name == "btnComida")
                        btn.Image = Properties.Resources.Comida2;
                    else if (btn.Name == "btnAgenda")
                        btn.Image = Properties.Resources.Calendario2;
                    else if (btn.Name == "btnGrafico")
                        btn.Image = Properties.Resources.Grafico2;
                    else if (btn.Name == "btnReporte")
                        btn.Image = Properties.Resources.Reporte2;
                    else if (btn.Name == "btnConfiguracion")
                        btn.Image = Properties.Resources.Config2;
                }
            }
        }


        private void btnAbrirMenu_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnAbrirMenu);
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnPacientes);
            FPacientes fPacientes = new FPacientes();
            abrirFormularioEnPanel(fPacientes);
        }

        private void btnHisClinica_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnHisClinica);
            FHistClinica fHistClinica = new FHistClinica();
            abrirFormularioEnPanel(fHistClinica);
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnReceta);
            FRecetas fRecetas = new FRecetas();
            abrirFormularioEnPanel(fRecetas);
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnComida);
            FMenus fMenus = new FMenus();
            abrirFormularioEnPanel(fMenus);
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnAgenda);
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnGrafico);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnReporte);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            CambiarColorBtn(btnConfiguracion);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FIniciarSesion fIniciarSesion = new FIniciarSesion();
            fIniciarSesion.Show();
            this.Close();
        }

        private void abrirFormularioEnPanel(Form formHijo)
        {
            // Limpia el panel si ya hay otro formulario cargado
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);

            // Configura el formulario hijo
            formHijo.TopLevel = false;        // No será una ventana independiente
            formHijo.FormBorderStyle = FormBorderStyle.None; // Sin borde ni barra de título
            formHijo.Dock = DockStyle.Fill;   // Ocupará todo el panel

            // Agrega el formulario al panel
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;

            formHijo.Show();
        }

    }
}
