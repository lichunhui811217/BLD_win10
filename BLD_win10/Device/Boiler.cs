using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.Device
{
    /// <summary>
    /// 锅炉
    /// </summary>
    public class Boiler
    {
        /// <summary>
        /// 锅炉编号 BoilerNo
        /// </summary>
        public int BoilerID;

        /// <summary>
        /// 锅炉名字 Caption
        /// </summary>
        public string Caption;

        public Boiler ()
        {

        }

        public Boiler(int boilerID)
        {
            this.BoilerID = boilerID;
            this.Caption = "#" + boilerID.ToString() + "锅炉";
        }

        public Boiler(int boilerID, string caption)
        {
            this.BoilerID = boilerID;
            this.Caption = caption;
        }
    }
}
