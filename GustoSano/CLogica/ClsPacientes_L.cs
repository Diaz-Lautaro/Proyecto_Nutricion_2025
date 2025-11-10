using GustoSano.CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace GustoSano.CLogica
{
    internal class ClsPacientes_L
    {
        ClsPacientes_D datos = new ClsPacientes_D();

        public int idPaciente { get; set; }
        public string nombrePaciente { get; set; }
        public string apellidoPaciente { get; set; }
        public int edadPaciente { get; set; }
        public string sexoPaciente { get; set; }
        public string fechaNacPaciente { get; set; }
        public string telefonoPaciente { get; set; }


        public void agregarPaciente(ClsPacientes_L logica)
        {
            datos.agregarPaciente_D(logica);
        }

        public void modificarPaciente_L(ClsPacientes_L paciente)
        {
            datos.modificarPaciente_D(paciente);
        }

        public void eliminarPaciente_L(int idPaciente)
        {
            datos.eliminarPaciente_D(idPaciente);
        }

        public DataTable cargarPacientes_L()
        {
            return datos.cargarPacientes_D();
        }

        public DataTable buscarPacientePorID_L(int idPaciente)
        {
            return datos.buscarPacientePorID_D(idPaciente);
        }
    }
}
