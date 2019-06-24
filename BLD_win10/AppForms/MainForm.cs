using BLD_win10.CaptureCardDriver;
using BLD_win10.Device;
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
using System.Xml.Linq;
using static BLD_win10.CaptureCardDriver.CaptureDriver;

namespace BLD_win10.AppForms
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DevicesDataCenter.InitializeDevicesData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"系统初始化错误, 请检查配置文件 Config.xml");
                this.Close();
            }
            try
            {
                DevicesDataCenter.StartGetCaptureDataThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"系统线程错误.");
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DevicesDataCenter.StopGetCaptureDataThread();
        }

        private void ac6623TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AC6623TestForm AC6623TestForm = new AC6623TestForm();
            AC6623TestForm.MdiParent = this;
            AC6623TestForm.Show();
            //AC6623TestForm.WindowState = FormWindowState.Maximized;
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

        /// <summary>
        /// 其它测试页面 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OtherTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherTestForm otherTestForm = new OtherTestForm();
            otherTestForm.MdiParent = this;
            otherTestForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DevicesDataCenter.StopGetCaptureDataThread();
        }

        /// <summary>
        /// 棒图按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HistogramForm histogramForm = new HistogramForm();
            histogramForm.MdiParent = this;
            histogramForm.Show();
            //histogramForm.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 历史曲线按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoricalGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricalGraphForm historicalGraphForm = new HistoricalGraphForm();
            historicalGraphForm.MdiParent = this;
            historicalGraphForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProbabilityOfLeakageToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// 测点位置图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObservationMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObservationMapForm observationMapForm = new ObservationMapForm();
            observationMapForm.MdiParent = this;
            observationMapForm.Show();
        }
    }
}
