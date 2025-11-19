using GustoSano.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GustoSano.CPresentacion;

namespace GustoSano.CPresentacion
{
    public partial class FIniciarSesion : Form
    {
        public FIniciarSesion()
        {
            InitializeComponent();
        }

        ClsIniciarSesion_L logica = new ClsIniciarSesion_L();

        #region --> Mover Form
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void FIniciarSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }
        #endregion


        private void btnInicarSesion_Click(object sender, EventArgs e)
        {
            logica.nombreUsuario = txtUsuario.Texts;
            logica.contraseñaUsuario = txtContraseña.Texts;

            if (logica.IniciarSesion_L(logica))
            {
                FMain main = new FMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al iniciar sesión");
            }


        }

        private void pbCerrarForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbCerrarForm_MouseEnter(object sender, EventArgs e)
        {
            pbCerrarForm.BackColor = Color.DarkGray;
        }

        private void pbCerrarForm_MouseLeave(object sender, EventArgs e)
        {
            pbCerrarForm.BackColor = Color.FromArgb(220, 226, 224);
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FCrearCuenta fCrearCuenta = new FCrearCuenta();
            fCrearCuenta.ShowDialog();
        }
    }
}
