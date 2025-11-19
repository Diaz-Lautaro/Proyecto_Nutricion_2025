using GustoSano.CLogica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GustoSano.CDatos
{
    internal class ClsIniciarSesion_D
    {
        string cadenaDeConexion = ClsConexionBD.cadenaDeConexion;

        public bool IniciarSesion_D(ClsIniciarSesion_L logica)
        {
            string consulta = "SELECT nombreUsuario, contraseñaUsuario FROM GestionUsuarios WHERE nombreUsuario = @nombreUsuario COLLATE Latin1_General_CS_AS and contraseñaUsuario = @contraseñaUsuario";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using(SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("nombreUsuario", logica.nombreUsuario);
                        comando.Parameters.AddWithValue("contraseñaUsuario", logica.contraseñaUsuario);

                        using (SqlDataReader leer = comando.ExecuteReader())
                        {
                            if (leer.HasRows)
                            {
                                ClsConfig_L.usuarioActivo = logica.nombreUsuario;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro al iniciar sesión: " + ex.Message);
                return false;
            }
        }
    }
}
