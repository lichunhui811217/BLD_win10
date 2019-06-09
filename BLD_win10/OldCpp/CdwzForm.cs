using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLD_win10.OldCpp
{
    /// <summary>
    /// 测点位置
    /// </summary>
    public partial class CdwzForm : Form
    {
        //int tongdaoshu[4];
        //bool hand_operation[4];
        //AnsiString guolutitle[4];
        ////---------------------------------------------------------------------------
        ////   Important note about DLL memory management when your DLL uses the
        ////   static version of the RunTime Library:
        ////
        ////   If your DLL exports any functions that pass String objects (or structs/
        ////   classes containing nested Strings) as parameter or function results,
        ////   you will need to add the library MEMMGR.LIB to both the DLL project and
        ////   any other projects that use the DLL.  You will also need to use MEMMGR.LIB
        ////   if any other projects which use the DLL will be perfomring new or delete
        ////   operations on any non-TObject-derived classes which are exported from the
        ////   DLL. Adding MEMMGR.LIB to your project will change the DLL and its calling
        ////   EXE's to use the BORLNDMM.DLL as their memory manager.  In these cases,
        ////   the file BORLNDMM.DLL should be deployed along with your DLL.
        ////
        ////   To avoid using BORLNDMM.DLL, pass string information using "char *" or
        ////   ShortString parameters.
        ////
        ////   If your DLL uses the dynamic version of the RTL, you do not need to
        ////   explicitly add MEMMGR.LIB as this will be done implicitly for you
        ////---------------------------------------------------------------------------
        //USEFORM("dlg_loca1.cpp", l1);
        //USEFORM("dlg_loca2.cpp", l2);
        //USEFORM("dlg_loca4.cpp", l4);
        //USEFORM("dlg_loca3.cpp", l3);
        //AnsiString lb;

        public CdwzForm()
        {
            InitializeComponent();
        }

        private void CdwzForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 调用WindowsAPI DllEntryPoint?
        /// </summary>
        //int WINAPI DllEntryPoint(HINSTANCE hinst, unsigned long reason, void*)
        //{
        //    for (int i = 0; i < 4; i++)
        //        hand_operation[i] = false;
        //    return 1;
        //}

        /// <summary>
        /// 显示测点位置
        /// </summary>
        unsafe void Showcdwz(int BoilerNo, int Low32, int High32, int Channelnum, char* lcaption)
        {
            //int Count[MAX_CHANNEL];
            //int mov = 1;
            //int lsh = 0;
            //tongdaoshu[BoilerNo - 1] = Channelnum;
            //for (int i = 0; i < MAX_CHANNEL; i++) Count[i] = -1;
            //for (int i = 0; i < 32; i++)
            //{
            //    lsh = mov << i;
            //    if (Low32 & lsh)
            //    {
            //        Count[i] = i;
            //    }
            //}
            //for (int i = 32; i < Channelnum; i++)
            //{
            //    lsh = mov << (i - 32);
            //    if (High32 & lsh)
            //    {
            //        Count[i] = i;
            //    }
            //}
            //lb = AnsiString(lcaption) + "测点位置图";

            //if (BoilerNo == 1)
            //{
            //    guolutitle[0] = lb;
            //    if (FindWindow("Tl1", (guolutitle[0]).c_str()) == NULL)
            //    {
            //        l1 = new Tl1(Application);
            //        hand_operation[BoilerNo - 1] = false;
            //        l1->Show();
            //        l1->Caption = guolutitle[0];
            //    }
            //    else
            //    {
            //        if (hand_operation[BoilerNo - 1] == true)
            //        {
            //            hand_operation[BoilerNo - 1] = false;
            //            l1->Show();
            //        }
            //    }
            //    for (int i = 0; i < Channelnum; i++)
            //    {
            //        if (Count[i] == i) l1->flag_tongdao[i] = 1;
            //        else l1->flag_tongdao[i] = 0;
            //    }
            //}

            //if (BoilerNo == 2)
            //{
            //    guolutitle[1] = lb;
            //    if (FindWindow("Tl2", (guolutitle[1]).c_str()) == NULL)
            //    {
            //        l2 = new Tl2(Application);
            //        hand_operation[BoilerNo - 1] = false;
            //        l2->Show();
            //        l2->Caption = guolutitle[1];
            //    }
            //    else
            //    {
            //        if (hand_operation[BoilerNo - 1] == true)
            //        {
            //            hand_operation[BoilerNo - 1] = false;
            //            l2->Show();
            //        }
            //    }
            //    for (int i = 0; i < Channelnum; i++)
            //    {
            //        if (Count[i] == i) l2->flag_tongdao[i] = 1;
            //        else l2->flag_tongdao[i] = 0;
            //    }
            //}
            //if (BoilerNo == 3)
            //{
            //    guolutitle[2] = lb;
            //    if (FindWindow("Tl3", (guolutitle[2]).c_str()) == NULL)
            //    {
            //        l3 = new Tl3(Application);
            //        hand_operation[BoilerNo - 1] = false;
            //        l3->Show();
            //        l3->Caption = guolutitle[2];
            //    }
            //    else
            //    {
            //        if (hand_operation[BoilerNo - 1] == true)
            //        {
            //            hand_operation[BoilerNo - 1] = false;
            //            l3->Show();
            //        }
            //    }
            //    for (int i = 0; i < Channelnum; i++)
            //    {
            //        if (Count[i] == i) l3->flag_tongdao[i] = 1;
            //        else l3->flag_tongdao[i] = 0;
            //    }

            //}
            //if (BoilerNo == 4)
            //{
            //    guolutitle[3] = lb;
            //    if (FindWindow("Tl4", (guolutitle[3]).c_str()) == NULL)
            //    {
            //        l4 = new Tl4(Application);
            //        hand_operation[BoilerNo - 1] = false;
            //        l4->Show();
            //        l4->Caption = guolutitle[3];
            //    }
            //    else
            //    {
            //        if (hand_operation[BoilerNo - 1] == true)
            //        {
            //            hand_operation[BoilerNo - 1] = false;
            //            l4->Show();
            //        }
            //    }
            //    for (int i = 0; i < Channelnum; i++)
            //    {
            //        if (Count[i] == i) l4->flag_tongdao[i] = 1;
            //        else l4->flag_tongdao[i] = 0;
            //    }
            //}
            throw new NotImplementedException();
        }

        /// <summary>
        /// 显示测点位置常规?
        /// </summary>
        /// <param name="BoilerNo"></param>
        /// <param name="Channelnum"></param>
        /// <param name="lcaption"></param>
        unsafe void ShowcdwzNormal(int BoilerNo, int Channelnum, char* lcaption)
        {
            //tongdaoshu[BoilerNo - 1] = Channelnum;
            //hand_operation[BoilerNo - 1] = true;
            //lb = AnsiString(lcaption) + "测点位置图";
            //if (BoilerNo == 1)
            //{
            //    guolutitle[0] = lb;

            //    if (FindWindow("Tl1", (guolutitle[0]).c_str()) == NULL)
            //    {
            //        l1 = new Tl1(Application);
            //        l1->Show();
            //        l1->Caption = guolutitle[0];
            //    }
            //    else
            //    {
            //        l1->Show();
            //        l1->WindowState = wsNormal;
            //    }
            //}
            //if (BoilerNo == 2)
            //{
            //    guolutitle[1] = lb;
            //    if (FindWindow("Tl2", (guolutitle[1]).c_str()) == NULL)
            //    {
            //        l2 = new Tl2(Application);
            //        l2->Show();
            //        l2->Caption = guolutitle[1];
            //    }
            //    else
            //    {
            //        l2->Show();
            //        l2->WindowState = wsNormal;
            //    }
            //}
            //if (BoilerNo == 3)
            //{
            //    guolutitle[2] = lb;
            //    if (FindWindow("Tl3", (guolutitle[2]).c_str()) == NULL)
            //    {
            //        l3 = new Tl3(Application);
            //        l3->Show();
            //        l3->Caption = guolutitle[2];
            //    }
            //    else
            //    {
            //        l3->Show();
            //        l3->WindowState = wsNormal;
            //    }
            //}
            //if (BoilerNo == 4)
            //{
            //    guolutitle[3] = lb;
            //    if (FindWindow("Tl4", (guolutitle[3]).c_str()) == NULL)
            //    {
            //        l4 = new Tl4(Application);
            //        l4->Show();
            //        l4->Caption = guolutitle[3];
            //    }
            //    else
            //    {
            //        l4->Show();
            //        l4->WindowState = wsNormal;
            //    }
            //}
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除测点位置?
        /// </summary>
        /// <param name="BoilerNo"></param>
        void deletecdwz(int BoilerNo)
        {
            //if (BoilerNo == 1)
            //{
            //    if (FindWindow("Tl1", (guolutitle[0]).c_str()) == NULL)
            //        return;
            //    if (hand_operation[BoilerNo - 1] == true)
            //        return;
            //    delete l1;
            //}
            //if (BoilerNo == 2)
            //{
            //    if (FindWindow("Tl2", (guolutitle[1]).c_str()) == NULL)
            //        return;
            //    if (hand_operation[BoilerNo - 1] == true)
            //        return;
            //    delete l2;
            //}
            //if (BoilerNo == 3)
            //{
            //    if (FindWindow("Tl3", (guolutitle[2]).c_str()) == NULL)
            //        return;
            //    if (hand_operation[BoilerNo - 1] == true)
            //        return;
            //    delete l3;
            //}

            //if (BoilerNo == 4)
            //{
            //    if (FindWindow("Tl4", (guolutitle[3]).c_str()) == NULL)
            //        return;
            //    if (hand_operation[BoilerNo - 1] == true)
            //        return;
            //    delete l4;
            //}

            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: 显示测点位置客户端? 
        /// </summary>
        /// <param name="BoilerNo"></param>
        /// <param name="Low32"></param>
        /// <param name="High32"></param>
        /// <param name="Channelnum"></param>
        /// <param name="lcaption"></param>
        unsafe void Showcdwzclient(int BoilerNo, int Low32, int High32, int Channelnum, char* lcaption)
        {
            //    int Count[MAX_CHANNEL];
            //    int mov = 1;
            //    int lsh = 0;
            //    tongdaoshu[BoilerNo - 1] = Channelnum;
            //    for (int i = 0; i < MAX_CHANNEL; i++)
            //        Count[i] = -1;
            //    for (int i = 0; i < 32; i++)
            //    {
            //        lsh = mov << i;
            //        if (Low32 & lsh)
            //        {
            //            Count[i] = i;
            //        } //end if
            //    } //end for
            //    for (int i = 32; i < Channelnum; i++)
            //    {
            //        lsh = mov << (i - 32);
            //        if (High32 & lsh)
            //        {
            //            Count[i] = i;

            //        }//end if
            //    } //end for
            //    lb = AnsiString(lcaption) + "测点位置图";

            //    if (BoilerNo == 1)
            //    {
            //        guolutitle[0] = lb;
            //        if (FindWindow("Tl1", (guolutitle[0]).c_str()) == NULL)
            //        {

            //            l1 = new Tl1(Application);
            //            //   l1->Init();
            //            hand_operation[BoilerNo - 1] = false;
            //            l1->Show();
            //            l1->Caption = guolutitle[0];

            //        }
            //        else
            //        {

            //            l1->Show();
            //        }

            //        for (int i = 0; i < Channelnum; i++)
            //        {
            //            if (Count[i] == i)
            //                l1->flag_tongdao[i] = 1;
            //            else
            //                l1->flag_tongdao[i] = 0;

            //        }

            //    }

            //    if (BoilerNo == 2)
            //    {
            //        guolutitle[1] = lb;
            //        if (FindWindow("Tl2", (guolutitle[1]).c_str()) == NULL)
            //        {
            //            l2 = new Tl2(Application);
            //            hand_operation[BoilerNo - 1] = false;
            //            l2->Show();
            //            l2->Caption = guolutitle[1];
            //        }
            //        else
            //        {
            //            l2->Show();

            //        }
            //        for (int i = 0; i < Channelnum; i++)
            //        {
            //            if (Count[i] == i)
            //                l2->flag_tongdao[i] = 1;
            //            else
            //                l2->flag_tongdao[i] = 0;
            //        }

            //    }
            //    if (BoilerNo == 3)
            //    {
            //        guolutitle[2] = lb;
            //        if (FindWindow("Tl3", (guolutitle[2]).c_str()) == NULL)
            //        {
            //            l3 = new Tl3(Application);
            //            hand_operation[BoilerNo - 1] = false;
            //            l3->Show();
            //            l3->Caption = guolutitle[2];
            //        }
            //        else
            //        {
            //            l3->Show();
            //        }
            //        for (int i = 0; i < Channelnum; i++)
            //        {
            //            if (Count[i] == i)
            //                l3->flag_tongdao[i] = 1;
            //            else
            //                l3->flag_tongdao[i] = 0;
            //        }

            //    }
            //    if (BoilerNo == 4)
            //    {
            //        guolutitle[3] = lb;
            //        if (FindWindow("Tl4", (guolutitle[3]).c_str()) == NULL)
            //        {
            //            l4 = new Tl4(Application);
            //            hand_operation[BoilerNo - 1] = false;
            //            l4->Show();
            //            l4->Caption = guolutitle[3];

            //        }
            //        else
            //        {
            //            l4->Show();
            //        }
            //        for (int i = 0; i < Channelnum; i++)
            //        {
            //            if (Count[i] == i)
            //                l4->flag_tongdao[i] = 1;
            //            else
            //                l4->flag_tongdao[i] = 0;
            //        }

            //    }
            throw new NotImplementedException();
        }
    }
}
