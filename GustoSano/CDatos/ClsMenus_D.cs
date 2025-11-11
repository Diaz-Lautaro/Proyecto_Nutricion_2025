using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GustoSano.CLogica;
using System.Windows.Forms;
using System.Data;

namespace GustoSano.CDatos
{
    internal class ClsMenus_D
    {
        string cadenaDeConexion = "server= .; database= BD_NUTRICION; integrated security= true;";

        public DataTable mostrarRecetas_D()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT  tipoComida, descripcion FROM Recetas";

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable filtrarReceta_D(ClsMenus_L logica)
        {
            DataTable tabla = new DataTable();
            string consulta = @"SELECT tipoComida, descripcion FROM Recetas 
                     WHERE objetivo LIKE @Objetivo
                     AND patologiaAsociada LIKE @Patologia
                     AND alergia LIKE @Alergia
                     AND tipoComida LIKE @TipoComida";

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Objetivo", logica.objetivo + "%");
                        comando.Parameters.AddWithValue("@Patologia", logica.patologiaAsociada + "%");
                        comando.Parameters.AddWithValue("@Alergia", logica.alergia+ "%");
                        comando.Parameters.AddWithValue("@TipoComida", logica.tipoComida + "%");
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtar receta: " + ex.Message);
                }
            }
            return tabla;
        }
    }
}
