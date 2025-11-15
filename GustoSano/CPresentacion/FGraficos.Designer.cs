namespace GustoSano.CPresentacion
{
    partial class FGraficos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chGraficoSexos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chGraficoMotivos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chGraficoTurnos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chGraficoSexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGraficoMotivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGraficoTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de pacientes masculinos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de pacientes femeninos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motivos más frecuentes por consulta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turnos por mes";
            // 
            // chGraficoSexos
            // 
            chartArea1.Name = "ChartArea1";
            this.chGraficoSexos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGraficoSexos.Legends.Add(legend1);
            this.chGraficoSexos.Location = new System.Drawing.Point(353, 37);
            this.chGraficoSexos.Name = "chGraficoSexos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chGraficoSexos.Series.Add(series1);
            this.chGraficoSexos.Size = new System.Drawing.Size(418, 250);
            this.chGraficoSexos.TabIndex = 4;
            this.chGraficoSexos.Text = "chart1";
            // 
            // chGraficoMotivos
            // 
            chartArea2.Name = "ChartArea1";
            this.chGraficoMotivos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chGraficoMotivos.Legends.Add(legend2);
            this.chGraficoMotivos.Location = new System.Drawing.Point(36, 357);
            this.chGraficoMotivos.Name = "chGraficoMotivos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chGraficoMotivos.Series.Add(series2);
            this.chGraficoMotivos.Size = new System.Drawing.Size(418, 250);
            this.chGraficoMotivos.TabIndex = 5;
            this.chGraficoMotivos.Text = "chart1";
            // 
            // chGraficoTurnos
            // 
            chartArea3.Name = "ChartArea1";
            this.chGraficoTurnos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chGraficoTurnos.Legends.Add(legend3);
            this.chGraficoTurnos.Location = new System.Drawing.Point(534, 357);
            this.chGraficoTurnos.Name = "chGraficoTurnos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chGraficoTurnos.Series.Add(series3);
            this.chGraficoTurnos.Size = new System.Drawing.Size(418, 250);
            this.chGraficoTurnos.TabIndex = 6;
            this.chGraficoTurnos.Text = "chart1";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(734, 320);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(188, 24);
            this.cmbMes.TabIndex = 7;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // FGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 660);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.chGraficoTurnos);
            this.Controls.Add(this.chGraficoMotivos);
            this.Controls.Add(this.chGraficoSexos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGraficos";
            this.Text = "FGraficos";
            this.Load += new System.EventHandler(this.FGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chGraficoSexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGraficoMotivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGraficoTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGraficoSexos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGraficoMotivos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGraficoTurnos;
        private System.Windows.Forms.ComboBox cmbMes;
    }
}