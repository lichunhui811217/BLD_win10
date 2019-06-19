using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.CaptureCardDriver
{
    public class AC6623SimDriver : ICaptureDriver
    {
        Random random = new Random();
        
        public int AD(IntPtr hDevice, int ch, int gain, int sidi)
        {
            return random.Next(32000);
        }

        public int CAL(IntPtr hDevice)
        {
            return random.Next(32000);
        }

        public int CNT_Read(IntPtr hDevice, int cntch, int[] cdata, int[] tdata)
        {
            return random.Next(32000);
        }

        public int CNT_Run(IntPtr hDevice, int cntch, int cdata)
        {
            return random.Next(32000);
        }

        public int DA(IntPtr hDevice, int dach, int dadata)
        {
            return random.Next(32000);
        }

        public int DA_Mode(IntPtr hHandle, int dag0, int dag1)
        {
            return random.Next(32000);
        }

        public unsafe int DA_WRun(IntPtr hDevice, int dag0, int dwlen, int dtdata, int* dadata)
        {
            return random.Next(32000);
        }

        public int DA_WStop(IntPtr hDevice)
        {
            return random.Next(32000);
        }

        public int DI(IntPtr hDevice)
        {
            return random.Next(32000);
        }

        public int DO(IntPtr hDevice, int data)
        {
            return random.Next(32000);
        }

        public IntPtr OpenDevice(int dev_num)
        {
            return new IntPtr(0x069D);
        }

        public int PEnd(IntPtr hDevice, int pch)
        {
            return random.Next(32000);
        }

        public int PRun(IntPtr hDevice, int pch, int pmode, int pdata0, int pdata1)
        {
            return random.Next(32000);
        }

        public int PSetData(IntPtr hDevice, int pch, int pdata0, int pdata1)
        {
            return random.Next(32000);
        }

        public int PState(IntPtr hDevice, int pch)
        {
            return random.Next(32000);
        }

        public int TAD(IntPtr hDevice, int stch, int endch, int adg, int sidi, int sammode, int trsl, int trpol, int clksl, int clkpol, int tdata)
        {
            return random.Next(32000);
        }

        public int TAD_Poll(IntPtr hDevice)
        {
            return 500;
        }

        public int TAD_Read(IntPtr hDevice, int rdlen, ref int[] addata)
        {
            int[] outInt = new int[100];
            for(int i=0;i< outInt.Length;i++)
            {
                outInt[i] = random.Next(0, 4096);
            }
            addata = outInt;
            return 1;
        }

        public int TAD_Stop(IntPtr hDevice)
        {
            return random.Next(32000);
        }
    }
}
