using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLD_win10.Device;

namespace BLD_win10.Device
{

    /// <summary>
    /// 传感器类
    /// </summary>
    public class Sensor
    {
        //SensorID ChannelNumber="1" BoilderID="1" Multiplicative="24" BaseNoise="0" Uplimit="2.2" Downlimit="0.5" FFT="0" 

        /// <summary>
        /// 传感器ID
        /// </summary>
        public int SensorID;

        /// <summary>
        /// 传感器使用的板卡. TODO:考虑是否应让 Sensor 继承 CaptureCard?
        /// </summary>
        public CaptureCard CaptureCard;

        /// <summary>
        /// 传感器使用的板卡通道
        /// </summary>
        public int ChannelNumber;

        /// <summary>
        /// 传感器对应的锅炉ID
        /// </summary>
        public int BoilerID;

        /// <summary>
        /// 放大倍数因子
        /// </summary>
        public double Multiplicative;

        /// <summary>
        /// 基础噪声强度
        /// </summary>
        public double BaseNoise;

        /// <summary>
        /// 上限
        /// </summary>
        public double Uplimit = 100;

        /// <summary>
        /// 下限
        /// </summary>
        public double Downlimit = 0;

        /// <summary>
        /// FFT警戒线
        /// </summary>
        public int FFT = 0;

        /// <summary>
        /// 传感器对应的锅炉
        /// </summary>
        public Boiler Boiler;

        public Sensor()
        {
        }

        public Sensor(int SensorID, CaptureCard CaptureCard, int ChannelNumber, int BoilerID)
        {
            this.SensorID = SensorID;
            this.CaptureCard = CaptureCard;
            this.ChannelNumber = ChannelNumber;
            this.BoilerID = BoilerID;
        }

        public Sensor(int SensorID, CaptureCard CaptureCard, int ChannelNumber, int BoilerID, int Multiplicative, 
            double BaseNoise, double Uplimit, double Downlimit, int FFT, Boiler Boiler)
        {
            this.SensorID = SensorID;
            this.CaptureCard = CaptureCard;
            this.ChannelNumber = ChannelNumber;
            this.BoilerID = BoilerID;
            this.Multiplicative = Multiplicative;
            this.BaseNoise = BaseNoise;
            this.Uplimit = Uplimit;
            this.Downlimit = Downlimit;
            this.FFT = FFT;
            this.Boiler = Boiler;
        }
    }
}
