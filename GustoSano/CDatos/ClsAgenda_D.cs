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
    internal class ClsAgenda_D
    {
        string cadenaDeConexion = "server= .; database= BD_NUTRICION; integrated security= true;";

        public void guardarTurno_D(ClsAgenda_L logica)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "INSERT INTO Agendas (nombrePaciente, motivo, fecha, hora)" +
                                    "VALUES (@NombrePaciente, @Motivo, @Fecha, @Hora)";

                conexion.Open();

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@NombrePaciente", logica.nombreYApellido);
                comando.Parameters.AddWithValue("@Motivo", logica.motivo);
                comando.Parameters.AddWithValue("@Fecha", logica.fecha);
                comando.Parameters.AddWithValue("@Hora", logica.hora);

                comando.ExecuteNonQuery();
            }
        }

        public void editarTurno_D(ClsAgenda_L logica)
        {
            string consulta = @"UPDATE Agendas SET 
                                nombrePaciente = @NombreYApellido,
                                motivo = @Motivo,
                                fecha = @Fecha,
                                hora = @Hora
                                WHERE idAgenda = @IdAgenda";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAgenda", logica.idAgenda);
                        comando.Parameters.AddWithValue("@NombreYApellido", logica.nombreYApellido);
                        comando.Parameters.AddWithValue("@Motivo", logica.motivo);
                        comando.Parameters.AddWithValue("@Fecha", logica.fecha);
                        comando.Parameters.AddWithValue("@Hora", logica.hora);

                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Turno modificado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar turno: " + ex.Message);
            }
        }

        public void eliminarTurno_D(int idTurno)
        {
            string consulta = "DELETE FROM Agendas WHERE idAgenda = @IdAgenda";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdAgenda", idTurno);
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Turno eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar turno: " + ex.Message);
            }
        }

        public DataTable mostrarTurnos_D()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "SELECT idAgenda, nombrePaciente, motivo, fecha, hora FROM Agendas";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(tabla);
            }

            return tabla;
        }


        public List<DateTime> obtenerFechasConTurnos_D()
        {
            List<DateTime> fechas = new List<DateTime>();

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "SELECT DISTINCT fecha FROM Agendas";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string fechaTexto = lector["fecha"].ToString();

                    // Intentamos convertir el varchar a DateTime
                    if (DateTime.TryParse(fechaTexto, out DateTime fechaConvertida))
                    {
                        fechas.Add(fechaConvertida);
                    }
                }
            }

            return fechas;
        }

        public DataTable buscarTurnoPorId_D(int idTurno)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = "SELECT idAgenda, nombrePaciente, motivo, fecha, hora FROM Agendas WHERE idAgenda= @IdAgenda";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdAgenda", idTurno);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }

            return tabla;
        }

    }
}
