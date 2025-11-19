using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CDatos
{
    internal class ClsConfig_D
    {
        string cadenaDeConexion = ClsConexionBD.cadenaDeConexion;

        public bool verificarContraseñaActual_D(string nombreUsuario, string contraseñaActual)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = @"SELECT COUNT(*) 
                            FROM GestionUsuarios 
                            WHERE nombreUsuario = @Usuario 
                            AND contraseñaUsuario = @PassActual";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Usuario", nombreUsuario);
                comando.Parameters.AddWithValue("@PassActual", contraseñaActual);

                conexion.Open();

                int resultado = (int)comando.ExecuteScalar();
                return resultado > 0;
            }
        }

        public bool cambiarContraseña_D(string nombreUsuario, string nuevaContraseña)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = @"UPDATE GestionUsuarios 
                            SET contraseñaUsuario = @NuevaPass 
                            WHERE nombreUsuario = @Usuario";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@NuevaPass", nuevaContraseña);
                comando.Parameters.AddWithValue("@Usuario", nombreUsuario);

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public bool cambiarNombreUsuario_D(string usuarioActual, string nuevoNombre)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = @"UPDATE GestionUsuarios 
                                SET nombreUsuario = @NuevoNombre
                                WHERE nombreUsuario = @UsuarioActual";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                comando.Parameters.AddWithValue("@UsuarioActual", usuarioActual);

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public bool eliminarCuenta_D(string usuario)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = @"DELETE FROM GestionUsuarios
                                WHERE nombreUsuario = @Usuario";

                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                conexion.Open();
                int filas = cmd.ExecuteNonQuery();

                return filas > 0;
            }
        }
    }
}
