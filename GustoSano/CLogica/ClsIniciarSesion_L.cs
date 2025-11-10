using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CLogica
{
    internal class ClsIniciarSesion_L
    {
        ClsIniciarSesion_D datos = new ClsIniciarSesion_D();

        public string nombreUsuario { get; set; }
        public string contraseñaUsuario { get; set; }

        public bool IniciarSesion_L(ClsIniciarSesion_L logica)
        {
            return datos.IniciarSesion_D(logica);
        }
    }
}
