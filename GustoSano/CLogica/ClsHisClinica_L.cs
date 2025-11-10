using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GustoSano.CDatos;
using static GustoSano.CLogica.ClsHisClinica_L;

namespace GustoSano.CLogica
{
    internal class ClsHisClinica_L
    {
        ClsHisClinica_D datos = new ClsHisClinica_D();
        ClsPacientes_D datosPaciente = new ClsPacientes_D();

        // 🔹 Propiedades
        public int idPaciente { get; set; }
        public decimal peso { get; set; }
        public decimal altura { get; set; }
        public string diagnostico { get; set; }
        public string alergias { get; set; }
        public string patologias { get; set; }
        public string medicamentos { get; set; }
        public string tipoDietaActual { get; set; }
        public int comidasDiarias { get; set; }
        public string horarios { get; set; }
        public string consumoAgua { get; set; }
        public string objetivo { get; set; }
        public string actividadFisica { get; set; }

        // 🔹 Método público para agregar la historia clínica
        public void agregarHistoriaClinica_L(ClsHisClinica_L historia)
        {
            datos.agregarHistoriaClinica_D(historia);
        }

        public DataTable cargarPacientes_L()
        {
            return datosPaciente.cargarPacientes_D();
        }

        public DataTable mostrarHistoriasClinicas_L()
        {
            return datos.mostrarHistoriasClinicas_D();
        }

        public void modificarHistoriaClinica_L(ClsHisClinica_L logica)
        {
            datos.modificarHistoriaClinica_D(logica);
        }

        public DataTable BuscarHistoriaPorID_L(int idPaciente)
        {
            return datos.buscarHistoriaPorID_D(idPaciente);
        }
    }
}
