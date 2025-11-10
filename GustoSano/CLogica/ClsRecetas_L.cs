using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CLogica
{
    internal class ClsRecetas_L
    {
        ClsRecetas_D datos = new ClsRecetas_D();

        public int idReceta { get; set; }
        public string nombreReceta { get; set; }
        public string descripcion { get; set; }
        public int calorias { get; set; }
        public string tipoComida { get; set; }
        public string patologiaAsociada { get; set; }
        public string alergia { get; set; }
        public string objetivo { get; set; }

        public void agregarReceta_L(ClsRecetas_L logica)
        {
            datos.agregarReceta_D(logica);
        }

        public void modificarReceta_L(ClsRecetas_L logica)
        {
            datos.modificarReceta_D(logica);
        }
        public void eliminarReceta_L(int idReceta)
        {
            datos.eliminarReceta_D(idReceta);
        }
        public DataTable mostrarReceta_L()
        {
            return datos.mostrarRecetas_D();
        }

        public DataTable buscarReceta_L(string categoria, string patologia)
        {
            return datos.buscarReceta_D(categoria, patologia);
        }
    }
}
