using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.Device
{
    /// <summary>
    /// 主服务器
    /// </summary>
    public class Server
    {
        /// <summary>
        /// 服务器名
        /// </summary>
        public string ServerName;

        /// <summary>
        /// 锅炉集合[]
        /// </summary>
        public Boiler[] Boilers;

        /// <summary>
        /// 采集卡集合[]
        /// </summary>
        public CaptureCard[] CaptureCards;

        /// <summary>
        /// 重建锅炉集合
        /// 按照配置文件,将各采集卡内的通道分配给锅炉
        /// </summary>
        public void ReconstructionBoilers()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 从Com口接收数据
        /// </summary>
        public void ReceiveDataFromCom(/*EventHandler device*/)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 向Com口发送数据
        /// </summary>
        public void SendDataToCom()
        {
            throw new NotImplementedException();
        }

    }
}
