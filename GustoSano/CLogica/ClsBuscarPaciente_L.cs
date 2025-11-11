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

        public DataTable mostrarPacientes_L()
        {
            return datos.mostrarPacientes_D();
        }
    }
}
