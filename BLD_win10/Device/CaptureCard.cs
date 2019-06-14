using BLD_win10.CaptureCardDriver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BLD_win10.Device
{
    /// <summary>
    /// 采集卡
    /// </summary>
    public class CaptureCard
    {
        public int CaptureCardID;

        public CaptureDriver CaptureDriver;

        /// <summary>
        /// 采集卡连接的传感器List
        /// </summary>
        public List<Sensor> sensorsList;

        /// <summary>
        /// 
        /// </summary>
        public CaptureCard()
        {
        }

        public CaptureCard(int captureCardID, CaptureDriver captureDriver)
        {
            this.CaptureCardID = captureCardID;
            this.CaptureDriver = captureDriver;
        }

        public CaptureCard(int captureCardID, CaptureDriver captureDriver, List<Sensor> sensorsList)
        {
            this.CaptureCardID = captureCardID;
            this.CaptureDriver = captureDriver;
            this.sensorsList = sensorsList;
        }



        public static async Task Main()
        {
            CaptureCard captureCard = new CaptureCard();
            captureCard.CaptureCardID = 1;
            captureCard.CaptureDriver = new CaptureDriver(CaptureDriver.EnumDriverName.AC6623);

            //captureCard.sensorsList = new Sensor[]
            //{
            //    new Sensor(1, captureCard, 1, 1, 1, 3, 5, 0.5),
            //    new Sensor(2, captureCard, 2, 1, 1, 3, 5, 0.5),
            //};

            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(@"..\Config.xml");

            //// 得到根节点bookstore
            //XmlNode xn = xmlDoc.SelectSingleNode("bookstore");


            //// 得到根节点的所有子节点
            //XmlNodeList xnl = xn.ChildNodes;

            //foreach (XmlNode xn1 in xnl)
            //{
            //    CaptureCard card = new CaptureCard();

            //    // 将节点转换为元素，便于得到节点的属性值
            //    XmlElement xe = (XmlElement)xn1;
                
            //    // 得到属性值
            //    card.CaptureCardID = Convert.ToInt32(xe.GetAttribute("CaptureCardID"));
            //    //card.CaptureDriver = new CaptureDriver((CaptureDriver.EnumDriverName)xe.GetAttribute("CaptureCardID"));
            //    // 得到Book节点的所有子节点
            //    XmlNodeList xnl0 = xe.ChildNodes;
            //    card..BookName = xnl0.Item(0).InnerText;
            //    bookModel.BookAuthor = xnl0.Item(1).InnerText;
            //    bookModel.BookPrice = Convert.ToDouble(xnl0.Item(2).InnerText);
            //    bookModeList.Add(bookModel);
            //}
            //dgvBookInfo.DataSource = bookModeList;

        }

    }
}
