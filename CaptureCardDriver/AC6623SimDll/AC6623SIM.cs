using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.CaptureCardDriver
{
    public class AC6623SimDriver:ICaptureDriver
    {
        public static IntPtr AC6623_OpenDevice(Int32 dev_num)
        {
            return new IntPtr(0x069D);
        }

        public static Int32 AC6623_DI(IntPtr hDevice)
        {
            return 0;
        }

        public static Int32 AC6623_DO(IntPtr hDevice, Int32 data)
        {
            return 0;
        }

        //         [DllImport("AC6623.DLL")]
        //         public static  Int32 AC6623_ADV(Int32 adg, Int32 addata);

        public static Int32 AC6623_CAL(IntPtr hDevice)
        {
            return 0;
        }

        public static Int32 AC6623_AD(IntPtr hDevice, Int32 ch, Int32 gain, Int32 sidi)
        {
            return 0;
        }

        public static Int32 AC6623_TAD(IntPtr hDevice, Int32 stch, Int32 endch, Int32 adg, Int32 sidi, Int32 sammode, Int32 trsl, Int32 trpol, Int32 clksl, Int32 clkpol, Int32 tdata)
        {
            return 0;
        }
        unsafe public static Int32 AC6623_TAD_Read(IntPtr hDevice, Int32 rdlen, Int32[] addata)
        {
            return 0;
        }

        public static Int32 AC6623_TAD_Poll(IntPtr hDevice)
        {
            return 0;
        }

        public static Int32 AC6623_TAD_Stop(IntPtr hDevice)
        {
            return 0;
        }

        public static Int32 AC6623_DA(IntPtr hDevice, Int32 dach, Int32 dadata)
        {
            return 0;
        }

        public static Int32 AC6623_DA_Mode(IntPtr hHandle, Int32 dag0, Int32 dag1)
        {
            return 0;
        }

        unsafe public static Int32 AC6623_DA_WRun(IntPtr hDevice, Int32 dag0, Int32 dwlen, Int32 dtdata, Int32* dadata)
        {
            return 0;
        }

        public static Int32 AC6623_DA_WStop(IntPtr hDevice)
        {
            return 0;
        }

        public static Int32 AC6623_CNT_Run(IntPtr hDevice, Int32 cntch, Int32 cdata)
        {
            return 0;
        }

        public static Int32 AC6623_CNT_Read(IntPtr hDevice, Int32 cntch, Int32[] cdata, Int32[] tdata)
        {
            return 0;
        }

        public static Int32 AC6623_PRun(IntPtr hDevice, Int32 pch, Int32 pmode, Int32 pdata0, Int32 pdata1)
        {
            return 0;
        }

        public static Int32 AC6623_PState(IntPtr hDevice, Int32 pch)
        {
            return 0;
        }

        public static Int32 AC6623_PSetData(IntPtr hDevice, Int32 pch, Int32 pdata0, Int32 pdata1)
        {
            return 0;
        }

        public static Int32 AC6623_PEnd(IntPtr hDevice, Int32 pch)
        {
            return 0;
        }

        public IntPtr OpenDevice(int dev_num)
        {
            throw new NotImplementedException();
        }

        public int DI(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }

        public int DO(IntPtr hDevice, int data)
        {
            throw new NotImplementedException();
        }

        public int CAL(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }

        public int AD(IntPtr hDevice, int ch, int gain, int sidi)
        {
            throw new NotImplementedException();
        }

        public int TAD(IntPtr hDevice, int stch, int endch, int adg, int sidi, int sammode, int trsl, int trpol, int clksl, int clkpol, int tdata)
        {
            throw new NotImplementedException();
        }

        public int TAD_Read(IntPtr hDevice, int rdlen, int[] addata)
        {
            throw new NotImplementedException();
        }

        public int TAD_Poll(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }

        public int TAD_Stop(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }

        public int DA(IntPtr hDevice, int dach, int dadata)
        {
            throw new NotImplementedException();
        }

        public int DA_Mode(IntPtr hHandle, int dag0, int dag1)
        {
            throw new NotImplementedException();
        }

        public unsafe int DA_WRun(IntPtr hDevice, int dag0, int dwlen, int dtdata, int* dadata)
        {
            throw new NotImplementedException();
        }

        public int DA_WStop(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }

        public int CNT_Run(IntPtr hDevice, int cntch, int cdata)
        {
            throw new NotImplementedException();
        }

        public int CNT_Read(IntPtr hDevice, int cntch, int[] cdata, int[] tdata)
        {
            throw new NotImplementedException();
        }

        public int PRun(IntPtr hDevice, int pch, int pmode, int pdata0, int pdata1)
        {
            throw new NotImplementedException();
        }

        public int PState(IntPtr hDevice, int pch)
        {
            throw new NotImplementedException();
        }

        public int PSetData(IntPtr hDevice, int pch, int pdata0, int pdata1)
        {
            throw new NotImplementedException();
        }

        public int PEnd(IntPtr hDevice, int pch)
        {
            throw new NotImplementedException();
        }
    }
}
