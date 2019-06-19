using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace BLD_win10.CaptureCardDriver
{
    /// <summary>
    /// 连接数据采集卡驱动的接口
    /// </summary>
    public interface ICaptureDriver
    {
        IntPtr OpenDevice(Int32 dev_num);

        Int32 DI(IntPtr hDevice);

        Int32 DO(IntPtr hDevice, Int32 data);

        //         [DllImport("AC6623.DLL")]
        //          Int32 ADV(Int32 adg, Int32 addata);

        Int32 CAL(IntPtr hDevice);

        Int32 AD(IntPtr hDevice, Int32 ch, Int32 gain, Int32 sidi);

        Int32 TAD(IntPtr hDevice, Int32 stch, Int32 endch, Int32 adg, Int32 sidi, Int32 sammode, Int32 trsl, Int32 trpol, Int32 clksl, Int32 clkpol, Int32 tdata);

        Int32 TAD_Read(IntPtr hDevice, Int32 rdlen, ref Int32[] addata);

        Int32 TAD_Poll(IntPtr hDevice);

        Int32 TAD_Stop(IntPtr hDevice);

        Int32 DA(IntPtr hDevice, Int32 dach, Int32 dadata);

        Int32 DA_Mode(IntPtr hHandle, Int32 dag0, Int32 dag1);

        unsafe Int32 DA_WRun(IntPtr hDevice, Int32 dag0, Int32 dwlen, Int32 dtdata, Int32* dadata);

        Int32 DA_WStop(IntPtr hDevice);

        Int32 CNT_Run(IntPtr hDevice, Int32 cntch, Int32 cdata);

        Int32 CNT_Read(IntPtr hDevice, Int32 cntch, Int32[] cdata, Int32[] tdata);

        Int32 PRun(IntPtr hDevice, Int32 pch, Int32 pmode, Int32 pdata0, Int32 pdata1);

        Int32 PState(IntPtr hDevice, Int32 pch);

        Int32 PSetData(IntPtr hDevice, Int32 pch, Int32 pdata0, Int32 pdata1);

        Int32 PEnd(IntPtr hDevice, Int32 pch);
    }
}
