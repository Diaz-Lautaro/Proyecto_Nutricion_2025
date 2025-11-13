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
        string cadenaDeConexion = ClsConexionBD.cadenaDeConexion;

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

        public DataTable mostrarMenus_D()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT  idMenu, nombreMenu, tipoComida, descripcion FROM Menus";

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

        public int obtenerUltimoIdMenu()
        {
            int ultimoId = 0;
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "SELECT MAX(contador) FROM ContadorMenus";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                ultimoId = (int)comando.ExecuteScalar();
            }
            return ultimoId;
        }

        public void cargarMenu_D(DataGridView tabla, ClsMenus_L logica)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                conexion.Open();

                using (SqlTransaction transaction = conexion.BeginTransaction())
                {
                    try
                    {
                        // Consulta SQL para insertar un menú
                        string query = "INSERT INTO Menus (idMenu, nombreMenu, tipoComida, descripcion) " +
                                       "VALUES (@Idmenu, @NombreMenu, @TipoComida, @Descripcion)";

                        using (SqlCommand comandoInsertar = new SqlCommand(query, conexion, transaction))
                        {
                            // Definimos los parámetros solo una vez
                            comandoInsertar.Parameters.Add("@IdMenu", SqlDbType.Int);
                            comandoInsertar.Parameters.Add("@NombreMenu", SqlDbType.NVarChar);
                            comandoInsertar.Parameters.Add("@TipoComida", SqlDbType.NVarChar);
                            comandoInsertar.Parameters.Add("@Descripcion", SqlDbType.NVarChar);

                            // Recorremos cada fila del DataGridView
                            foreach (DataGridViewRow fila in tabla.Rows)
                            {
                                // Evitamos la fila vacía del final
                                if (!fila.IsNewRow)
                                {
                                    // Validamos que las celdas no estén vacías
                                    if (fila.Cells["id"].Value != null &&
                                        fila.Cells["TipoComida"].Value != null &&
                                        fila.Cells["Descripcion"].Value != null)
                                    {
                                        // Asignamos los valores a los parámetros
                                        comandoInsertar.Parameters["@IdMenu"].Value = fila.Cells["id"].Value.ToString();
                                        comandoInsertar.Parameters["@NombreMenu"].Value = logica.nombreMenu;
                                        comandoInsertar.Parameters["@TipoComida"].Value = fila.Cells["TipoComida"].Value.ToString();
                                        comandoInsertar.Parameters["@Descripcion"].Value = fila.Cells["Descripcion"].Value.ToString();

                                        // Ejecutamos el INSERT
                                        comandoInsertar.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        // Si todo sale bien, confirmamos la transacción
                        transaction.Commit();
                        MessageBox.Show("✅ Los menús se insertaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Si ocurre un error, deshacemos todos los cambios
                        transaction.Rollback();
                        MessageBox.Show("❌ Error al insertar los menús: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void actualizarId()
        {
            using (SqlConnection connection = new SqlConnection(cadenaDeConexion))
            {
                connection.Open();

                string query = "INSERT INTO ContadorMenus DEFAULT VALUES";

                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }


    }
}
