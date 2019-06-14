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
    public partial class SystemConfigForm : Form
    {
        public SystemConfigForm()
        {
            InitializeComponent();
        }

        private void SystemConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void zdjjxClick(object sender, EventArgs e)
        {
            //bool radiostate;
            //radiostate = zdjjx->Checked;
            //GroupBox4->Enabled = radiostate;
            //shxzj->Enabled = radiostate;
            //xiaxjsh->Enabled = radiostate;
            //shxzjud->Enabled = radiostate;
            //xiaxjshud->Enabled = radiostate;
            //shjch->Enabled = radiostate;
            //shjchud->Enabled = radiostate;
            //Label8->Enabled = radiostate;
            //Label9->Enabled = radiostate;
            //Label13->Enabled = radiostate;
            //zdjjxbutton->Enabled = radiostate;
        }
        
        private void loadsysparam()
        { 
            /////////锅炉参数////////
            //MForm->DataCenterreal->showParams(&s);
            //bool_xlbj = s.leakagealarm;
            //bool_dhbj = s.blockashalarm;
            //bool_gzhbj = s.faultalarm;
            //bool_tlbj = s.whenbsa;
            //float_llyz = s.vaporfactor;
            //float_zyz = s.genfactor;
            //int_xlbjych = s.updelaytime;
            //int_dhbjych = s.lowdelaytime;
            //int_cyjg = s.samplinginterval;
            //int_sleeptime = s.datacentersleeptime;
            //float_standardtl = s.stopboilerflux;
            ///////通道参数/////
            //MForm->ChanelParamreal->showUpLimitA(float_shangxian);
            //MForm->ChanelParamreal->showLowLimitA(float_xiaxian);
            //for (int i = 0; i < (MForm->GeneralBoiler->showChanelNumber(MForm->glNum)); i++)
            //    float_noise[i] = MForm->ChanelParamreal->showEachChanelNoise(i + 1);
            /////////初始化屏幕////
            //initparam();
        }

        private void initparam()
        {
            /////////////////锅炉参数/////
            //xlbj->Checked = bool_xlbj;
            //dhbj->Checked = bool_dhbj;
            //gzhbj->Checked = bool_gzhbj;
            //tlbj->Checked = bool_tlbj;
            //llyz->Text = FormatFloat("#0.0", float_llyz);
            //zyz->Text = FormatFloat("#0.0", float_zyz);
            //xlychud->Position = int_xlbjych;
            //dhychud->Position = int_dhbjych;
            //cyjgud->Position = int_cyjg;
            //xlych->Text = int_xlbjych;
            //dhych->Text = int_dhbjych;
            //cyjg->Text = int_cyjg;
            /////////通道参数/////////
            //tdh->Text = 1;
            //shx->Text = FormatFloat("#0.0", float_shangxian[0]);
            //xiax->Text = FormatFloat("#0.0", float_xiaxian[0]);
            //jchzy->Text = FormatFloat("#0.0", float_noise[0]);
        }

        private void writesysparam()
        {
            ////////////////变量给值///////
            //bool_xlbj = xlbj->Checked;
            //bool_dhbj = dhbj->Checked;
            //bool_gzhbj = gzhbj->Checked;
            //bool_tlbj = tlbj->Checked;
            //float_llyz = StrToFloat(llyz->Text);
            //float_zyz = StrToFloat(zyz->Text);
            //int_cyjg = StrToInt(cyjg->Text);
            //int_xlbjych = StrToInt(xlych->Text);
            //int_dhbjych = StrToInt(dhych->Text);
            ////////////设置锅炉参数/////

            //s.vaporfactor = float_llyz;
            //s.samplinginterval = int_cyjg;
            //s.updelaytime = int_xlbjych;
            //s.lowdelaytime = int_dhbjych;
            //s.leakagealarm = bool_xlbj;
            //s.blockashalarm = bool_dhbj;
            //s.faultalarm = bool_gzhbj;
            //s.genfactor = float_zyz;
            //s.whenbsa = bool_tlbj;
            //s.datacentersleeptime = int_sleeptime;
            //s.stopboilerflux = float_standardtl;

            ///////////设置各通道参数
            //MForm->ChanelParamreal->setUpLimit(float_shangxian);
            //MForm->ChanelParamreal->setLowLimit(float_xiaxian);
            //MForm->ChanelParamreal->setEachChanelNoise(float_noise);
            //MForm->DataCenterreal->setParam(MForm->ChanelParamreal, &s);
        }

        private void writefileparam()
        {
            //System::AnsiString AppPath1 = ExtractFilePath(Application->ExeName);
            //TIniFile* myPath = new TIniFile(AppPath1 + "DataPath.INI");
            //AnsiString AppPath;
            //AppPath = myPath->ReadString("数据临时存放路径", "DataPath", AppPath);
            //delete myPath;
            //TIniFile* Glsys = new TIniFile(AppPath + "glsys.INI");
            //int bool_temp;
            ////////初始化变量///////
            ///////////写各个炉的参数//////
            //int templh = MForm->glNum;
            //MForm->DataCenter[templh - 1]->showParams(&s);

            //Glsys->WriteFloat(IntToStr(templh) + "总因子", "GeneralFactor", s.genfactor);
            //Glsys->WriteFloat(IntToStr(templh) + "流量因子", "FluxFactor", s.vaporfactor);
            //Glsys->WriteInteger(IntToStr(templh) + "采样间隔", "SamplingInterval", s.samplinginterval);
            //Glsys->WriteInteger(IntToStr(templh) + "泄漏报警延迟时间", "LeakageAlarmDelayTime", s.updelaytime);
            //Glsys->WriteInteger(IntToStr(templh) + "堵灰报警延迟时间", "BlockAshDelayTime", s.lowdelaytime);
            //for (int i = 1; i <= MForm->GeneralBoiler->showChanelNumber(templh); i++)
            //    Glsys->WriteFloat(IntToStr(templh) + "基础噪音因子", IntToStr(i) + "号通道", MForm->ChanelParams[templh - 1]->showEachChanelNoise(i));
            //for (int i = 1; i <= MForm->GeneralBoiler->showChanelNumber(templh); i++)
            //    Glsys->WriteFloat(IntToStr(templh) + "上限", IntToStr(i) + "号通道", MForm->ChanelParams[templh - 1]->showUpLimit(i));
            //for (int i = 1; i <= MForm->GeneralBoiler->showChanelNumber(templh); i++)
            //    Glsys->WriteFloat(IntToStr(templh) + "下限", IntToStr(i) + "号通道", MForm->ChanelParams[templh - 1]->showLowLimit(i));
            //if (s.leakagealarm == true)
            //    bool_temp = 1;
            //else
            //    bool_temp = 0;
            //Glsys->WriteInteger(IntToStr(templh) + "超限报警开关", "AlarmSwitch", bool_temp);
            //if (s.blockashalarm == true)
            //    bool_temp = 1;
            //else
            //    bool_temp = 0;
            //Glsys->WriteInteger(IntToStr(templh) + "堵灰报警开关", "AlarmSwitch", bool_temp);
            //if (s.faultalarm == true)
            //    bool_temp = 1;
            //else
            //    bool_temp = 0;
            //Glsys->WriteInteger(IntToStr(templh) + "故障报警开关", "AlarmSwitch", bool_temp);
            //if (s.whenbsa == true)
            //    bool_temp = 1;
            //else
            //    bool_temp = 0;
            //Glsys->WriteInteger(IntToStr(templh) + "停炉报警开关", "AlarmSwitch", bool_temp);
            //delete Glsys;
        }

        private void okClick(object sender, EventArgs e)
        {
            //if (MessageDlg("你确定要将修改的参数保存吗?", mtConfirmation,
            //  TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)
            //{

            //    if (StrToFloat(shx->Text) < StrToFloat(xiax->Text))
            //    {
            //        ShowMessage("设置上限应大于下限！");
            //        return;
            //    }

            //    ////锅炉参数/////
            //    bool_xlbj = xlbj->Checked;
            //    bool_dhbj = dhbj->Checked;
            //    bool_gzhbj = gzhbj->Checked;
            //    bool_tlbj = tlbj->Checked;
            //    float_llyz = StrToFloat(llyz->Text);
            //    float_zyz = StrToFloat(zyz->Text);
            //    int_xlbjych = StrToInt(xlych->Text);
            //    int_dhbjych = StrToInt(dhych->Text);
            //    int_cyjg = StrToInt(cyjg->Text);
            //    /////通道参数///// i
            //    //////判断通道参数
            //    tzhshxx();
            //    for (int i = 0; i < tdud->Max; i++)
            //        if (bool_valid[i] == true)
            //        {
            //            General_valid = true;
            //            tongdaotishi = tongdaotishi + IntToStr(i + 1) + ",";
            //        }
            //    if ((CheckBox1->Checked == true) && (General_valid == true))
            //    {
            //        for (int i = 0; i < tdud->Max; i++)
            //        {
            //            float_shangxian[i] = float_shangxian[i] - StrToFloat(ttshx->Text);
            //            float_xiaxian[i] = float_xiaxian[i] - StrToFloat(ttxiax->Text);
            //            float_noise[i] = float_noise[i] - StrToFloat(ttnoise->Text);
            //        }
            //    }
            //    if (General_valid == true)
            //    {
            //        ShowMessage("由于您的设置使得某些通道参数值不合法，\n以下几种情况是合法的：\n1. 0<上限<10\n2. 0<下限<10\n3. -10<噪音<10\n4. 下限<上限\n违反上述条件的通道有：\n" + tongdaotishi);
            //        tongdaotishi = "";
            //        General_valid = false;
            //        for (int i = 0; i < tdud->Max; i++)
            //            bool_valid[i] = false;
            //        return;
            //    }
            //    //////////////
            //    writesysparam();
            //    writefileparam();
            //    writelocaltable();
            //    PostMessage(rapidform->Handle, FormRefresh, 0, 0);
            //    if (ylform != NULL) delete ylform;
            //    Close();

            //}
            //else
            //{
            //    if (ylform != NULL) { delete ylform; ylform = NULL; }
            //    return;
            //}
        }

        private void tdudClick(object sender, EventArgs e
            //, TUDBtnType Button
            )
        {
            //shx->Text = FormatFloat("#0.0", float_shangxian[tdud->Position - 1]);
            //xiax->Text = FormatFloat("#0.0", float_xiaxian[tdud->Position - 1]);
            //jchzy->Text = FormatFloat("#0.0", float_noise[tdud->Position - 1]);
        }
        
        private void FormShow(object sender, EventArgs e)
        {
            //int i;
            //i = 0;
            //loadsysparam();
            //systime->Items->Clear();
            //MForm->DataMreal->sysparamtable->Active = true;
            //MForm->DataMreal->sysparamtable->Last();
            //MForm->DataMreal->sysparamtable->Prior();
            //while ((i < 5) && (!MForm->DataMreal->sysparamtable->Bof))
            //{
            //    i++;
            //    systime->Items->Add(DateTimeToStr(MForm->DataMreal->sysparamtable->FieldByName("datet")->AsDateTime));
            //    MForm->DataMreal->sysparamtable->Prior();
            //}
            //MForm->DataMreal->sysparamtable->Close();
            //GroupBox4->Enabled = false;
            //zdjjx->Checked = false;

        }

        private void cancelClick(object sender, EventArgs e)
        {
            //if (ylform != NULL) delete ylform;
            //MForm->DataMreal->sysparamtable->Close();

            //Close();
        }
        
        private void FormCreate(object sender, EventArgs e)
        {
            //tdud->Max = MForm->GeneralBoiler->showChanelNumber(MForm->glNum);
            //for (int i = 0; i < tdud->Max; i++)
            //    bool_valid[i] = false;
            //General_valid = false;
            //tongdaotishi = "";
        }
        
        private void writelocaltable()
        {
            //try
            //{
            //    MForm->DataMreal->sysparamtable->Active = true;
            //    MForm->DataMreal->sysparamtable->Append();
            //    MForm->DataMreal->sysparamtable->FieldByName("datet")->AsDateTime = Now();
            //    MForm->DataMreal->sysparamtable->FieldByName("factor")->AsFloat = float_zyz;
            //    MForm->DataMreal->sysparamtable->FieldByName("interval")->AsInteger = int_cyjg;
            //    MForm->DataMreal->sysparamtable->FieldByName("leakagedelay")->AsInteger = int_xlbjych;
            //    MForm->DataMreal->sysparamtable->FieldByName("blockashdelay")->AsInteger = int_dhbjych;
            //    MForm->DataMreal->sysparamtable->FieldByName("lalarmswitch")->Value = bool_xlbj;
            //    MForm->DataMreal->sysparamtable->FieldByName("balarmswitch")->Value = bool_dhbj;
            //    MForm->DataMreal->sysparamtable->FieldByName("falarmswitch")->Value = bool_gzhbj;
            //    MForm->DataMreal->sysparamtable->FieldByName("tlalarmswitch")->Value = bool_tlbj;
            //    MForm->DataMreal->sysparamtable->FieldByName("airfactor")->AsFloat = float_llyz;
            //    for (int i = 0; i < MForm->GeneralBoiler->showChanelNumber(MForm->glNum); i++)
            //    {
            //        MForm->DataMreal->sysparamtable->FieldByName("noise" + IntToStr(i))->AsFloat = float_noise[i];
            //        MForm->DataMreal->sysparamtable->FieldByName("upp" + IntToStr(i))->AsFloat = float_shangxian[i];
            //        MForm->DataMreal->sysparamtable->FieldByName("low" + IntToStr(i))->AsFloat = float_xiaxian[i];
            //    }
            //    MForm->DataMreal->sysparamtable->Post();
            //    MForm->DataMreal->sysparamtable->Close();
            //}///end try
            //catch (Exception ex)
            //{
            //    ShowMessage("写数据库参数错误！");
            //    Application->Terminate();
            //}
        }

        private void systimeChange(object sender, EventArgs e)
        {
            //if (systime->ItemIndex == -1) return;
            //MForm->DataMreal->sysparamtable->Active = true;
            //MForm->DataMreal->sysparamtable->Last();
            //MForm->DataMreal->sysparamtable->Prior();

            //MForm->DataMreal->sysparamtable->MoveBy(-systime->ItemIndex);
            //float_zyz = MForm->DataMreal->sysparamtable->FieldByName("factor")->AsFloat;
            //int_cyjg = MForm->DataMreal->sysparamtable->FieldByName("interval")->AsInteger;
            //int_xlbjych = MForm->DataMreal->sysparamtable->FieldByName("leakagedelay")->AsInteger;
            //int_dhbjych = MForm->DataMreal->sysparamtable->FieldByName("blockashdelay")->AsInteger;
            //bool_xlbj = MForm->DataMreal->sysparamtable->FieldByName("lalarmswitch")->Value;
            //bool_dhbj = MForm->DataMreal->sysparamtable->FieldByName("balarmswitch")->Value;
            //bool_gzhbj = MForm->DataMreal->sysparamtable->FieldByName("falarmswitch")->Value;
            //bool_tlbj = MForm->DataMreal->sysparamtable->FieldByName("tlalarmswitch")->Value;
            //float_llyz = MForm->DataMreal->sysparamtable->FieldByName("airfactor")->AsFloat;
            //for (int i = 0; i < MForm->GeneralBoiler->showChanelNumber(MForm->glNum); i++)
            //{
            //    float_noise[i] = MForm->DataMreal->sysparamtable->FieldByName("noise" + IntToStr(i))->AsFloat;
            //    float_shangxian[i] = MForm->DataMreal->sysparamtable->FieldByName("upp" + IntToStr(i))->AsFloat;
            //    float_xiaxian[i] = MForm->DataMreal->sysparamtable->FieldByName("low" + IntToStr(i))->AsFloat;
            //}
            //initparam();
        }
        
        private bool autocreatealarm()
        {
            //__int64 datasum[MAX_CHANNEL];////存放各个通道的和
            //float dataavg[MAX_CHANNEL];
            //for (int i = 0; i < (MForm->GeneralBoiler->showChanelNumber(MForm->glNum)); i++)
            //    datasum[i] = 0;

            //if (MessageDlg("程序将自动生成警戒线,要继续吗?", mtConfirmation,
            //   TMsgDlgButtons() << mbYes << mbNo, 0) == mrYes)
            //{
            //    MForm->DataMreal->autojjxtable->Active = true;
            //    MForm->DataMreal->autojjxtable->Last();
            //    if ((MForm->DataMreal->autojjxtable->RecordCount < (shjchud->Position * 60)) && (MForm->DataMreal->autojjxtable->RecordCount >= 0))
            //    {
            //        MessageBox(Handle, "数据不够,无法继续.请以后再试.", "错误", MB_OK | MB_ICONSTOP);
            //        return false;
            //    }
            //    MForm->DataMreal->autojjxtable->MoveBy(-shjchud->Position * 60);
            //    for (int recordnumber = 0; recordnumber < (shjchud->Position * 60); recordnumber++)
            //    {
            //        for (int i = 0; i < (MForm->GeneralBoiler->showChanelNumber(MForm->glNum)); i++)
            //            datasum[i] = datasum[i] + MForm->DataMreal->autojjxtable->FieldByName("Data" + IntToStr(i))->AsInteger;
            //        MForm->DataMreal->autojjxtable->Next();
            //    }
            //    for (int i = 0; i < (MForm->GeneralBoiler->showChanelNumber(MForm->glNum)); i++)
            //        dataavg[i] = datasum[i] / (shjchud->Position * 600);

            //    for (int i = 0; i < (MForm->GeneralBoiler->showChanelNumber(MForm->glNum)); i++)
            //        float_shangxian[i] = dataavg[i] + StrToFloat(shxzj->Text);
            //    for (int i = 0; i < (MForm->GeneralBoiler->showChanelNumber(MForm->glNum)); i++)
            //        float_xiaxian[i] = dataavg[i] - StrToFloat(xiaxjsh->Text);
            //    //////////////上下限处理语句///////////

            //}
            //else
            //{
            //    return false;
            //}//end if messgedlg
            //return true;
            throw new NotImplementedException();
        } 

        private void zdjjxbuttonClick(object sender, EventArgs e)
        {
            autocreatealarm();
            initparam();
        }

        void ylshxxClick(object sender, EventArgs e)
        {

            //ylform = new Tylform(this);
            //ylform->Show();

        }

        void CheckBox1Click(object sender, EventArgs e)
        {
            //GroupBox6->Enabled = CheckBox1->Checked;
            //ttshx->Enabled = CheckBox1->Checked;
            //ttshxud->Enabled = CheckBox1->Checked;
            //ttxiax->Enabled = CheckBox1->Checked;
            //ttxiaxud->Enabled = CheckBox1->Checked;
            //ttnoise->Enabled = CheckBox1->Checked;
            //ttnoiseud->Enabled = CheckBox1->Checked;
            //Label15->Enabled = CheckBox1->Checked;
            //Label16->Enabled = CheckBox1->Checked;
            //Label17->Enabled = CheckBox1->Checked;
        }

        void tzhshxx()
        {
            //for (int i = 0; i < (MForm->GeneralBoiler->showChanelNumber(MForm->glNum)); i++)
            //{

            //    if (CheckBox1->Checked == true)
            //    {
            //        float_shangxian[i] = float_shangxian[i] + StrToFloat(ttshx->Text);
            //        float_xiaxian[i] = float_xiaxian[i] + StrToFloat(ttxiax->Text);
            //        float_noise[i] = float_noise[i] + StrToFloat(ttnoise->Text);
            //    }
            //    if (float_shangxian[i] >= 10)
            //    {
            //        bool_valid[i] = true;
            //    }
            //    if (float_shangxian[i] <= 0)
            //    {
            //        bool_valid[i] = true;
            //    }
            //    if (float_xiaxian[i] <= 0)
            //    {
            //        bool_valid[i] = true;
            //    }
            //    if (float_xiaxian[i] >= 10)
            //    {
            //        bool_valid[i] = true;
            //    }
            //    if (float_noise[i] <= -10)
            //    {
            //        bool_valid[i] = true;
            //    }
            //    if (float_noise[i] >= 10)
            //    {
            //        bool_valid[i] = true;

            //    }
            //    if (float_shangxian[i] <= float_xiaxian[i])
            //    {
            //        bool_valid[i] = true;
            //    }

            //}
        }

        void xlychKeyPress(object sender, EventArgs e
            //, char &Key
            )
        {
            //if ((Key < '0' || Key > '9') && (int)Key != 8 && (int)Key != 13) Key = NULL;
            //if (Key == 13)
            //{
            //    shx->Text = FormatFloat("#0.0", float_shangxian[tdud->Position - 1]);
            //    xiax->Text = FormatFloat("#0.0", float_xiaxian[tdud->Position - 1]);
            //    jchzy->Text = FormatFloat("#0.0", float_noise[tdud->Position - 1]);
            //}
        }

        void xlychExit(object sender, EventArgs e)
        {
            //int shangxian, xiaxian;
            //switch (dynamic_cast<TEdit*>(Sender)->Tag)
            //{
            //    case 0:
            //        shangxian = 960;
            //        xiaxian = 1;
            //        break;
            //    case 1:
            //        shangxian = 960;
            //        xiaxian = 1;
            //        break;
            //    case 4:
            //        shangxian = 600;
            //        xiaxian = 5;
            //        break;
            //    case 5:
            //        shangxian = tdud->Max;
            //        xiaxian = 1;
            //        break;
            //    case 11:
            //        shangxian = 72;
            //        xiaxian = 1;
            //        break;
            //}
            //try
            //{
            //    if (dynamic_cast<TEdit*>(Sender)->Text.IsEmpty() /*||dynamic_cast <TEdit *>(Sender)->Text.SubString(1,1)=="0"*/)
            //    {
            //        ShowMessage("请输入合理的数值!");
            //        dynamic_cast<TEdit*>(Sender)->SetFocus();
            //        return;
            //    }
            //    else if (StrToInt(dynamic_cast<TEdit*>(Sender)->Text) > shangxian || StrToInt(dynamic_cast<TEdit*>(Sender)->Text) < xiaxian)
            //    {
            //        ShowMessage("输入的范围应在" + IntToStr(xiaxian) + "～" + IntToStr(shangxian) + "之间!");
            //        dynamic_cast<TEdit*>(Sender)->SetFocus();
            //        return;
            //    }
            //    if (dynamic_cast<TEdit*>(Sender)->Tag == 5)
            //    {
            //        shx->Text = FormatFloat("#0.0", float_shangxian[tdud->Position - 1]);
            //        xiax->Text = FormatFloat("#0.0", float_xiaxian[tdud->Position - 1]);
            //        jchzy->Text = FormatFloat("#0.0", float_noise[tdud->Position - 1]);
            //    }
            //}
            //catch (Exception ex){ ShowMessage("请输入合理的数值!"); dynamic_cast<TEdit*>(Sender)->SetFocus(); }
        }

        void llyzKeyPress(object sender, EventArgs e
            //, char &Key
            )
        {
            //if ((Key < '0' || Key > '9') && (int)Key != 8 && (int)Key != 13 && (int)Key != 46) Key = NULL;
        }

        void llyzExit(object sender, EventArgs e)
        {
            //int pos = 0;
            //String jiequ = dynamic_cast<TEdit*>(Sender)->Text;
            //for (int i = 0; i <= 1; i++)
            //{
            //    pos = jiequ.Pos(".");
            //    if (i == 0)
            //    {
            //        if (pos == 1)
            //        {
            //            ShowMessage("请输入合理的数值!");
            //            dynamic_cast<TEdit*>(Sender)->SetFocus();
            //            return;
            //        }
            //    }
            //    if (pos != 0)
            //    {
            //        jiequ = jiequ.Delete(1, pos);
            //        if (i == 1)
            //        {
            //            ShowMessage("请输入合理的数值!");
            //            dynamic_cast<TEdit*>(Sender)->SetFocus();
            //            return;
            //        }
            //    }
            //    else break;
            //}
            //int shangxian = 10, xiaxian = 0;
            //switch (dynamic_cast<TEdit*>(Sender)->Tag)
            //{
            //    case 2:
            //        shangxian = 10;
            //        xiaxian = 0;
            //        break;
            //    case 3:
            //        shangxian = 100;
            //        xiaxian = 0;
            //        break;
            //    case 6:
            //        shangxian = 10;
            //        xiaxian = 0;
            //        break;
            //    case 7:
            //        shangxian = 10;
            //        xiaxian = 0;
            //        break;
            //    case 8:
            //        shangxian = 10;
            //        xiaxian = -10;
            //        break;
            //    case 9:
            //        shangxian = 10;
            //        xiaxian = 0;
            //        break;
            //    case 10:
            //        shangxian = 10;
            //        xiaxian = 0;
            //        break;
            //    case 12:
            //        shangxian = 5;
            //        xiaxian = -5;
            //        break;
            //    case 13:
            //        shangxian = 5;
            //        xiaxian = -5;
            //        break;
            //    case 14:
            //        shangxian = 5;
            //        xiaxian = -5;
            //        break;
            //}
            //if (dynamic_cast<TEdit*>(Sender)->Text.IsEmpty())
            //{
            //    ShowMessage("请输入合理的数值!");
            //    dynamic_cast<TEdit*>(Sender)->SetFocus();
            //}
            //else if (StrToFloat(dynamic_cast<TEdit*>(Sender)->Text) > shangxian || StrToFloat(dynamic_cast<TEdit*>(Sender)->Text) < xiaxian)
            //{
            //    ShowMessage("输入的范围应在" + IntToStr(xiaxian) + "～" + IntToStr(shangxian) + "之间!");
            //    dynamic_cast<TEdit*>(Sender)->SetFocus();
            //}
        }

        void llyzudDownClick(object sender, EventArgs e)
        {
            //    if (llyz->Text == "")
            //    {
            //        ShowMessage("请输入合理的数值!");
            //        return;
            //    }
            //    try
            //    {
            //        llyz->Text = FormatFloat("#0.0", StrToFloat(llyz->Text) - 0.1);
            //        if (StrToFloat(llyz->Text) <= 0.000001 && StrToFloat(llyz->Text) >= 0.0) { llyz->Text = "0"; }
            //    }
            //    catch (Exception ex){
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }

        void llyzudUpClick(object sender, EventArgs e)
        {
            //if (llyz->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    llyz->Text = FormatFloat("#0.0", StrToFloat(llyz->Text) + 0.1);
            //    if (StrToFloat(llyz->Text) <= 0.000001 && StrToFloat(llyz->Text) >= 0.0) { llyz->Text = "0"; }

            //}
            //catch (Exception ex){
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }

        void zyzudDownClick(object sender, EventArgs e)
        {
            //    if (zyz->Text == "")
            //    {
            //        ShowMessage("请输入合理的数值!");
            //        return;
            //    }
            //    try
            //    {
            //        zyz->Text = FormatFloat("#0.0", StrToFloat(zyz->Text) - 0.1);
            //        if (StrToFloat(zyz->Text) <= 0.000001 && StrToFloat(zyz->Text) >= 0.0) { zyz->Text = "0"; }

            //    }
            //    catch (Exception ex){
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }

        void zyzudUpClick(object sender, EventArgs e)
        {
            //if (zyz->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    zyz->Text = FormatFloat("#0.0", StrToFloat(zyz->Text) + 0.1);
            //    if (StrToFloat(zyz->Text) <= 0.000001 && StrToFloat(zyz->Text) >= 0.0) { zyz->Text = "0"; }

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }

        void shxzjudDownClick(object sender, EventArgs e)
        {
            //if (shxzj->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    shxzj->Text = FormatFloat("#0.0", StrToFloat(shxzj->Text) - 0.1);
            //    if (StrToFloat(shxzj->Text) <= 0.000001 && StrToFloat(shxzj->Text) >= 0.0) { shxzj->Text = "0"; }

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }

        void shxzjudUpClick(object sender, EventArgs e)
        {
            //if (shxzj->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    shxzj->Text = FormatFloat("#0.0", StrToFloat(shxzj->Text) + 0.1);
            //    if (StrToFloat(shxzj->Text) <= 0.000001 && StrToFloat(shxzj->Text) >= 0.0) { shxzj->Text = "0"; }
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }

        void xiaxjshudDownClick(object sender, EventArgs e)
        {
            //if (xiaxjsh->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    xiaxjsh->Text = FormatFloat("#0.0", StrToFloat(xiaxjsh->Text) - 0.1);
            //    if (StrToFloat(xiaxjsh->Text) <= 0.000001 && StrToFloat(xiaxjsh->Text) >= 0.0) { xiaxjsh->Text = "0"; }

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }

        void xiaxjshudUpClick(object sender, EventArgs e)
        {
            //if (xiaxjsh->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    xiaxjsh->Text = FormatFloat("#0.0", StrToFloat(xiaxjsh->Text) + 0.1);
            //    if (StrToFloat(xiaxjsh->Text) <= 0.000001 && StrToFloat(xiaxjsh->Text) >= 0.0) { xiaxjsh->Text = "0"; }
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }

        void jchzyudDownClick(object sender, EventArgs e)
        {
            //if (jchzy->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    jchzy->Text = FormatFloat("#0.0", StrToFloat(jchzy->Text) - 0.1);
            //    if (StrToFloat(jchzy->Text) <= 0.000001 && StrToFloat(jchzy->Text) >= 0.0) { jchzy->Text = "0"; }
            //    float_noise[tdud->Position - 1] = StrToFloat(jchzy->Text);
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void ttshxudDownClick(object sender, EventArgs e)
        {
            //if (ttshx->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    ttshx->Text = FormatFloat("#0.0", StrToFloat(ttshx->Text) - 0.1);
            //    if (StrToFloat(ttshx->Text) <= 0.000001 && StrToFloat(ttshx->Text) >= 0.0) { ttshx->Text = "0"; }

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void ttshxudUpClick(object sender, EventArgs e)
        {
            //if (ttshx->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    ttshx->Text = FormatFloat("#0.0", StrToFloat(ttshx->Text) + 0.1);
            //    if (StrToFloat(ttshx->Text) <= 0.000001 && StrToFloat(ttshx->Text) >= 0.0) { ttshx->Text = "0"; }

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void ttxiaxudDownClick(object sender, EventArgs e)
        {
            //if (ttxiax->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    ttxiax->Text = FormatFloat("#0.0", StrToFloat(ttxiax->Text) - 0.1);
            //    if (StrToFloat(ttxiax->Text) <= 0.000001 && StrToFloat(ttxiax->Text) >= 0.0) { ttxiax->Text = "0"; }

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void ttxiaxudUpClick(object sender, EventArgs e)
        {
            //if (ttxiax->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    ttxiax->Text = FormatFloat("#0.0", StrToFloat(ttxiax->Text) + 0.1);
            //    if (StrToFloat(ttxiax->Text) <= 0.000001 && StrToFloat(ttxiax->Text) >= 0.0) { ttxiax->Text = "0"; }

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void ttnoiseudDownClick(object sender, EventArgs e)
        {
            //if (ttnoise->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    ttnoise->Text = FormatFloat("#0.0", StrToFloat(ttnoise->Text) - 0.1);
            //    if (StrToFloat(ttnoise->Text) <= 0.000001 && StrToFloat(ttnoise->Text) >= 0.0) { ttnoise->Text = "0"; }

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void ttnoiseudUpClick(object sender, EventArgs e)
        {
            //if (ttnoise->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    ttnoise->Text = FormatFloat("#0.0", StrToFloat(ttnoise->Text) + 0.1);
            //    if (StrToFloat(ttnoise->Text) <= 0.000001 && StrToFloat(ttnoise->Text) >= 0.0) { ttnoise->Text = "0"; }
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void shxudDownClick(object sender, EventArgs e)
        {
            //if (shx->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    shx->Text = FormatFloat("#0.0", StrToFloat(shx->Text) - 0.1);
            //    if (StrToFloat(shx->Text) <= 0.000001 && StrToFloat(shx->Text) >= 0.0) { shx->Text = "0"; }
            //    float_shangxian[tdud->Position - 1] = StrToFloat(shx->Text);

            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void shxudUpClick(object sender, EventArgs e)
        {
            //if (shx->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    shx->Text = FormatFloat("#0.0", StrToFloat(shx->Text) + 0.1);
            //    if (StrToFloat(shx->Text) <= 0.000001 && StrToFloat(shx->Text) >= 0.0) { shx->Text = "0"; }
            //    float_shangxian[tdud->Position - 1] = StrToFloat(shx->Text);
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void xiaxudDownClick(object sender, EventArgs e)
        {
            //if (xiax->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    xiax->Text = FormatFloat("#0.0", StrToFloat(xiax->Text) - 0.1);
            //    if (StrToFloat(xiax->Text) <= 0.000001 && StrToFloat(xiax->Text) >= 0.0) { xiax->Text = "0"; }
            //    float_xiaxian[tdud->Position - 1] = StrToFloat(xiax->Text);
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}

        }
        
        void xiaxudUpClick(object sender, EventArgs e)
        {
            //if (xiax->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    xiax->Text = FormatFloat("#0.0", StrToFloat(xiax->Text) + 0.1);
            //    if (StrToFloat(xiax->Text) <= 0.000001 && StrToFloat(xiax->Text) >= 0.0) { xiax->Text = "0"; }
            //    float_xiaxian[tdud->Position - 1] = StrToFloat(xiax->Text);
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void shxKeyUp(object sender, EventArgs e
            //,WORD &Key, TShiftState Shift
            )
        {
            //try
            //{
            //    if (shx->Text == "")
            //    {
            //        ShowMessage("请输入合理的数值!");
            //        return;
            //    }
            //    float_shangxian[tdud->Position - 1] = StrToFloat(shx->Text);
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void xiaxKeyUp(object sender, EventArgs e
            //,WORD &Key,TShiftState Shift
            )
        {
            //try
            //{
            //    if (xiax->Text == "")
            //    {
            //        ShowMessage("请输入合理的数值!");
            //        return;
            //    }
            //    float_xiaxian[tdud->Position - 1] = StrToFloat(xiax->Text);
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void jchzyKeyUp(object sender, EventArgs e
            //,WORD &Key,TShiftState Shift
            )
        {
            //try
            //{
            //    if (jchzy->Text == "")
            //    {
            //        ShowMessage("请输入合理的数值!");
            //        return;
            //    }
            //    float_noise[tdud->Position - 1] = StrToFloat(jchzy->Text);
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
        }
        
        void jchzyudUpClick(object sender, EventArgs e)
        {
            //if (jchzy->Text == "")
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}
            //try
            //{
            //    jchzy->Text = FormatFloat("#0.0", StrToFloat(jchzy->Text) + 0.1);
            //    if (StrToFloat(jchzy->Text) <= 0.000001 && StrToFloat(jchzy->Text) >= 0.0) { jchzy->Text = "0"; }
            //    float_noise[tdud->Position - 1] = StrToFloat(jchzy->Text);
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage("请输入合理的数值!");
            //    return;
            //}

        }
    }
}
