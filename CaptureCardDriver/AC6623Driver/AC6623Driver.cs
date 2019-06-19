using System;


using System.Runtime.InteropServices;

namespace BLD_win10.CaptureCardDriver
{
    public class AC6623Driver : ICaptureDriver
    {
        [DllImport("AC6623.DLL")]
        public static extern IntPtr AC6623_OpenDevice(Int32 dev_num);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_DI(IntPtr hDevice);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_DO(IntPtr hDevice, Int32 data);

        //         [DllImport("AC6623.DLL")]
        //         public static extern Int32 AC6623_ADV(Int32 adg, Int32 addata);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_CAL(IntPtr hDevice);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_AD(IntPtr hDevice, Int32 ch, Int32 gain, Int32 sidi);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_TAD(IntPtr hDevice, Int32 stch, Int32 endch, Int32 adg, Int32 sidi, Int32 sammode, Int32 trsl, Int32 trpol, Int32 clksl, Int32 clkpol, Int32 tdata);

        [DllImport("AC6623.DLL")]
        unsafe public static extern Int32 AC6623_TAD_Read(IntPtr hDevice, Int32 rdlen, Int32[] addata);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_TAD_Poll(IntPtr hDevice);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_TAD_Stop(IntPtr hDevice);


        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_DA(IntPtr hDevice, Int32 dach, Int32 dadata);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_DA_Mode(IntPtr hHandle, Int32 dag0, Int32 dag1);

        [DllImport("AC6623.DLL")]
        unsafe public static extern Int32 AC6623_DA_WRun(IntPtr hDevice, Int32 dag0, Int32 dwlen, Int32 dtdata, Int32* dadata);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_DA_WStop(IntPtr hDevice);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_CNT_Run(IntPtr hDevice, Int32 cntch, Int32 cdata);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_CNT_Read(IntPtr hDevice, Int32 cntch, Int32[] cdata, Int32[] tdata);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_PRun(IntPtr hDevice, Int32 pch, Int32 pmode, Int32 pdata0, Int32 pdata1);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_PState(IntPtr hDevice, Int32 pch);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_PSetData(IntPtr hDevice, Int32 pch, Int32 pdata0, Int32 pdata1);

        [DllImport("AC6623.DLL")]
        public static extern Int32 AC6623_PEnd(IntPtr hDevice, Int32 pch);

        public int AD(IntPtr hDevice, int ch, int gain, int sidi)
        {
            return AC6623_AD(hDevice, ch, gain, sidi);
        }

        public int CAL(IntPtr hDevice)
        {
            return AC6623_CAL(hDevice);
        }

        public int CNT_Read(IntPtr hDevice, int cntch, int[] cdata, int[] tdata)
        {
            return AC6623_CNT_Read(hDevice, cntch, cdata, tdata);
        }

        public int CNT_Run(IntPtr hDevice, int cntch, int cdata)
        {
            return AC6623_CNT_Run(hDevice, cntch, cdata);
        }

        public int DA(IntPtr hDevice, int dach, int dadata)
        {
            return AC6623_DA(hDevice, dach, dadata);
        }

        public int DA_Mode(IntPtr hHandle, int dag0, int dag1)
        {
            return AC6623_DA_Mode(hHandle, dag0, dag1);
        }

        public unsafe int DA_WRun(IntPtr hDevice, int dag0, int dwlen, int dtdata, int* dadata)
        {
            return AC6623_DA_WRun(hDevice, dag0, dwlen, dtdata, dadata);
        }

        public int DA_WStop(IntPtr hDevice)
        {
            return AC6623_DA_WStop(hDevice);
        }

        public int DI(IntPtr hDevice)
        {
            return AC6623_DI(hDevice);
        }

        public int DO(IntPtr hDevice, int data)
        {
            return AC6623_DO(hDevice, data);
        }

        public IntPtr OpenDevice(int dev_num)
        {
            return AC6623_OpenDevice(dev_num);
        }

        public int PEnd(IntPtr hDevice, int pch)
        {
            return AC6623_PEnd(hDevice, pch);
        }

        public int PRun(IntPtr hDevice, int pch, int pmode, int pdata0, int pdata1)
        {
            return AC6623_PRun(hDevice, pch, pmode, pdata0, pdata1);
        }

        public int PSetData(IntPtr hDevice, int pch, int pdata0, int pdata1)
        {
            return AC6623_PSetData(hDevice, pch, pdata0, pdata1);
        }

        public int PState(IntPtr hDevice, int pch)
        {
            return AC6623_PState(hDevice, pch);
        }

        public int TAD(IntPtr hDevice, int stch, int endch, int adg, int sidi, int sammode, int trsl, int trpol, int clksl, int clkpol, int tdata)
        {
            return AC6623_TAD(hDevice, stch, endch, adg, sidi, sammode, trsl, trpol, clksl, clkpol, tdata);
        }

        public int TAD_Poll(IntPtr hDevice)
        {
            return AC6623_TAD_Poll(hDevice);
        }

        public int TAD_Read(IntPtr hDevice, int rdlen, ref int[] addata)
        {
            //AC6623_TAD_Read(hDevice, rdlen, addata);
            
            return AC6623_TAD_Read(hDevice, rdlen, addata);
        }

        public int TAD_Stop(IntPtr hDevice)
        {
            return AC6623_TAD_Stop(hDevice);
        }
    }
}
