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
    internal class ClsMenus_L
    {
        ClsMenus_D datos = new ClsMenus_D();

        public int idMenu { get; set; }
        public string nombreMenu { get; set; }
        public string descripcion { get; set; }
        public string tipoComida { get; set; }
        public string patologiaAsociada { get; set; }
        public string alergia { get; set; }
        public string objetivo { get; set; }


        public DataTable mostrarRecetas_L()
        {
            return datos.mostrarRecetas_D();
        }
        
        public DataTable mostrarMenus_L()
        {
            return datos.mostrarMenus_D();
        }

        public DataTable filtrarReceta_L(ClsMenus_L logica)
        {
            return datos.filtrarReceta_D(logica);
        }

        public void cargarMenu_L(DataGridView tabla, ClsMenus_L logica)
        {
            datos.cargarMenu_D(tabla, logica);
        }

        public int obtenerUltimoIdMenu()
        {
            return datos.obtenerUltimoIdMenu();
        }

        public void actualizarId()
        {
            datos.actualizarId();
        }
    }
}

