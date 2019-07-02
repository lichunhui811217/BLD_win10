using BLD_win10.CaptureCardDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using static BLD_win10.CaptureCardDriver.CaptureDriver;

namespace BLD_win10.Device
{
    public static class DevicesDataCenter
    {
        /// <summary>
        /// 锅炉数据
        /// </summary>
        public static List<Boiler> boilersList = new List<Boiler>();

        /// <summary>
        /// 板卡数据
        /// </summary>
        public static List<CaptureCard> captureCardsList = new List<CaptureCard>();

        /// <summary>
        /// 传感器数据
        /// </summary>
        public static List<Sensor> allSensorsList = new List<Sensor>();

        /// <summary>
        /// 读取设备的配置文件.  系统初始化必要步骤. 
        /// </summary>
        public static void InitializeDevicesData()
        {

            XDocument configXml = XDocument.Load(@".\Config.xml");
            XElement PowerPlantElement = configXml.Root;
            XElement ServerElement = PowerPlantElement.Element("Server");

            //锅炉类 list 初始化
            XElement BoilersElement = ServerElement.Element("Boilers");
            IEnumerable<XElement> BoilerElements = BoilersElement.Elements("Boiler");
            foreach (XElement aBoilderXElement in BoilerElements)
            {
                Boiler boiler = new Boiler();
                boiler.BoilerID = Convert.ToInt32(aBoilderXElement.Attribute("BoilerID").Value);
                boiler.Caption = aBoilderXElement.Attribute("Caption").Value;
                boiler.MapFilePath = aBoilderXElement.Attribute("MapFilePath").Value;
                boilersList.Add(boiler);
            }

            //板卡类 list 初始化
            XElement CaptureCardsElement = ServerElement.Element("CaptureCards");
            IEnumerable<XElement> CaptureCardElements = CaptureCardsElement.Elements("CaptureCard");
            foreach (XElement aCaptureCardXElement in CaptureCardElements)
            {
                CaptureCard aCaptureCard = new CaptureCard();
                aCaptureCard.CaptureCardID = Convert.ToInt32(aCaptureCardXElement.Attribute("CaptureCardID").Value);
                aCaptureCard.CaptureDriver = new CaptureDriver((EnumDriverName)Enum.Parse(typeof(EnumDriverName), aCaptureCardXElement.Attribute("Driver").Value));
                captureCardsList.Add(aCaptureCard);

                //传感器类 list 初始化
                IEnumerable<XElement> sensorElements = aCaptureCardXElement.Elements("Sensor");
                foreach (XElement aSensorElement in sensorElements)
                {
                    Sensor aSensor = new Sensor();

                    aSensor.SensorID = Convert.ToInt32(aSensorElement.Attribute("SensorID").Value);
                    aSensor.ChannelNumber = Convert.ToInt32(aSensorElement.Attribute("ChannelNumber").Value);
                    aSensor.BoilerID = Convert.ToInt32(aSensorElement.Attribute("BoilerID").Value);
                    aSensor.Multiplicative = Convert.ToInt32(aSensorElement.Attribute("Multiplicative").Value);
                    aSensor.BaseNoise = Convert.ToDouble(aSensorElement.Attribute("BaseNoise").Value);
                    aSensor.Uplimit = Convert.ToDouble(aSensorElement.Attribute("Uplimit").Value);
                    aSensor.Downlimit = Convert.ToDouble(aSensorElement.Attribute("Downlimit").Value);
                    aSensor.FFT = Convert.ToInt32(aSensorElement.Attribute("FFT").Value);
                    aSensor.MapLeft = Convert.ToInt32(aSensorElement.Attribute("MapLeft").Value);
                    aSensor.MapTop = Convert.ToInt32(aSensorElement.Attribute("MapTop").Value);
                    aSensor.Boiler = boilersList.Find(x => x.BoilerID == aSensor.BoilerID);

                    allSensorsList.Add(aSensor);
                }
            }
        }

        /// <summary>
        /// 线程状态控制 0=停止线程 1=运行线程
        /// </summary>
        private static bool ThreadStatue;

        /// <summary>
        /// 开始传感器数据读取线程
        /// </summary>
        public static void StartGetCaptureDataThread()
        {
            Thread t = new Thread(new ThreadStart(GetCaptureDataThread));
            ThreadStatue = true;
            t.Start();
        }

        /// <summary>
        /// 停止传感器数据读取线程
        /// </summary>
        public static void StopGetCaptureDataThread()
        {
            ThreadStatue = false;
        }

        /// <summary>
        /// 传感器数据读取线程的主函数
        /// </summary>
        public static void GetCaptureDataThread()
        {
            IntPtr hDevice;
            Int32[] addata;
            CaptureDriver captureDriver;

            #region 加载驱动
            captureDriver = new CaptureDriver((CaptureDriver.EnumDriverName)Enum.Parse(typeof(CaptureDriver.EnumDriverName), "AC6623SIM"));
            hDevice = captureDriver.OpenDevice(0);
            captureDriver.CAL(hDevice);
            #endregion

            addata = new Int32[600000]; //采样数据
            #region 线程一直读取板卡的AD采样信息
            while (ThreadStatue)
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
            Console.WriteLine("Thread stop.");
            #endregion
        }

    }
}

