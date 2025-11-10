using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GustoSano.CLogica.ClsHisClinica_L;
using System.Windows.Forms;
using GustoSano.CLogica;
using System.Data;

namespace GustoSano.CDatos
{
    internal class ClsHisClinica_D
    {

        string cadenaDeConexion = "server= .; database= BD_NUTRICION; integrated security= true;";

        public void agregarHistoriaClinica_D(ClsHisClinica_L logica)
        {
              string query = @"INSERT INTO HistoriaClinica 
                            (idPaciente, peso, altura, diagnostico, alergias, patologias, medicamentos, 
                             tipoDietaActual, comidasDiarias, horarios, consumoAgua, objetivo, actividadFisica)
                             VALUES 
                            (@id_paciente, @peso, @altura, @diagnostico, @alergias, @patologias, @medicamentos, 
                             @tipo_dieta_actual, @comidas_diarias, @horarios, @consumo_agua, @objetivo, @actividad_fisica)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_paciente", logica.idPaciente);
                        comando.Parameters.AddWithValue("@peso", logica.peso);
                        comando.Parameters.AddWithValue("@altura", logica.altura);
                        comando.Parameters.AddWithValue("@diagnostico", logica.diagnostico);
                        comando.Parameters.AddWithValue("@alergias", logica.alergias);
                        comando.Parameters.AddWithValue("@patologias", logica.patologias);
                        comando.Parameters.AddWithValue("@medicamentos", logica.medicamentos);
                        comando.Parameters.AddWithValue("@tipo_dieta_actual", logica.tipoDietaActual);
                        comando.Parameters.AddWithValue("@comidas_diarias", logica.comidasDiarias);
                        comando.Parameters.AddWithValue("@horarios", logica.horarios);
                        comando.Parameters.AddWithValue("@consumo_agua", logica.consumoAgua);
                        comando.Parameters.AddWithValue("@objetivo", logica.objetivo);
                        comando.Parameters.AddWithValue("@actividad_fisica", logica.actividadFisica);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Historia clínica registrada correctamente.", "Éxito",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar historia clínica: " + ex.Message);
            }
        }

        public DataTable mostrarHistoriasClinicas_D()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string query = @"SELECT 
                                    idHistoria,
                                    idPaciente,
                                    peso,
                                    altura,
                                    diagnostico,
                                    alergias,
                                    patologias,
                                    medicamentos,
                                    tipoDietaActual,
                                    comidasDiarias,
                                    horarios,
                                    consumoAgua,
                                    objetivo,
                                    actividadFisica
                                 FROM HistoriaClinica";

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        public void modificarHistoriaClinica_D(ClsHisClinica_L logica)
        {
            string query = @"UPDATE HistoriaClinica 
                     SET peso = @peso,
                         altura = @altura,
                         diagnostico = @diagnostico,
                         alergias = @alergias,
                         patologias = @patologias,
                         medicamentos = @medicamentos,
                         tipoDietaActual = @tipo_dieta_actual,
                         comidasDiarias = @comidas_diarias,
                         horarios = @horarios,
                         consumoAgua = @consumo_agua,
                         objetivo = @objetivo,
                         actividadFisica = @actividad_fisica
                     WHERE idPaciente = @id_paciente";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id_paciente", logica.idPaciente);
                        comando.Parameters.AddWithValue("@peso", logica.peso);
                        comando.Parameters.AddWithValue("@altura", logica.altura);
                        comando.Parameters.AddWithValue("@diagnostico", logica.diagnostico);
                        comando.Parameters.AddWithValue("@alergias", logica.alergias);
                        comando.Parameters.AddWithValue("@patologias", logica.patologias);
                        comando.Parameters.AddWithValue("@medicamentos", logica.medicamentos);
                        comando.Parameters.AddWithValue("@tipo_dieta_actual", logica.tipoDietaActual);
                        comando.Parameters.AddWithValue("@comidas_diarias", logica.comidasDiarias);
                        comando.Parameters.AddWithValue("@horarios", logica.horarios);
                        comando.Parameters.AddWithValue("@consumo_agua", logica.consumoAgua);
                        comando.Parameters.AddWithValue("@objetivo", logica.objetivo);
                        comando.Parameters.AddWithValue("@actividad_fisica", logica.actividadFisica);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Historia clínica actualizada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la historia clínica: " + ex.Message);
            }
        }

        public DataTable buscarHistoriaPorID_D(int idPaciente)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM HistoriaClinica WHERE idPaciente = @id_paciente";

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

