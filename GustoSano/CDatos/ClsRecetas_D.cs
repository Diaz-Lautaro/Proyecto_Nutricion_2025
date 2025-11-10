using GustoSano.CLogica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GustoSano.CDatos
{
    internal class ClsRecetas_D
    {
        string cadenaDeConexion = "server= .; database= BD_NUTRICION; integrated security= true;";

        public DataTable mostrarRecetas_D()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "SELECT * FROM Recetas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
        }

        public DataTable mostrarRecetasFMenu_D()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "SELECT idReceta, tipoComida, descripcion FROM Recetas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
        }

        public void agregarReceta_D(ClsRecetas_L logica)
        {
            string insertarReceta = @"INSERT INTO Recetas 
                                  (nombreReceta, descripcion, calorias, tipoComida, patologiaAsociada, alergia, objetivo)
                                  VALUES 
                                  (@NombreReceta, @Descripcion, @Calorias, @TipoComida, @PatologiaAsociada, @Alergia, @Objetivo)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(insertarReceta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NombreReceta", logica.nombreReceta);
                        comando.Parameters.AddWithValue("@Descripcion", logica.descripcion);
                        comando.Parameters.AddWithValue("@Calorias", logica.calorias);
                        comando.Parameters.AddWithValue("@tipoComida", logica.tipoComida);
                        comando.Parameters.AddWithValue("@PatologiaAsociada", logica.patologiaAsociada);
                        comando.Parameters.AddWithValue("@Alergia", logica.alergia);
                        comando.Parameters.AddWithValue("@Objetivo", logica.objetivo);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Receta agregada con éxito!", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar receta: " + ex.Message);
            }
        }

        public void modificarReceta_D(ClsRecetas_L logica)
        {
            string modificarReceta = "UPDATE Recetas SET " +
                "nombreReceta = @NombreReceta, " +
                "descripcion = @Descripcion, " +
                "calorias = @Calorias, " +
                "tipoComida= @TipoComida, " +
                "patologiaAsociada = @PatologiaAsociada, " +
                "alergia = @Alergia," +
                "objetivo= @Objetivo " +
                "WHERE idReceta = @IdReceta";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(modificarReceta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdReceta", logica.idReceta);
                        comando.Parameters.AddWithValue("@NombreReceta", logica.nombreReceta);
                        comando.Parameters.AddWithValue("@Descripcion", logica.descripcion);
                        comando.Parameters.AddWithValue("@Calorias", logica.calorias);
                        comando.Parameters.AddWithValue("@TipoComida", logica.tipoComida);
                        comando.Parameters.AddWithValue("@PatologiaAsociada", logica.patologiaAsociada);
                        comando.Parameters.AddWithValue("@Alergia", logica.alergia);
                        comando.Parameters.AddWithValue("@Objetivo", logica.objetivo);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Receta modificada con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar receta: " + ex.Message);
            }
        }

        public void eliminarReceta_D(int idReceta)
        {
            string eliminarReceta = "DELETE FROM Recetas WHERE idReceta = @IdReceta";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(eliminarReceta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdReceta", idReceta);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Receta eliminada con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar receta: " + ex.Message);
            }
        }

        public DataTable buscarReceta_D(int IdReceta)
        {
            DataTable tabla = new DataTable();
            string consulta = @"SELECT * FROM Recetas 
                     WHERE idReceta = @IdReceta";

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdReceta", IdReceta);
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar por categoría: " + ex.Message);
                }
            }
            return tabla;
        }
    }
}