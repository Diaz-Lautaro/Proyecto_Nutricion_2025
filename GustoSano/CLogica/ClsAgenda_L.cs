using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CLogica
{
    internal class ClsAgenda_L
    {
        public int prueba2 { get; set; }


        public int idAgenda { get; set; }
        public string nombreYApellido { get; set; }
        public string motivo { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

        ClsAgenda_D datos = new ClsAgenda_D();

        public void guardarTurno_L(ClsAgenda_L logica)
        {
            datos.guardarTurno_D(logica);
        }
        public void editarTurno_L(ClsAgenda_L logica)
        {
            datos.editarTurno_D(logica);
        }

        public void eliminarTurno_L(int idTurno)
        {
            datos.eliminarTurno_D(idTurno);
        }

        public DataTable mostrarTurnos_L()
        {
            return datos.mostrarTurnos_D();
        }

        public DataTable buscarTurnoPorId_L(int idTurno)
        {
            return datos.buscarTurnoPorId_D(idTurno);
        }


        public List<DateTime> obtenerFechasConTurnos_L()
        {
            return datos.obtenerFechasConTurnos_D();
        }

    }
}
