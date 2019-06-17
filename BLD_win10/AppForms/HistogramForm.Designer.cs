namespace BLD_win10.AppForms
{
    partial class HistogramForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistogramForm));
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem4 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem5 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.histogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramChart
            // 
            this.histogramChart.BorderlineColor = System.Drawing.SystemColors.MenuHighlight;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.Name = "ChartArea1";
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.Name = "ChartArea2";
            this.histogramChart.ChartAreas.Add(chartArea1);
            this.histogramChart.ChartAreas.Add(chartArea2);
            resources.ApplyResources(this.histogramChart, "histogramChart");
            legendItem1.Name = "LegendItem1";
            legend1.CustomItems.Add(legendItem1);
            legend1.Enabled = false;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            legendItem2.Color = System.Drawing.Color.Red;
            legendItem2.Name = "报警";
            legendItem3.Color = System.Drawing.Color.Lime;
            legendItem3.Name = "正常";
            legendItem4.Color = System.Drawing.Color.Orange;
            legendItem4.Name = "超上限";
            legendItem5.Color = System.Drawing.Color.DodgerBlue;
            legendItem5.Name = "吹灰";
            legend2.CustomItems.Add(legendItem2);
            legend2.CustomItems.Add(legendItem3);
            legend2.CustomItems.Add(legendItem4);
            legend2.CustomItems.Add(legendItem5);
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend2";
            this.histogramChart.Legends.Add(legend1);
            this.histogramChart.Legends.Add(legend2);
            this.histogramChart.Name = "histogramChart";
            this.histogramChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.histogramChart.Series.Add(series1);
            this.histogramChart.Series.Add(series2);
            title1.DockedToChartArea = "ChartArea1";
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "图表1";
            title2.DockedToChartArea = "ChartArea2";
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "棒图2";
            this.histogramChart.Titles.Add(title1);
            this.histogramChart.Titles.Add(title2);
            this.histogramChart.Click += new System.EventHandler(this.histogramChart_Click);
            // 
            // HistogramForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.histogramChart);
            this.Name = "HistogramForm";
            this.Load += new System.EventHandler(this.HistogramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart histogramChart;
    }
}