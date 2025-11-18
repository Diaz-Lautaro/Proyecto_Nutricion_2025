using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GustoSano.CDatos
{
    internal class ClsBuscarMenu_D
    {
        private string cadenaConexion = ClsConexionBD.cadenaDeConexion;

        public DataTable mostrarMenu_D()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT nombreMenu, tipoComida, descripcion FROM Menus";

                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(comando);

                da.Fill(tabla);
            }

            return tabla;
        }


        public DataTable buscarMenuPorNombre_D(string nombre)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = @"SELECT nombreMenu, tipoComida, descripcion
                         FROM Menus
                         WHERE nombreMenu LIKE @Nombre + '%'";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Nombre", nombre);

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(tabla);
            }

            return tabla;
        }

    }
}
