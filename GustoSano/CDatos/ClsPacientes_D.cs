using GustoSano.CLogica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GustoSano.CDatos
{
    internal class ClsPacientes_D
    {
        string cadenaDeConexion = "server= .; database= BD_NUTRICION; integrated security= true;";

        public void agregarPaciente_D(ClsPacientes_L logica)
        {
            string añadirPaciente = "INSERT INTO DatosPacientes (nombrePaciente, apellidoPaciente, edadPaciente, sexoPaciente, fechaNacPaciente, telefonoPaciente) " +
                "VALUES (@nombrePaciente, @apellidoPaciente, @edadPaciente, @sexoPaciente, @fechaNacPaciente, @telefonoPaciente)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    // Insertamos el nuevo registro
                    using (SqlCommand comando = new SqlCommand(añadirPaciente, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombrePaciente", logica.nombrePaciente);
                        comando.Parameters.AddWithValue("apellidoPaciente", logica.apellidoPaciente);
                        comando.Parameters.AddWithValue("edadPaciente", logica.edadPaciente);
                        comando.Parameters.AddWithValue("sexoPaciente", logica.sexoPaciente);
                        comando.Parameters.AddWithValue("fechaNacPaciente", logica.fechaNacPaciente);
                        comando.Parameters.AddWithValue("telefonoPaciente", logica.telefonoPaciente);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Paciente cargado con exito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al cargar paciente: " + ex.Message);
            }
        }

        public void modificarPaciente_D(ClsPacientes_L logica)
        {
            string modificarPaciente = "UPDATE DatosPacientes SET " +
                "nombrePaciente = @nombrePaciente, " +
                "apellidoPaciente = @apellidoPaciente, " +
                "edadPaciente = @edadPaciente, " +
                "sexoPaciente = @sexoPaciente, " +
                "fechaNacPaciente = @fechaNacPaciente, " +
                "telefonoPaciente = @telefonoPaciente " +
                "WHERE idPaciente = @idPaciente";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(modificarPaciente, conexion))
                    {
                        comando.Parameters.AddWithValue("@idPaciente", logica.idPaciente);
                        comando.Parameters.AddWithValue("@nombrePaciente", logica.nombrePaciente);
                        comando.Parameters.AddWithValue("@apellidoPaciente", logica.apellidoPaciente);
                        comando.Parameters.AddWithValue("@edadPaciente", logica.edadPaciente);
                        comando.Parameters.AddWithValue("@sexoPaciente", logica.sexoPaciente);
                        comando.Parameters.AddWithValue("@fechaNacPaciente", logica.fechaNacPaciente);
                        comando.Parameters.AddWithValue("@telefonoPaciente", logica.telefonoPaciente);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Paciente modificado con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar paciente: " + ex.Message);
            }
        }

        public void eliminarPaciente_D(int idPaciente)
        {
            string eliminarPaciente = "DELETE FROM DatosPacientes WHERE idPaciente = @idPaciente";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(eliminarPaciente, conexion))
                    {
                        comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Paciente eliminado con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar paciente: " + ex.Message);
            }
        }

        public DataTable cargarPacientes_D()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "SELECT idPaciente, nombrePaciente, apellidoPaciente, edadPaciente, sexoPaciente, fechaNacPaciente, telefonoPaciente FROM DatosPacientes";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public DataTable buscarPacientePorID_D(int idPaciente)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM DatosPacientes WHERE idPaciente = @id_paciente";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_paciente", idPaciente);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar historia clínica: " + ex.Message);
            }

            return tabla;
        }
    }
}
