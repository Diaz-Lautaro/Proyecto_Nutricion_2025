using GustoSano.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GustoSano.CPresentacion
{
    public partial class FGraficos : Form
    {
        public FGraficos()
        {
            InitializeComponent();
        }

        ClsGraficos_L logica = new ClsGraficos_L();

        private void FGraficos_Load(object sender, EventArgs e)
        {
            cargarComboBox();

            cargarGraficoPacientesPorSexo();
            cargarGraficoTurnosPorMotivo();
            cargarGraficoTurnosPorSemana(DateTime.Now.Month);
        }

        private void cargarGraficoPacientesPorSexo()
        {
            DataTable tabla = logica.obtenerPacientesPorSexo_L();

            chGraficoSexos.Series.Clear();
            chGraficoSexos.ChartAreas.Clear();
            chGraficoSexos.Titles.Clear();

            chGraficoSexos.ChartAreas.Add(new ChartArea("AreaPrincipal"));

            Series serie = new Series("Pacientes por sexo");
            serie.ChartType = SeriesChartType.Pie; 
            serie.XValueMember = "Sexo";
            serie.YValueMembers = "Cantidad";
            serie.IsValueShownAsLabel = true;

            chGraficoSexos.DataSource = tabla;
            chGraficoSexos.Series.Add(serie);
            chGraficoSexos.Titles.Add("Distribución de pacientes por sexo");
            chGraficoSexos.DataBind();

            serie.Points[0].Color = Color.SteelBlue;   // Masculino
            serie.Points[1].Color = Color.LightPink;   // Femenino
        }

        private void cargarGraficoTurnosPorMotivo()
        {
            DataTable tabla = logica.obtenerTurnosPorMotivo_L();

            chGraficoMotivos.Series.Clear();
            chGraficoMotivos.ChartAreas.Clear();
            chGraficoMotivos.Titles.Clear();

            chGraficoMotivos.ChartAreas.Add(new ChartArea("AreaMotivos"));

            Series serie = new Series("Turnos por motivo");
            serie.ChartType = SeriesChartType.Doughnut;
            serie.XValueMember = "Motivo";
            serie.YValueMembers = "Cantidad";
            serie.IsValueShownAsLabel = true;

            chGraficoMotivos.DataSource = tabla;
            chGraficoMotivos.Series.Add(serie);
            chGraficoMotivos.Titles.Add("Motivos más frecuentes de consulta");
            chGraficoMotivos.DataBind();

            // Opcional: mejorar visibilidad
            chGraficoMotivos.ChartAreas[0].AxisX.Interval = 1;
            chGraficoMotivos.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }

        private void cargarGraficoTurnosPorSemana(int mes)
        {
            DataTable tabla = logica.obtenerTurnosPorSemana_L(mes);

            chGraficoTurnos.Series.Clear();
            chGraficoTurnos.ChartAreas.Clear();
            chGraficoTurnos.Titles.Clear();

            chGraficoTurnos.ChartAreas.Add(new ChartArea("AreaSemanas"));

            Series serie = new Series("Turnos por semana");
            serie.ChartType = SeriesChartType.RangeColumn; 
            serie.XValueMember = "Semana";
            serie.YValueMembers = "Cantidad";
            serie.IsValueShownAsLabel = true;

            chGraficoTurnos.DataSource = tabla;
            chGraficoTurnos.Series.Add(serie);
            chGraficoTurnos.Titles.Add("Cantidad de turnos por semana");
            chGraficoTurnos.DataBind();

            chGraficoTurnos.ChartAreas[0].AxisX.Title = "Semana del mes";
            chGraficoTurnos.ChartAreas[0].AxisY.Title = "Cantidad de turnos";
        }


        private void cargarComboBox()
        {
            cmbMes.Items.AddRange(new string[]
            {                
                "Enero",
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre"
            });

            cmbMes.SelectedIndex = Convert.ToInt32(DateTime.Now.Month - 1);
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex == -1)
                return;

            int mesSeleccionado = cmbMes.SelectedIndex + 1;

            DataTable datos = logica.obtenerTurnosPorSemana_L(mesSeleccionado);

            chGraficoTurnos.Series.Clear();
            chGraficoTurnos.Titles.Clear();

            chGraficoTurnos.Series.Add("Turnos por Semana");
            chGraficoTurnos.Series["Turnos por Semana"].ChartType = SeriesChartType.RangeColumn;
            chGraficoTurnos.Series["Turnos por Semana"].IsValueShownAsLabel = true;

            if (datos.Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    chGraficoTurnos.Series["Turnos por Semana"].Points.AddXY(
                        "Semana " + fila["Semana"].ToString(),
                        Convert.ToInt32(fila["Cantidad"])
                    );
                }

                chGraficoTurnos.Titles.Add("Turnos por Semana - " + cmbMes.Text);
            }
            else
            {
                chGraficoTurnos.Series["Turnos por Semana"].Points.AddXY("Sin datos", 0);
                chGraficoTurnos.Titles.Add("Sin turnos registrados en " + cmbMes.Text);
            }
            chGraficoTurnos.ChartAreas[0].AxisX.Title = "Semanas";
            chGraficoTurnos.ChartAreas[0].AxisY.Title = "Cantidad de turnos";
        }

    }
}
