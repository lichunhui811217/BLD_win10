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
    }
}
