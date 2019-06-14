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
        public int Channel;

        /// <summary>
        /// 传感器对应的锅炉
        /// </summary>
        public Boiler Boiler;

        /// <summary>
        /// 传感器对应的锅炉ID
        /// </summary>
        public int BoilerID;

        /// <summary>
        /// 放大倍数因子
        /// </summary>
        public double Amplification;

        /// <summary>
        /// 基础噪声强度
        /// </summary>
        public double BasicNoise;

        /// <summary>
        /// 上限
        /// </summary>
        public double UpLimit = 100;

        /// <summary>
        /// 下限
        /// </summary>
        public double DownLimit = 0;

        public Sensor()
        {
        }

        public Sensor(int SensorID, CaptureCard CaptureCard, int Channel, int BoilerID)
        {
            this.SensorID = SensorID;
            this.CaptureCard = CaptureCard;
            this.Channel = Channel;
            this.BoilerID = BoilerID;
        }

        public Sensor(int SensorID, CaptureCard CaptureCard, int Channel, int BoilerID, int Amplification, double BasicNoise, double UpLimit, double DownLimit)
        {
            this.SensorID = SensorID;
            this.CaptureCard = CaptureCard;
            this.Channel = Channel;
            this.BoilerID = BoilerID;
            this.Amplification = Amplification;
            this.BasicNoise = BasicNoise;
            this.UpLimit = UpLimit;
            this.DownLimit = DownLimit;
        }
    }
}
