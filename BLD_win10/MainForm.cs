using BLD_win10.ApplicationForm;
using System;
using System.Windows.Forms;

namespace BLD_win10
{
    public partial class MainForm : Form
    {
        HistogramForm histogramForm = new HistogramForm();
        AC6623TestForm AC6623TestForm = new AC6623TestForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            histogramForm.MdiParent = this;
            histogramForm.Show();
            //histogramForm.WindowState = FormWindowState.Maximized;
        }

        private void aC6623测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AC6623TestForm.MdiParent = this;
            AC6623TestForm.Show();
            //AC6623TestForm.WindowState = FormWindowState.Maximized;
        }

        private void WaveletTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
