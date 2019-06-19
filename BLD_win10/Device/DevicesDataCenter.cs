using BLD_win10.CaptureCardDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLD_win10.Device
{
    public class DevicesDataCenter
    {
        public static List<Boiler> boilersList = new List<Boiler>();
        public static List<CaptureCard> captureCardsList = new List<CaptureCard>();
        public static List<Sensor> allSensorsList = new List<Sensor>();

        public static void InitializeDevicesData()
        {
            try
            {
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void StartGetCaptureDataThread()
        {
            Thread t = new Thread(new ThreadStart(GetCaptureDataThread));
            t.Start();
        }

        public static void GetCaptureDataThread()
        {
            IntPtr hDevice;
            Int32[] addata;
            CaptureDriver captureDriver;

            #region 加载驱动
            try
            {
                captureDriver = new CaptureDriver((CaptureDriver.EnumDriverName)Enum.Parse(typeof(CaptureDriver.EnumDriverName), "AC6623SIM"));
                hDevice = captureDriver.OpenDevice(0);
                captureDriver.CAL(hDevice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            addata = new Int32[600000];

            #endregion



            while (true)
            {
                foreach (Sensor aSensor in allSensorsList)
                {

                    string str;

                    captureDriver.TAD(hDevice, 0, 14, 2, 0, 0, 0, 0, 0, 0, 100);
                    for (int m = 0; m < 1000; m++)
                    {
                        for (int n = 0; n < 1000; n++)
                        {
                            ; ;
                        }
                    }

                    if (captureDriver.TAD_Poll(hDevice) < 0)
                    {
                        //timer1.Enabled = false;
                        captureDriver.TAD_Stop(hDevice);
                        //listBox_ad.Items.Add("ad fifo over!!!");

                    }
                    else
                    {
                        //read空值则报错
                        if (captureDriver.TAD_Read(hDevice, captureDriver.TAD_Poll(hDevice), ref addata) == -1)
                        {
                            //listBox_ad.Items.Add("ad fifo over!!!");
                        }
                        else
                        {
                            //listBox_ad.Items.Clear();//清空数据
                            for (Int16 i = 0; i < 15; i++)
                            {
                                str = Convert.ToString(((addata[i]) - 2048) * 5000 / 2048); //  (0..4096分度) = ( -5 .. +5 V 电压)
                                                                                            //  int j = str.IndexOf('.');//
                                                                                            //      j = j + 3;
                                                                                            //    str = str.Substring(0, j);//
                                str = str + " mv";
                                //listBox_ad.Items.Add(str);//写入数据
                            }
                        }

                    }

                    captureDriver.TAD_Stop(hDevice);

                    Thread.Sleep(10);
                }
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine("ThreadProc: {0}", i);
                //    // Yield the rest of the time slice.
                //    Thread.Sleep(10);
                //}
            }
        }
    }
}

