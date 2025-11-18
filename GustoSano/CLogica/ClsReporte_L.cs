using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GustoSano.CLogica
{
    internal class ClsReporte_L
    {

        ClsReporte_D datos = new ClsReporte_D();

        // CLINICA TERMINADO
        #region Sección Clinica
        // Propiedades de la Historia Clínica
        public string peso { get; set; }
        public string altura { get; set; }
        public string diagnostico { get; set; }
        public string alergias { get; set; }
        public string patologias { get; set; }
        public string medicamentos { get; set; }
        public string tipoDietaActual { get; set; }
        public string comidasDiarias { get; set; }
        public string horarios { get; set; }
        public string consumoAgua { get; set; }
        public string objetivo { get; set; }
        public string actividadFisica { get; set; }

        public void cargarHistoriaClinica_L(int idPaciente)
        {
            DataTable tabla = datos.buscarHistoriaClinica_D(idPaciente);

            DataRow fila = tabla.Rows[0];

            peso = fila["peso"].ToString();
            altura = (fila["altura"].ToString());
            diagnostico = fila["diagnostico"].ToString();
            alergias = fila["alergias"].ToString();
            patologias = fila["patologias"].ToString();
            medicamentos = fila["medicamentos"].ToString();
            tipoDietaActual = fila["tipoDietaActual"].ToString();
            comidasDiarias = fila["comidasDiarias"].ToString();
            horarios = fila["horarios"].ToString();
            consumoAgua = fila["consumoAgua"].ToString();
            objetivo = fila["objetivo"].ToString();
            actividadFisica = fila["actividadFisica"].ToString();
        }
        #endregion


        // MENÚ TERMINADO
        #region Sección Menús
        public class MenuItem
        {
            public string nombreMenu { get; set; }
            public string TipoComida { get; set; }
            public string Descripcion { get; set; }
        }

        public List<MenuItem> menuCompleto { get; set; } = new List<MenuItem>();

        public void cargarMenuCompleto_L(string nombreMenu)
        {
            DataTable tabla = datos.buscarMenu_D(nombreMenu);

            menuCompleto.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                menuCompleto.Add(new MenuItem
                {
                    nombreMenu = fila["nombreMenu"].ToString(),
                    TipoComida = fila["tipoComida"].ToString(),
                    Descripcion = fila["descripcion"].ToString(),
                });
            }
        }
        #endregion


        // TURNOS TERMINADO
        #region Sección Turnos

        public DataTable buscarProximosTurnos_L(string nombrePaciente)
        {
            return datos.buscarProximosTurnos_D(nombrePaciente);
        }

        public class TurnosItem
        {
            public string motivos { get; set; }
            public string fecha { get; set; }
            public string hora { get; set; }
        }

        public List<TurnosItem> turnosCompletos { get; set; } = new List<TurnosItem>();

        public void cargarTurnosCompletos_L(string nombrePaciente)
        {
            DataTable tabla = datos.buscarProximosTurnos_D(nombrePaciente);

            turnosCompletos.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                turnosCompletos.Add(new TurnosItem
                {
                    motivos = fila["motivo"].ToString(),
                    fecha = fila["fecha"].ToString(),
                    hora = fila["hora"].ToString()
                });
            }
        }

        #endregion
    }
}
