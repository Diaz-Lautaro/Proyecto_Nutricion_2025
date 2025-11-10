using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CLogica
{
    internal class ClsMenus_L
    {
        ClsMenus_D datos = new ClsMenus_D();

        public int IdMenu { get; set; }
        public string NombreMenu { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string PatologiaAsociada { get; set; }
        public string TipoComida { get; set; }

        public void agregarMenu_L(ClsMenus_L menu)
        {
            datos.agregarMenu_D(menu);
        }

        public DataTable mostrarMenus_L()
        {
            return datos.mostrarMenus_D();
        }

        public void eliminarMenu_L(int idMenu)
        {
            datos.eliminarMenu_D(idMenu);
        }
    }
}

