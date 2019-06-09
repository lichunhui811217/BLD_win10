using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.Device
{
    /// <summary>
    /// 火电厂
    /// </summary>
    public class PowerPlant
    {
        //厂名
        //地址
        //联系人等等

        /// <summary>
        /// 主机集合[]
        /// </summary>
        public Server[] Servers;
    }

    class Test
    {
        void main()
        {
            PowerPlant pp = new PowerPlant();
            pp.Servers = new Server[] { new Server() };
            Server[] ns = pp.Servers;
            int i = ns.Length;

            foreach(Server s in pp.Servers)
            {
                Console.WriteLine(s.ServerName);
            }
        }
    }
}
