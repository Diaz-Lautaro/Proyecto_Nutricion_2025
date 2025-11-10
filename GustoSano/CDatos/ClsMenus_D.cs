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

        /*public void agregarMenu_D(ClsMenus_L logica)
        {
            string query = @"INSERT INTO Menus (nombre_menu, descripcion, categoria, patologia_asociada)
                             VALUES (@nombre, @descripcion, @categoria, @patologia)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", logica.NombreMenu);
                        comando.Parameters.AddWithValue("@descripcion", logica.Descripcion);
                        comando.Parameters.AddWithValue("@categoria", logica.Categoria);
                        comando.Parameters.AddWithValue("@patologia", logica.PatologiaAsociada);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Menú agregado con éxito.");                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar menú: " + ex.Message);
            }
        }

        public DataTable mostrarMenus_D()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Menus";

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                conexion.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.Fill(tabla);
            }

            return tabla;
        }

        public void eliminarMenu_D(int idMenu)
        {
            string query = "DELETE FROM Menus WHERE id_menu = @id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idMenu);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Menú eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar menú: " + ex.Message);
            }
        }*/



        public DataTable mostrarRecetas_D()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT idReceta, tipoComida, descripcion FROM Recetas";

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
