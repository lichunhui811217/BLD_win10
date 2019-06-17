using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
