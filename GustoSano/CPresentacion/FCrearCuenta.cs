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

namespace GustoSano.CPresentacion
{
    public partial class FCrearCuenta : Form
    {
        public FCrearCuenta()
        {
            InitializeComponent();
        }

        ClsCrearCuenta_L logica = new ClsCrearCuenta_L();

        #region --> Mover Form
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void FCrearCuenta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }
        #endregion

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            logica.nombreUsuario = txtUsuario.Texts;
            logica.gmailUsuario = txtGmail.Texts;
            logica.contraseñaUsuario = txtContraseña.Texts;

            logica.CrearCuenta_L(logica);
            if(logica.banderaCuentaCreada == 1)
                this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
