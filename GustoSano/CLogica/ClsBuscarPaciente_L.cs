using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CLogica
{
    internal class ClsBuscarPaciente_L
    {
        ClsBuscarPaciente_D datos = new ClsBuscarPaciente_D();

        public DataTable mostrarPacientesMenus_L()
        {
            return datos.mostrarPacientesMenus_D();
        }

        public DataTable mostrarPacientesAgenda_L()
        {
            return datos.mostrarPacientesAgenda_D();
        }

        public DataTable mostrarPacientesReportes_L()
        {
            return datos.mostrarPacientesReportes_D();
        }
    }
}
