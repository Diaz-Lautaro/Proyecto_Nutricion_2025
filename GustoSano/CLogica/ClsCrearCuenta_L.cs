using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CLogica
{
    internal class ClsCrearCuenta_L
    {
        ClsCrearCuenta_D datos = new ClsCrearCuenta_D();

        public string nombreUsuario { get; set; }
        public string contraseñaUsuario { get; set; }
        public string gmailUsuario { get; set; }
        public int banderaCuentaCreada { get; set; }

        public void CrearCuenta_L(ClsCrearCuenta_L loginL)
        {
            datos.CrearCuenta_D(loginL);
        }
    }
}
