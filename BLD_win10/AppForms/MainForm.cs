using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLD_win10.AppForms
{
    public partial class MainForm : Form
    {
        
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HistogramForm histogramForm = new HistogramForm();
            histogramForm.MdiParent = this;
            histogramForm.Show();
            //histogramForm.WindowState = FormWindowState.Maximized;
        }

        private void ac6623TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AC6623TestForm AC6623TestForm = new AC6623TestForm();
            AC6623TestForm.MdiParent = this;
            AC6623TestForm.Show();
            //AC6623TestForm.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AccessAppSettings()
        {
            //获取Configuration对象
            //ConfigurationSettings config = ConfigurationSettings.
            //根据Key读取元素的Value
            //string name = config.AppSettings.Settings["name"].Value;
            ////写入元素的Value
            //config.AppSettings.Settings["name"].Value = "xieyc";
            ////增加元素
            //config.AppSettings.Settings.Add("url", "http://www.myhack58.com");
            ////删除元素
            //config.AppSettings.Settings.Remove("name");
            ////一定要记得保存，写不带参数的config.Save()也可以
            //config.Save(ConfigurationSaveMode.Modified);
            ////刷新，否则程序读取的还是之前的值（可能已装入内存）
            //System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }

        private void Settings()
        {

        }

        private void OtherTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherTestForm otherTestForm = new OtherTestForm();
            otherTestForm.MdiParent = this;
            otherTestForm.Show();
        }
    }
}
