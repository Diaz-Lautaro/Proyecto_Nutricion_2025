using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CDatos
{
    internal class ClsReporte_D
    {
        string cadenaDeConexion = ClsConexionBD.cadenaDeConexion;
        DataTable tabla = new DataTable();

        public DataTable buscarHistoriaClinica_D(int idPaciente)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = @"SELECT peso, altura, diagnostico, alergias, patologias, medicamentos,
                                           tipoDietaActual, comidasDiarias, horarios, consumoAgua, objetivo, actividadFisica
                                    FROM HistoriaClinica
                                    WHERE idPaciente = @IdPaciente";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdPaciente", idPaciente);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        public DataTable buscarMenu_D(string nombreMenu)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = @"SELECT nombreMenu, tipoComida, descripcion
                         FROM Menus
                         WHERE nombreMenu = @NombreMenu";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@NombreMenu", nombreMenu);

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(tabla);
            }

            return tabla;
        }


        public DataTable buscarProximosTurnos_D(string nombrePaciente)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                string consulta = @"
                    SELECT fecha, hora, motivo
                    FROM Agendas
                    WHERE nombrePaciente = @NombrePaciente
                    AND CONVERT(date, fecha, 103) >= CONVERT(date, GETDATE())
                    ORDER BY CONVERT(date, fecha, 103) ASC";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@NombrePaciente", nombrePaciente);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}
