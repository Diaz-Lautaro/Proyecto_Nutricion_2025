using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GustoSano.CDatos;

namespace GustoSano.CLogica
{
    internal class ClsGraficos_L
    {
        ClsGraficos_D datos = new ClsGraficos_D();

        public DataTable obtenerPacientesPorSexo_L()
        {
            return datos.obtenerPacientesPorSexo_D();
        }

        public DataTable obtenerTurnosPorMotivo_L()
        {
            return datos.obtenerTurnosPorMotivo_D();
        }

        public DataTable obtenerTurnosPorSemana_L(int mes)
        {
            return datos.obtenerTurnosPorSemana_D(mes);
        }

    }
}
