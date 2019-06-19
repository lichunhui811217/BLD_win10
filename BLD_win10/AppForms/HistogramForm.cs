﻿using BLD_win10.Device;
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

namespace BLD_win10.AppForms
{
    public partial class HistogramForm : Form
    {
        public HistogramForm()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            histogramChart.Titles.Clear();
            histogramChart.Series.Clear();
            histogramChart.ChartAreas.Clear();

            foreach (Boiler aBoiler in DevicesDataCenter.boilersList)
            {
                int aBoilerID = aBoiler.BoilerID;
                string aBoilerCaption = aBoiler.Caption;

                string chartArea_Name = "ChartArea_" + aBoilerID.ToString();
                ChartArea chartArea = new ChartArea(chartArea_Name);
                chartArea.AxisX.MajorGrid.Enabled = false;
                chartArea.AxisX.MajorTickMark.Enabled = false;
                //chartArea.AxisX.Interval = 1;
                //chartArea.AxisX.IntervalOffset = 1;
                chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;


                histogramChart.ChartAreas.Add(chartArea);


                Title title = new Title();
                title.Name = "Title_" + aBoilerID.ToString();
                title.DockedToChartArea = chartArea_Name;
                title.IsDockedInsideChartArea = false;
                title.Text = aBoilerCaption;
                histogramChart.Titles.Add(title);

                Series series = new Series();
                series.Name= "Series_" + aBoilerID.ToString();
                series.ChartArea = chartArea_Name;
                series.Legend = histogramChart.Legends.First().Name;
                histogramChart.Series.Add(series);
            }
        }

        private void histogramChart_Click(object sender, EventArgs e)
        {
            foreach( Series aSeries in histogramChart.Series)
            {
                aSeries.Points.Clear();
            }

            foreach (Sensor aSensor in DevicesDataCenter.allSensorsList)
            {
                //数据点的填充
                DataPoint dataPoint = new DataPoint();
                dataPoint.XValue = aSensor.SensorID;
                double r = random.NextDouble() * 10.0;
                dataPoint.YValues = new double[] { r }; //取随机数填充Y值
                dataPoint.Color = aSensor.GetColor(r);
                Series series = histogramChart.Series.FindByName("Series_" + aSensor.BoilerID.ToString());
                series.Points.Add(dataPoint);

                //数据点 X坐标生成
                ChartArea chartArea = histogramChart.ChartAreas.FindByName("ChartArea_" + aSensor.BoilerID.ToString());
                CustomLabel customLabel = new CustomLabel
                {
                    FromPosition = aSensor.SensorID - 0.5,
                    ToPosition = aSensor.SensorID + 0.5,
                    Text = aSensor.SensorID.ToString()
                };
                chartArea.AxisX.CustomLabels.Add(customLabel);
            }
        }
    }
}
