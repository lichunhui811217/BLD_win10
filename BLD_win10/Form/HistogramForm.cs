using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLD_win10
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
           
            for (int i = 1; i <= 30; i++)
            {
                histogramChart.Series[0].Points.AddXY(i, random.NextDouble());
                histogramChart.Series[1].Points.AddXY(i, random.NextDouble());
            }
        }

        private void histogramChart_Click(object sender, EventArgs e)
        {
            histogramChart.Series[0].Points.Clear();
            histogramChart.Series[1].Points.Clear();
            for (int i = 1; i <= 30; i++)
            {
                histogramChart.Series[0].Points.AddXY(i, random.NextDouble());
                histogramChart.Series[1].Points.AddXY(i, random.NextDouble());
            }

            //AC6623TestForm.AC6623_AD(new IntPtr(), 0, 0, 0);
        }
    }
}
