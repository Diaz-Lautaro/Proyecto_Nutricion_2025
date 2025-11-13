using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CDatos
{
    internal class ClsGraficos_D
    {
        string cadenaDeConexion = ClsConexionBD.cadenaDeConexion;

        public DataTable obtenerPacientesPorSexo_D()
        {
            DataTable tabla = new DataTable();
            string consulta = @"SELECT sexoPaciente AS Sexo, COUNT(*) AS Cantidad
                                FROM DatosPacientes
                                GROUP BY sexoPaciente";

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos de pacientes por sexo: " + ex.Message);
                }
            }
            return tabla;
        }

        public DataTable obtenerTurnosPorMotivo_D()
        {
            DataTable tabla = new DataTable();
            string consulta = @"SELECT motivo AS Motivo, COUNT(*) AS Cantidad
                        FROM Agendas
                        GROUP BY motivo
                        ORDER BY COUNT(*) DESC";

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los turnos por motivo: " + ex.Message);
                }
            }
            return tabla;
        }

        public DataTable obtenerTurnosPorSemana_D(int mes)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                try
                {
                    string consulta = @"
                SELECT 
                    DATEPART(WEEK, TRY_CONVERT(date, fecha, 103)) AS Semana,
                    COUNT(*) AS Cantidad
                FROM Agendas
                WHERE 
                    TRY_CONVERT(date, fecha, 103) IS NOT NULL
                    AND DATEPART(MONTH, TRY_CONVERT(date, fecha, 103)) = @mes
                GROUP BY DATEPART(WEEK, TRY_CONVERT(date, fecha, 103))
                ORDER BY Semana";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@mes", mes);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los turnos por semana: " + ex.Message);
                }
            }
            return tabla;
        }


    }
}
