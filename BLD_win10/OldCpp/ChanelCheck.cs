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
    public partial class ChanelCheck : Form
    {
        public ChanelCheck()
        {
            InitializeComponent();
        }

        private void ChanelCheckForm_Load(object sender, EventArgs e)
        {

        }

        ChanelCheck(
            //TComponent* Owner, 
            short vPipeCount, bool vLeakage, bool vLeakageAlarm, float vGenFactor
            )
        {
            //PipeCount = vPipeCount;
            //LeakageAlarm = vLeakageAlarm;
            //Leakage = vLeakage;
            //System::AnsiString AppPath = ExtractFilePath(Application->ExeName);
            //TIniFile* TDjcParam = new TIniFile(AppPath + "TDjcParam.INI");
            //if (TDjcParam->ReadInteger("采样次数", "AutoTimes", -1) == -1)
            //{
            //    AutoTimes = 6;
            //    ScaleFactor = 12.0;
            //    for (int i = 0; i < PipeCount; i++)
            //        BaseNumber[i] = 0.0;
            //}
            //else
            //{
            //    AutoTimes = TDjcParam->ReadInteger("采样次数", "AutoTimes", AutoTimes);
            //    ScaleFactor = TDjcParam->ReadFloat("放大倍数", "ScaleFactor", ScaleFactor);
            //    for (int i = 0; i < PipeCount; i++)
            //        BaseNumber[i] = TDjcParam->ReadFloat("各通道基数", IntToStr(i + 1) + "号通道", BaseNumber[i]);
            //}
            //delete TDjcParam;
            //ChanelNo = 1;
            //Times = 0;
            //GenFactor = vGenFactor;
            ////ScaleFactor=2.0;
            //Method = true;//自动
            //if ((LeakageAlarm == true) && (Leakage == true)) flag = 0x80;
            //else flag = 0x00;
            //qhkz_lhh = false;//lhh change on 06.2.8
            throw new NotImplementedException();
        }


        void FormCreate(object sender, EventArgs e)
        {
            //TDxz->Max = PipeCount;
            //TDxz->Min = 0;
            //TDxz->LargeChange = 1;
            //TDxz->Visible = false;
            //Label1->Visible = false;
            //tdh->Visible = false;
            //Bttchkbg->Visible = true;
            //for (int i = 0; i< 60; i++)
            //	curData[i] = 0;
            throw new NotImplementedException();

        }


        void RBzdClick(object sender, EventArgs e)
        {
            //CloseJZH(flag, MForm->glNum, PipeCount);
            //   Timer1->Enabled = false;
            //TDxz->Visible = false;
            //Label1->Visible = false;
            //tdh->Visible = false;
            //Bttchkbg->Visible = true;
            //Series1->Clear();
            //   ChanelNo = 1;
            //TDxz->Position = 1;
            //Times = 0;
            //Method = true;
            //for (int i = 0; i< 60; i++)
            //	curData[i] = 0;
            //NotifyEndCheck();
            throw new NotImplementedException();

        }
        //---------------------------------------------------------------------------
        void RBshdClick(object sender, EventArgs e)
        {
            //	TDxz->Visible = true;
            //	Label1->Visible = true;
            //	tdh->Visible = true;
            //	Bttchkbg->Visible = false;
            //	Timer1->Enabled = false;
            //	ChanelNo = 1;
            //	Series1->Clear();
            //Method = false;
            //	for (int i = 0; i< 60; i++)
            //		curData[i] = 0;

            //	tdh->Caption = IntToStr(TDxz->Position);
            ////Ring(flag,ChanelNo,MForm->glNum);
            //CloseJZH(flag, MForm->glNum, PipeCount);
            //qhkz_lhh = true; //lhh change on 06.2.8
            //	Timer1->Enabled = false;
            //	NotifyEndCheck();
            throw new NotImplementedException();

        }


        void TDxzChange(object sender, EventArgs e)
        {

            //tdh->Caption = IntToStr(TDxz->Position);
            throw new NotImplementedException();

        }


        void Timer1Timer(object sender, EventArgs e)
        {
            //	if (Method == true) { //自动
            //		Times++;
            //		if (ChanelNo == 1) {
            //			CloseJZH(flag, MForm->glNum, PipeCount);
            //Ring(flag, ChanelNo, MForm->glNum);
            //		}
            //		if (Times >= AutoTimes) {
            //			ChanelNo++;
            //			CloseJZH(flag, MForm->glNum, PipeCount);
            //Ring(flag, ChanelNo, MForm->glNum);//ChanelNo 从1开始
            //Times = 0;
            //			for (int i = 0; i< 60; i++) curData[i] = 0;
            //		}
            //		for (int i = 0; i<PipeCount; i++) {
            //			if (i == ChanelNo - 1) {
            //				SamplingData(i);
            //data[i] = (curData[16] / 10.0 + BaseNumber[i]);
            //			}
            //			else {
            //				data[i] = 0;
            //			}
            //		}
            //		Series1->Clear();
            //		for (int i = 0; i<PipeCount; i++) Series1->Add(data[i], IntToStr(i + 1), clTeeColor);

            //		if (ChanelNo > PipeCount) {
            //			Timer1->Enabled = false;
            //			CloseJZH(flag, MForm->glNum, PipeCount);
            //		}
            //	}
            //	else { //手动
            //		for (int i = 0; i<PipeCount; i++) {
            //			if (i == ChanelNo - 1) {
            //				SamplingData(i);
            //data[i] = (curData[16] / 10.0 + BaseNumber[i]);
            //			}
            //			else {
            //				data[i] = 0;
            //			}
            //		}
            //		Series1->Clear();
            //		for (int i = 0; i<PipeCount; i++) {
            //			Series1->Add(data[i], IntToStr(i + 1), clTeeColor);
            //		}
            //	}
            //	qhkz_lhh = true; //lhh change on 06.2.8
            throw new NotImplementedException();

        }


        void FormClose(
            //TObject* Sender, TCloseAction& Action
            )
        {
            //NotifyEndCheck();
            ////Close();
            //CloseJZH(flag, MForm->glNum, PipeCount);
            //boCheckChannel = false;
            ////NotifyEndCheck();
            ////Close();
            throw new NotImplementedException();

        }


        void BttchkbgClick(object sender, EventArgs e)
        {
            //Timer1->Enabled = true;
        }

        void TDxzScroll(
            //TObject* Sender,TScrollCode ScrollCode, int& ScrollPos
            )
        {
            //if (Timer1->Enabled == false)
            //{
            //    Timer1->Enabled = true;
            //    NotifyBeginCheck();
            //}
            //ChanelNo = TDxz->Position;
            //for (int i = 0; i < 60; i++)
            //    curData[i] = 0;
            //CloseJZH(flag, MForm->glNum, PipeCount);
            //Ring(flag, ChanelNo, MForm->glNum);
        }

        void FormKeyDown(
            //TObject* Sender, WORD& Key,TShiftState Shift
            )
        {
            //if (Shift.Contains(ssCtrl) && (Shift.Contains(ssAlt)) && (Key == 70))    //Ctrl+Alt+F 打开通道检测参数设置窗口
            //{
            //    float c_baseNumber[MAX_CHANNEL];
            //    for (int i = 0; i < PipeCount; i++)
            //        c_baseNumber[i] = BaseNumber[i] * 10.0;

            //    TOKBottomDlg* OKBottomDlg;
            //    OKBottomDlg = new TOKBottomDlg(this, ScaleFactor * 10.0, AutoTimes, c_baseNumber, PipeCount);
            //    //OKBottomDlg=new TOKBottomDlg(Application,80,AutoTimes);
            //    OKBottomDlg->show(&ScaleFactor, &AutoTimes, BaseNumber);
            //    delete OKBottomDlg;
            //}
        }


        int AverageForChanel()
        {
            //float ss[16], dd[16];
            //       float FAVER;
            //       int j, i, exch;
            //       FAVER = 0.0;
            //for (i = 0; i< 15; i++)
            //	for (j = i + 1; j< 16; j++)
            //		if (curData[i] > curData[j]) {
            //			exch = curData[i];
            //			curData[i] = curData[j];
            //			curData[j] = exch;
            //		}
            //for (i = 3, j = 0; i< 13; i++, j++) ss[j] = (float) curData[i];
            //   kdspt(10, ss, dd);//平滑处理
            //for (i = 0; i< 10; i++) FAVER += dd[i];
            //return (int) (FAVER / 10.0);
            throw new NotImplementedException();
        }


        void SamplingData(int i)
        {
            //int j, ave;
            //int temp;

            ////-------------sampling for each chanel----------------------
            //for (j = 0; j < 16; j++)
            //{
            //    temp = (int)((readInp(i, MForm->glNum) / 50) * ScaleFactor);
            //    curData[j] = (temp > 100 ? 100 : (temp < 0 ? 0 : temp));
            //}
            //ave = AverageForChanel();
            //for (j = 36; j > 16; j--) curData[j] = curData[j - 1];
            //curData[17] = ave;
            //for (j = 36; j > 16; j--)
            //    ave += curData[j];
            //curData[16] = (int)(ave / 20.0);
            //if (curData[16] > 100) curData[16] = 100;
            //if (curData[16] < 0) curData[16] = 0;
        }


        void NotifyBeginCheck()
        {
            //PostMessage(MForm->Handle, BeginCheck, 0, 0);
        }


        void NotifyEndCheck()
        {
            //PostMessage(MForm->Handle, EndCheck, 0, 0);
        }

        void Timer2Timer(object sender, EventArgs e)
        {
            //CloseTime++;
            //if (CloseTime == 20)
            //    Close();
        }


        void Panel2MouseMove(
            //TObject* Sender,TShiftState Shift, int X, int Y
            )
        {
            //CloseTime = 0;
        }


        void FormShow(object sender, EventArgs e)
        {
            //boCheckChannel = true;
        }
    }
}
