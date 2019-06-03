using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLD_win10.CaptureData;

namespace BLD_win10.CaptureData
{
    public class CaptureDriver
    {
        private ICaptureData captureData;

        public enum EnumDriverName
        {
            AC6623, AC6623SIM, PC6311, PC6311SIM,
        }

        public EnumDriverName DriverName { get; set; }

        public CaptureDriver(EnumDriverName driverName)
        {
            this.DriverName = driverName;
            switch (DriverName)
            {
                case EnumDriverName.AC6623:
                    captureData = new AC6623();
                    break;
                case EnumDriverName.AC6623SIM:
                    captureData = new AC6623SIM();
                    break;
                case EnumDriverName.PC6311:
                    captureData = new PC6311();
                    break;
                case EnumDriverName.PC6311SIM:
                    captureData = new PC6311SIM();
                    break;
                default:
                    throw new SystemException("使用了未知的采集卡驱动");
            }
        }

        public IntPtr OpenDevice(Int32 dev_num)
        {
            return captureData.OpenDevice(dev_num);
            //return new IntPtr(0x069D);
        }

        public Int32 DI(IntPtr hDevice)
        {
            return 0;
        }

        public Int32 DO(IntPtr hDevice, Int32 data)
        {
            return 0;
        }

        //         [DllImport("AC6623.DLL")]
        //         public   Int32 ADV(Int32 adg, Int32 addata);

        public Int32 CAL(IntPtr hDevice)
        {
            return 0;
        }

        public Int32 AD(IntPtr hDevice, Int32 ch, Int32 gain, Int32 sidi)
        {
            return 0;
        }

        public Int32 TAD(IntPtr hDevice, Int32 stch, Int32 endch, Int32 adg, Int32 sidi, Int32 sammode, Int32 trsl, Int32 trpol, Int32 clksl, Int32 clkpol, Int32 tdata)
        {
            //return TAD( hDevice,  stch,  endch,  adg,  sidi,  sammode,  trsl,  trpol,  clksl,  clkpol,  tdata);
            return 0;
        }
        unsafe public Int32 TAD_Read(IntPtr hDevice, Int32 rdlen, Int32[] addata)
        {
            return 0;
        }

        public Int32 TAD_Poll(IntPtr hDevice)
        {
            return 0;
        }

        public Int32 TAD_Stop(IntPtr hDevice)
        {
            return 0;
        }

        public Int32 DA(IntPtr hDevice, Int32 dach, Int32 dadata)
        {
            return 0;
        }

        public Int32 DA_Mode(IntPtr hHandle, Int32 dag0, Int32 dag1)
        {
            return 0;
        }

        unsafe public Int32 DA_WRun(IntPtr hDevice, Int32 dag0, Int32 dwlen, Int32 dtdata, Int32* dadata)
        {
            return 0;
        }

        public Int32 DA_WStop(IntPtr hDevice)
        {
            return 0;
        }

        public Int32 CNT_Run(IntPtr hDevice, Int32 cntch, Int32 cdata)
        {
            return 0;
        }

        public Int32 CNT_Read(IntPtr hDevice, Int32 cntch, Int32[] cdata, Int32[] tdata)
        {
            return 0;
        }

        public Int32 PRun(IntPtr hDevice, Int32 pch, Int32 pmode, Int32 pdata0, Int32 pdata1)
        {
            return 0;
        }

        public Int32 PState(IntPtr hDevice, Int32 pch)
        {
            return 0;
        }

        public Int32 PSetData(IntPtr hDevice, Int32 pch, Int32 pdata0, Int32 pdata1)
        {
            return 0;
        }

        public Int32 PEnd(IntPtr hDevice, Int32 pch)
        {
            return 0;
        }
    }
}