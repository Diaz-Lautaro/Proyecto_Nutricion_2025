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
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        ClsGraficos_L logica = new ClsGraficos_L();

        private async void FGraficos_Load(object sender, EventArgs e)
        {
            cargarComboBox();

            await cargarGraficoPacientesPorSexoAsync();
            await cargarGraficoTurnosPorMotivoAsync();
            await cargarGraficoTurnosPorSemanaAsync(DateTime.Now.Month);
        }

        private async Task cargarGraficoPacientesPorSexoAsync()
        {
            // Consulta BD en hilo secundario
            DataTable tabla = await Task.Run(() => logica.obtenerPacientesPorSexo_L());

            // UI — solo se ejecuta en el hilo principal
            chGraficoSexos.Series.Clear();
            chGraficoSexos.ChartAreas.Clear();
            chGraficoSexos.Titles.Clear();

            chGraficoSexos.ChartAreas.Add(new ChartArea("AreaPrincipal"));
            var area = chGraficoSexos.ChartAreas["AreaPrincipal"];

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.MinorGrid.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;

            Series serie = new Series("Femenino");
            Series serie2 = new Series("Masculino");

            serie.ChartType = SeriesChartType.Column;
            serie.XValueMember = "Sexo";
            serie.YValueMembers = "Cantidad";
            serie.IsValueShownAsLabel = true;
            serie.Palette = ChartColorPalette.Pastel;

            chGraficoSexos.DataSource = tabla;
            chGraficoSexos.Series.Add(serie);
            chGraficoSexos.Series.Add(serie2);

            chGraficoSexos.DataBind();
        }

        private async Task cargarGraficoTurnosPorMotivoAsync()
        {
            // 🔹 1. Obtener los datos en un hilo secundario
            DataTable tabla = await Task.Run(() => logica.obtenerTurnosPorMotivo_L());

            // 🔹 2. Actualizar el gráfico en el hilo principal
            chGraficoMotivos.Series.Clear();
            chGraficoMotivos.ChartAreas.Clear();
            chGraficoMotivos.Titles.Clear();
            chGraficoMotivos.Legends.Clear();

            chGraficoMotivos.ChartAreas.Add(new ChartArea("AreaMotivos"));

            Series serie = new Series("Turnos por motivo");
            serie.ChartType = SeriesChartType.Doughnut;
            serie.XValueMember = "Motivo";
            serie.YValueMembers = "Cantidad";
            serie.IsValueShownAsLabel = true;

            chGraficoMotivos.DataSource = tabla;
            chGraficoMotivos.Series.Add(serie);

            // 👉 Leyenda personalizada
            Legend leyenda = new Legend("LeyendaMotivos");
            leyenda.Font = new Font("Segoe UI", 9);
            leyenda.Docking = Docking.Right;
            chGraficoMotivos.Legends.Add(leyenda);

            chGraficoMotivos.DataBind();

            chGraficoMotivos.ChartAreas[0].AxisX.Interval = 1;
        }

        private async Task cargarGraficoTurnosPorSemanaAsync(int mes)
        {
            // 🔹 1. Obtener datos de la BD en hilo secundario
            DataTable tabla = await Task.Run(() => logica.obtenerTurnosPorSemana_L(mes));

            // 🔹 2. Actualizar el gráfico en el hilo principal
            chGraficoTurnos.Series.Clear();
            chGraficoTurnos.ChartAreas.Clear();
            chGraficoTurnos.Titles.Clear();

            chGraficoTurnos.ChartAreas.Add(new ChartArea("AreaSemanas"));
            var area = chGraficoTurnos.ChartAreas["AreaSemanas"];

            // Quitar líneas del fondo
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.MinorGrid.Enabled = false;
            area.AxisY.MinorGrid.Enabled = false;

            Series serie = new Series("Turnos por semana");
            serie.ChartType = SeriesChartType.RangeColumn;
            serie.IsValueShownAsLabel = true;
            serie.Palette = ChartColorPalette.SeaGreen;

            chGraficoTurnos.Series.Add(serie);

            // 👉 Si NO hay datos
            if (tabla.Rows.Count == 0)
            {
                serie.Points.AddXY("Sin datos", 0);
                chGraficoTurnos.Titles.Add("Sin turnos registrados");
            }
            else
            {
                // 👉 Si hay datos
                foreach (DataRow fila in tabla.Rows)
                {
                    serie.Points.AddXY("Semana " + fila["Semana"], Convert.ToInt32(fila["Cantidad"]));
                }

                chGraficoTurnos.Titles.Add("Turnos por Semana - " + cmbMes.Text);
            }

            // Títulos de ejes
            area.AxisX.Title = "Semana del mes";
            area.AxisY.Title = "Cantidad de turnos";
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

        private async void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            await cargarGraficoTurnosPorSemanaAsync(cmbMes.SelectedIndex + 1);
        }

        private void chGraficoTurnos_Click(object sender, EventArgs e)
        {

        }
    }
}
