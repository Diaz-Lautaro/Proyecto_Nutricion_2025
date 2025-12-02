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
    internal class ClsBuscarPaciente_D
    {
        string cadenaDeConexion = ClsConexionBD.cadenaDeConexion;

        public DataTable mostrarPacientesMenus_D()
        {
            DataTable tabla = new DataTable();

                    //dp.idPaciente AS ID,
            string consulta = @"
                SELECT 
                    dp.nombrePaciente AS Nombre,
                    dp.apellidoPaciente AS Apellido,
                    hc.objetivo AS Objetivo,
                    hc.patologias AS Patologia,
                    hc.alergias AS Alergia
                FROM DatosPacientes dp
                INNER JOIN HistoriaClinica hc ON dp.idPaciente = hc.idPaciente";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

        public DataTable buscarPacienteMenu_D(string nombre)
        {
            DataTable tabla = new DataTable();

            string consulta = @"
                    SELECT 
                        dp.nombrePaciente AS Nombre,
                        dp.apellidoPaciente AS Apellido,
                        hc.objetivo AS Objetivo,
                        hc.patologias AS Patologia,
                        hc.alergias AS Alergia
                    FROM DatosPacientes dp
                    INNER JOIN HistoriaClinica hc ON dp.idPaciente = hc.idPaciente
                    WHERE dp.nombrePaciente LIKE @nombre + '%'";   // ← filtra por inicio del nombre

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar paciente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }





        public DataTable mostrarPacientesAgenda_D()
        {
            DataTable tabla = new DataTable();

            string consulta = "SELECT nombrePaciente ,apellidoPaciente FROM DatosPacientes";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

        public DataTable buscarPacientesAgenda_D(string nombre)
        {
            DataTable tabla = new DataTable();

            string consulta = @"
                    SELECT 
                        nombrePaciente,
                        apellidoPaciente
                    FROM DatosPacientes
                    WHERE nombrePaciente LIKE @nombre + '%'";
                        // También se puede usar '%' + @nombre + '%' si querés búsqueda más flexible

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pacientes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }





        public DataTable mostrarPacientesReportes_D()
        {
            DataTable tabla = new DataTable();

            string consulta = @"
                      SELECT 
                          dp.idPaciente,
                          dp.nombrePaciente,
                          dp.apellidoPaciente
                      FROM DatosPacientes dp
                      INNER JOIN HistoriaClinica hc ON dp.idPaciente = hc.idPaciente
                      ORDER BY dp.idPaciente ASC";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

        public DataTable buscarPacientesReportes_D(string nombre)
        {
            DataTable tabla = new DataTable();

            string consulta = @"
                     SELECT 
                         dp.idPaciente,
                         dp.nombrePaciente,
                         dp.apellidoPaciente
                     FROM DatosPacientes dp
                     INNER JOIN HistoriaClinica hc ON dp.idPaciente = hc.idPaciente
                     WHERE dp.nombrePaciente LIKE @nombre + '%'
                     ORDER BY dp.idPaciente ASC";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);

                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        da.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pacientes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabla;
        }

    }
}
