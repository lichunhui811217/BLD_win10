using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.CaptureCardDriver
{
    public class CaptureDriver
    {
        private ICaptureDriver captureDriver;

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
                    captureDriver = new AC6623Driver();
                    break;
                case EnumDriverName.AC6623SIM:
                    captureDriver = new AC6623SimDriver();
                    break;
                case EnumDriverName.PC6311:
                    captureDriver = new PC6311Driver();
                    break;
                case EnumDriverName.PC6311SIM:
                    captureDriver = new PC6311SimDll();
                    break;
                default:
                    throw new SystemException("使用了未知的采集卡驱动");
            }
        }

        public IntPtr OpenDevice(Int32 dev_num)
        {
            return captureDriver.OpenDevice(dev_num);
            //return new IntPtr(0x069D);
        }

        public Int32 DI(IntPtr hDevice)
        {
            return captureDriver.DI(hDevice);
        }

        public Int32 DO(IntPtr hDevice, Int32 data)
        {
            return captureDriver.DO(hDevice, data);
        }

        //         [DllImport("AC6623.DLL")]
        //         public   Int32 ADV(Int32 adg, Int32 addata);

        public Int32 CAL(IntPtr hDevice)
        {
            return captureDriver.CAL(hDevice);
        }

        public Int32 AD(IntPtr hDevice, Int32 ch, Int32 gain, Int32 sidi)
        {
            return captureDriver.AD(hDevice, ch, gain, sidi);
        }

        public Int32 TAD(IntPtr hDevice, Int32 stch, Int32 endch, Int32 adg, Int32 sidi, Int32 sammode, Int32 trsl, Int32 trpol, Int32 clksl, Int32 clkpol, Int32 tdata)
        {
            return captureDriver.TAD(hDevice, stch, endch, adg, sidi, sammode, trsl, trpol, clksl, clkpol, tdata);
        }

        public Int32 TAD_Read(IntPtr hDevice, Int32 rdlen, ref Int32[] addata)
        {
            return captureDriver.TAD_Read(hDevice, rdlen, ref addata);
        }

        public Int32 TAD_Poll(IntPtr hDevice)
        {
            return captureDriver.TAD_Poll(hDevice);
        }

        public Int32 TAD_Stop(IntPtr hDevice)
        {
            return captureDriver.TAD_Stop(hDevice);
        }

        public Int32 DA(IntPtr hDevice, Int32 dach, Int32 dadata)
        {
            return captureDriver.DA(hDevice, dach, dadata);
        }

        public Int32 DA_Mode(IntPtr hHandle, Int32 dag0, Int32 dag1)
        {
            return captureDriver.DA_Mode(hHandle, dag0, dag1);
        }

        unsafe public Int32 DA_WRun(IntPtr hDevice, Int32 dag0, Int32 dwlen, Int32 dtdata, Int32* dadata)
        {
            return captureDriver.DA_WRun(hDevice, dag0, dwlen, dtdata, dadata);
        }

        public Int32 DA_WStop(IntPtr hDevice)
        {
            return captureDriver.DA_WStop(hDevice);
        }

        public Int32 CNT_Run(IntPtr hDevice, Int32 cntch, Int32 cdata)
        {
            return captureDriver.CNT_Run(hDevice, cntch, cdata);
        }

        public Int32 CNT_Read(IntPtr hDevice, Int32 cntch, Int32[] cdata, Int32[] tdata)
        {
            return captureDriver.CNT_Read(hDevice, cntch, cdata, tdata);
        }

        public Int32 PRun(IntPtr hDevice, Int32 pch, Int32 pmode, Int32 pdata0, Int32 pdata1)
        {
            return captureDriver.PRun(hDevice, pch, pmode, pdata0, pdata1);
        }

        public Int32 PState(IntPtr hDevice, Int32 pch)
        {
            return captureDriver.PState(hDevice, pch);
        }

        public Int32 PSetData(IntPtr hDevice, Int32 pch, Int32 pdata0, Int32 pdata1)
        {
            return captureDriver.PSetData(hDevice, pch, pdata0, pdata1);
        }

        public Int32 PEnd(IntPtr hDevice, Int32 pch)
        {
            return captureDriver.PEnd(hDevice, pch);
        }
    }
}