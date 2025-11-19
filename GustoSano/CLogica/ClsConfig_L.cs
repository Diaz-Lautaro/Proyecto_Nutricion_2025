using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GustoSano.CLogica
{
    internal class ClsConfig_L
    {
        ClsConfig_D datos = new ClsConfig_D();

        public static string usuarioActivo { get; set; }

        public bool verificarContraseñaActual_L(string contraseñaActual)
        {
            return datos.verificarContraseñaActual_D(usuarioActivo, contraseñaActual);
        }

        public bool cambiarContraseña_L(string nuevaContraseña)
        {
            return datos.cambiarContraseña_D(usuarioActivo, nuevaContraseña);
        }

        public bool cambiarNombreUsuario_L(string usuarioActual, string nuevoNombre)
        {
            return datos.cambiarNombreUsuario_D(usuarioActual, nuevoNombre);
        }

        public bool eliminarCuenta_L(string usuario)
        {
            return datos.eliminarCuenta_D(usuario);
        }
    }
}
