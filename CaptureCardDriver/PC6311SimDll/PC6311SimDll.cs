using System;

namespace BLD_win10.CaptureCardDriver
{
    public class PC6311SimDll : ICaptureDriver
    {
        public int AD(IntPtr hDevice, int ch, int gain, int sidi)
        {
            throw new NotImplementedException();
        }

        public int CAL(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }

        public int CNT_Read(IntPtr hDevice, int cntch, int[] cdata, int[] tdata)
        {
            throw new NotImplementedException();
        }

        public int CNT_Run(IntPtr hDevice, int cntch, int cdata)
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

        public int DI(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }

        public int DO(IntPtr hDevice, int data)
        {
            throw new NotImplementedException();
        }

        public IntPtr OpenDevice(int dev_num)
        {
            throw new NotImplementedException();
        }

        public int PEnd(IntPtr hDevice, int pch)
        {
            throw new NotImplementedException();
        }

        public int PRun(IntPtr hDevice, int pch, int pmode, int pdata0, int pdata1)
        {
            throw new NotImplementedException();
        }

        public int PSetData(IntPtr hDevice, int pch, int pdata0, int pdata1)
        {
            throw new NotImplementedException();
        }

        public int PState(IntPtr hDevice, int pch)
        {
            throw new NotImplementedException();
        }

        public int TAD(IntPtr hDevice, int stch, int endch, int adg, int sidi, int sammode, int trsl, int trpol, int clksl, int clkpol, int tdata)
        {
            throw new NotImplementedException();
        }

        public int TAD_Poll(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }

        public int TAD_Read(IntPtr hDevice, int rdlen, ref int[] addata)
        {
            throw new NotImplementedException();
        }

        public int TAD_Stop(IntPtr hDevice)
        {
            throw new NotImplementedException();
        }
    }
}
