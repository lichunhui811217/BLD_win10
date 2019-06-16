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
        public List<Boiler> boilersList = new List<Boiler>();
        public List<CaptureCard> captureCardsList = new List<CaptureCard>();
        public List<Sensor> allSensorsList = new List<Sensor>();

        public MainForm()
        {
            InitializeComponent();

            XDocument configXml = XDocument.Load(@".\Config.xml");
            XElement PowerPlantElement = configXml.Root;
            XElement ServerElement = PowerPlantElement.Element("Server");

            //锅炉类 list 初始化
            XElement BoilersElement = ServerElement.Element("Boilers");
            IEnumerable<XElement> BoilerElements = BoilersElement.Elements("Boiler");
            foreach (XElement aBoilderXElement in BoilerElements)
            {
                boilersList.Add(new Boiler(Convert.ToInt32(aBoilderXElement.Attribute("BoilerID").Value), aBoilderXElement.Attribute("Caption").Value));
            }

            //板卡类 list 初始化
            XElement CaptureCardsElement = ServerElement.Element("CaptureCards");
            IEnumerable<XElement> CaptureCardElements = CaptureCardsElement.Elements("CaptureCard");
            foreach (XElement aCaptureCardXElement in CaptureCardElements)
            {
                CaptureCard aCaptureCard = new CaptureCard(Convert.ToInt32(aCaptureCardXElement.Attribute("CaptureCardID").Value), aCaptureCardXElement.Attribute("Driver").Value);
                

                IEnumerable<XElement> sensorElements = aCaptureCardXElement.Elements("Sensor");
                foreach (XElement aSensorElement in sensorElements)
                {
                    //SensorID = "1" ChannelNumber = "1" BoilerID = "1" Multiplicative = "24" BaseNoise = "0" Uplimit = "2.2" Downlimit = "0.5" FFT = "0"
                    //int SensorID, CaptureCard CaptureCard, int ChannelNumber, int BoilerID, int Multiplicative,
                    //double BaseNoise, double Uplimit, double Downlimit, int FFT, Boiler Boiler
                    int sensorID = Convert.ToInt32(aSensorElement.Attribute("SensorID").Value);
                    int channelNumber = Convert.ToInt32(aSensorElement.Attribute("ChannelNumber").Value);
                    int boilerID = Convert.ToInt32(aSensorElement.Attribute("BoilerID").Value);
                    int multiplicative = Convert.ToInt32(aSensorElement.Attribute("Multiplicative").Value);
                    double baseNoise = Convert.ToDouble(aSensorElement.Attribute("BaseNoise").Value);
                    double uplimit = Convert.ToDouble(aSensorElement.Attribute("Uplimit").Value);
                    double downlimit = Convert.ToDouble(aSensorElement.Attribute("Downlimit").Value);
                    int fft = Convert.ToInt32(aSensorElement.Attribute("FFT").Value);
                    Boiler boiler = boilersList.Find(x => x.BoilerID == boilerID);

                    Sensor aSensor = new Sensor(sensorID, aCaptureCard, channelNumber, boilerID, multiplicative, baseNoise, uplimit, downlimit, fft, boiler);
                    
                    allSensorsList.Add(aSensor);
                }
                captureCardsList.Add(aCaptureCard);
            }
            //allSensorsList[0].CaptureCard.CaptureCardID = 2;    //对象引用, 属性更新成功
            //allSensorsList[1].Boiler.BoilerID = 2;
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

        private void OtherTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherTestForm otherTestForm = new OtherTestForm();
            otherTestForm.MdiParent = this;
            otherTestForm.Show();
        }
    }
}
