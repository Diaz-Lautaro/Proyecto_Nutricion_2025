using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CLogica
{
    internal class ClsBuscarMenu_L
    {
        ClsBuscarMenu_D datos = new ClsBuscarMenu_D();

        public DataTable mostrarMenu_L()
        {
            return datos.mostrarMenu_D();
        }

        public DataTable buscarMenu_L(string nombreMenu)
        {
            return datos.buscarMenuPorNombre_D(nombreMenu);
        }
    }
}
