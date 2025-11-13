using GustoSano.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GustoSano.CDatos
{
    internal class ClsCrearCuenta_D
    {

        string cadenaDeConexion = ClsConexionBD.cadenaDeConexion;

        public void CrearCuenta_D(ClsCrearCuenta_L logica)
        {
            string consultarNombreUsuario = "SELECT nombreUsuario FROM GestionUsuarios WHERE nombreUsuario = @nombre_usuario COLLATE Latin1_General_CS_AS";
            string consultarCorreoUsuario = "SELECT gmailUsuario FROM GestionUsuarios WHERE gmailUsuario = @gmail_usuario";
            string añadirUsuario = "INSERT INTO GestionUsuarios (nombreUsuario, gmailUsuario, contraseñaUsuario) " +
                "VALUES (@nombre_usuario, @gmail_usuario, @contraseña_usuario)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    // Verificamos si ya existe el usuario
                    using (SqlCommand comando = new SqlCommand(consultarNombreUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre_usuario", logica.nombreUsuario);

                        using (SqlDataReader buscarNombreUsuario = comando.ExecuteReader())
                        {
                            if (buscarNombreUsuario.HasRows)
                            {
                                MessageBox.Show("Nombre de usuario existente");
                                return;
                            }
                        }
                    }

                    // Verificamos si ya existe el correo
                    using(SqlCommand comando = new SqlCommand(consultarCorreoUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@gmail_usuario", logica.gmailUsuario);

                        using(SqlDataReader buscarGmailUsuario = comando.ExecuteReader())
                        {
                            if (buscarGmailUsuario.HasRows)
                            {
                                MessageBox.Show("El gmail ya existe");
                                return;
                            }
                        }
                    }

                    // Insertamos el nuevo registro
                    using(SqlCommand comando = new SqlCommand(añadirUsuario, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre_usuario", logica.nombreUsuario);
                        comando.Parameters.AddWithValue("@gmail_usuario", logica.gmailUsuario);
                        comando.Parameters.AddWithValue("@contraseña_usuario", logica.contraseñaUsuario);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cuenta creada con exito!");
                    logica.banderaCuentaCreada = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al crear la cuenta: " + ex.Message);
            }
        }
    }
}
