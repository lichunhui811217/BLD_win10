using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        public DateTime LastOverCapTime { get; }

        private int[] tempArrayValues;
        public int[] ArrayValuess
        {
            get
            {
                return tempArrayValues;
            }
        }

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

        //internal
        /// <summary>
        /// 获取点应有的颜色
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Color GetColor(double value)
        {
            if(false)//TODO:如果是吹灰状态,则蓝.
            {
                return Color.DodgerBlue;
            }
            else if (false)//TODO:超上限时间大于设定时间,则报警(红)
            {
                return Color.Red;
            }
            else if (value > Uplimit)
            {
                return Color.Orange;//超上限,橙色
            }
            else if (value < Downlimit)
            {
                return Color.Yellow;//超下限,黄
            }
            else if (value <= Uplimit && value >= Downlimit)
            {
                return Color.Lime;//正常,青柠色
            }
            else
            {
                return Color.Black;//上面都不是, 说明程序错误.  黑
            }
        }

    }
}
