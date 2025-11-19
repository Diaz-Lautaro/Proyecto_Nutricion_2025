using GustoSano.CDatos;
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
    public partial class FConfiguracion : Form
    {
        public FConfiguracion()
        {
            InitializeComponent();

            lblNombreUsuario.Text = ClsConfig_L.usuarioActivo;
        }

        ClsConfig_L logica = new ClsConfig_L();

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            string actual = txtContraseñaActual.Texts.Trim();
            string nueva = txtContraseñaNueva.Texts.Trim();
            string confirmar = txtConfirmarContraseña.Texts.Trim();

            // 1° Validar campos en blanco
            if (string.IsNullOrWhiteSpace(actual) ||
                string.IsNullOrWhiteSpace(nueva) ||
                string.IsNullOrWhiteSpace(confirmar))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            // 2° Validar contraseña actual
            if (!logica.verificarContraseñaActual_L(actual))
            {
                MessageBox.Show("La contraseña actual es incorrecta.");
                return;
            }

            // 3° Verificar coincidencia
            if (nueva != confirmar)
            {
                MessageBox.Show("La nueva contraseña no coincide con la confirmación.");
                return;
            }

            // 4° Cambiar contraseña
            if (logica.cambiarContraseña_L(nueva))
            {
                MessageBox.Show("Contraseña actualizada correctamente.");
                txtContraseñaActual.Clear();
                txtContraseñaNueva.Clear();
                txtConfirmarContraseña.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la contraseña.");
            }
        }

        private void btnCambiarNomUsuario_Click(object sender, EventArgs e)
        {
            string nuevo = txtNombreUsuarioNuevo.Texts.Trim();
            string actualPass = txtContraseñaUsuario.Texts.Trim();

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(nuevo) || string.IsNullOrWhiteSpace(actualPass))
            {
                MessageBox.Show("Complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar contraseña actual
            if (!logica.verificarContraseñaActual_L(actualPass))
            {
                MessageBox.Show("La contraseña actual es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cambiar nombre de usuario
            if (logica.cambiarNombreUsuario_L(lblNombreUsuario.Text, nuevo))
            {
                MessageBox.Show("Nombre de usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreUsuarioNuevo.Clear();
                txtContraseñaUsuario.Clear();

                // Actualizar variable global si la usas en lblNombreUsuario
                ClsConfig_L.usuarioActivo = nuevo;
                lblNombreUsuario.Text = nuevo;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            string passActual = txtContraseñaEliminar.Texts.Trim();

            // Validar campo vacío
            if (string.IsNullOrEmpty(passActual))
            {
                MessageBox.Show("Debe ingresar su contraseña actual.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar contraseña actual
            if (!logica.verificarContraseñaActual_L(passActual))
            {
                MessageBox.Show("La contraseña ingresada es incorrecta.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar eliminación
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar su cuenta?\n" +
                "⚠ Esta acción no se puede deshacer.",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                // Ejecutar eliminación
                if (logica.eliminarCuenta_L(lblNombreUsuario.Text))
                {
                    MessageBox.Show("Su cuenta ha sido eliminada correctamente.",
                        "Cuenta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    CerrarMainYVolverAlLogin();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la cuenta.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CerrarMainYVolverAlLogin()
        {
            // Obtiene el formulario Main (el padre)
            FMain main = (FMain)this.TopLevelControl;

            // Muestra el login nuevamente
            FIniciarSesion fIniciarSesion = new FIniciarSesion();
            fIniciarSesion.Show();

            // Cierra el Main
            main.Close();
        }

    }
}
