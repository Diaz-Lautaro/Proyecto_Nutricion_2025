using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GustoSano.CLogica
{
    internal class ClsBuscarPaciente_L
    {
        ClsBuscarPaciente_D datos = new ClsBuscarPaciente_D();
        public string nombrePaciente { get; set; }


        public DataTable mostrarPacientesMenus_L()
        {
            return datos.mostrarPacientesMenus_D();
        }

        public DataTable buscarPacienteMenus_L(string nombrePaciente)
        {
            return datos.buscarPacienteMenu_D(nombrePaciente);
        }



        public DataTable mostrarPacientesAgenda_L()
        {
            return datos.mostrarPacientesAgenda_D();
        }

        public DataTable buscarPacienteAgenda_L(string nombrePaciente)
        {
            return datos.buscarPacientesAgenda_D(nombrePaciente);
        }



        public DataTable mostrarPacientesReportes_L()
        {
            return datos.mostrarPacientesReportes_D();
        }

        public DataTable buscarPacienteReportes_L(string nombrePaciente)
        {
            return datos.buscarPacientesReportes_D(nombrePaciente);
        }
    }
}
