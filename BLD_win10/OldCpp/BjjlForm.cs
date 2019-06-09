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
    /// 报警记录
    /// </summary>
    public partial class BjjlForm : Form
    {
        private string Fh, Tj, mField;

        public BjjlForm()
        {
            InitializeComponent();
        }

        private void Bjjl_Load(object sender, EventArgs e)
        {
            //SBshch->Enabled = false;
            //SBqk->Enabled = false;
            //Height = 348;
            //ComboBox1->ItemIndex = 0;
            //ComboBox1->OnChange(this);
            //PostMessage(Handle, WM_SHOW, 0, 0);
        }

        private void SBgbClick(object sender, EventArgs e)
        {
            tableclose();
            Close();
        }

        private void tableclose()
        {
            //if (Table1->Active == true)
            //    Table1->Active = false;
        }

        private void FormClose(object sender, EventArgs e)
        {
            tableclose();
        }

        private void SBshchClick(object sender, EventArgs e)
        {
            //if (Table1->RecordCount != 0)
            //    if (Application->MessageBox("确实要删除当前记录吗?", "确认", MB_OKCANCEL) == IDOK)
            //DBNavigator1->BtnClick(nbDelete);
        }

        private void SBqkClick(object sender, EventArgs e)
        {
            //          /*  if ( Application->MessageBox("确实要清空记录表吗?","确认", MB_OKCANCEL) == IDOK)
            //{
            // int n=Table1->RecordCount;
            // DBNavigator1->ConfirmDelete=false;
            // DBNavigator1->BtnClick(nbFirst);
            // for(int i=0;i<n;i++)
            //  DBNavigator1->BtnClick(nbDelete);
            // DBNavigator1->ConfirmDelete=true;
            //}*/
            //          if (Application->MessageBox("确实要清空记录表吗?", "确认", MB_OKCANCEL) == IDOK)
            //          {
            //              Table1->Active = false;
            //              while (1)
            //              {
            //                  try
            //                  {
            //                      Table1->Exclusive = true; // See if it will open
            //                      Table1->Active = true;
            //                      Table1->First();
            //                      Table1->EmptyTable();
            //                      break; //if no error, exit the loop
            //                  }
            //                  catch (EDatabaseError&E)
            //	{
            //                      //Ask if it is OK to retry
            //                      Application->MessageBox("现在还不能清空表格，请稍后再试。", "对不起", MB_OK);
            //                      //If not, throw to abort
            //                      //Otherwise resume the repeat loop
            //                  }
            //                  }
            //                  Table1->Active = false;
            //                  Table1->Exclusive = false;
            //                  Table1->Active = true;
            //              }
            throw new NotImplementedException();

        }

        private void SBqxClick(object sender, EventArgs e)
        {
            //TPasswordDlg* PasswordDlg;
            //PasswordDlg = new TPasswordDlg(this);
            //bool con = true;
            //short x = 7;
            //while (con)
            //{
            //    x = PasswordDlg->ShowPassword();
            //    if (x == 1)//Press ok button and password is right
            //    {
            //        SBshch->Enabled = true;
            //        SBqk->Enabled = true;
            //        SBqx->Enabled = false;
            //        con = false;
            //    }
            //    else if (x == 2)   //press cancel button
            //        con = false;
            //    else        //press ok button but password is wrong
            //    {
            //        if (Application->MessageBox("口令不对，重新输入吗？", NULL, MB_RETRYCANCEL) != IDRETRY)
            //            con = false;
            //    }
            //}
            //delete PasswordDlg;
            throw new NotImplementedException();

        }

        private void SBdyClick(object sender, EventArgs e)
        {
            //            /*
            //    TReport *Report;
            //    Report=new TReport(Application);
            //    if (Report->Table1->Active==true)
            //        Report->Table1->Active=false;
            //    Report->Table1->DatabaseName=MForm->DataMreal->myDatabase->DatabaseName;
            //    Report->Table1->SessionName=MForm->DataMreal->Session1->SessionName;
            //    Report->Table1->Active=true;

            //    if(Report->Table1->RecordCount!=0)
            //       {
            //             Report->Prepare();
            //             Report->Print();
            //       }
            //    else
            //       MessageDlg("对不起，没有报警记录?", mtInformation, TMsgDlgButtons() << mbYes, 0);
            //    Report->CleanupInstance();
            //    Report->Table1->Close();
            //    delete Report;
            //*/
            //            if (Table1->RecordCount != 0)
            //            {
            //                QuickRep1->Print();
            //            }
            //            else
            //                MessageDlg("对不起，没有报警记录?", mtInformation, TMsgDlgButtons() << mbYes, 0);
            throw new NotImplementedException();

        }

        private void SBdyylClick(object sender, EventArgs e)
        {
            //        /*    TReport *Report;
            //Report=new TReport(Application);
            //if (Report->Table1->Active==true)
            //    Report->Table1->Active=false;
            //Report->Table1->DatabaseName=MForm->DataMreal->myDatabase->DatabaseName;
            //Report->Table1->SessionName=MForm->DataMreal->Session1->SessionName;
            //Report->Table1->Active=true;

            //Report->PreviewModal();
            //Report->CleanupInstance();
            //Report->Table1->Close();
            //delete Report;*/
            //QuickRep1->Preview();
            throw new NotImplementedException();

        }

        private void OnmyShow(object sender, EventArgs e)
        {
            //Sleep(1000);
            //Table1->DatabaseName = MForm->DataMreal->myDatabase->DatabaseName;
            //Table1->SessionName = MForm->DataMreal->Session1->SessionName;
            //ComboBox1->ItemIndex = 0;
            //ComboBox2->ItemIndex = 0;
            //ComboBox3->ItemIndex = 0;
            //Fh = "=";
            //Tj = " and ";
            //mField = "chnl";
            //Panel4->Visible = false;
            //if (Table1->Active == false)
            //{
            //    try
            //    {
            //        Table1->Open();
            //        Table1->Last();
            //    }
            //    catch (...)
            // {
            //        ShowMessage("记录表没有打开，请稍后再试。");
            //        Close();
            //    }
            //}
            throw new NotImplementedException();

        }

        private void FormKeyPress(object sender, EventArgs e)
        {
            //if (!Edit1->Focused()) DBGrid1->SetFocus();
            //if (Key == 'V' || Key == 'v') SBgb->OnClick(Sender);//关闭窗口

            //if (Key == 'A' || Key == 'a')
            //{ //上滚条
            //    keybd_event(VK_PRIOR, 0, 0, 0);
            //}

            //if (keysetValue == NULL || keysetValue == "")
            //{
            //    if (Key == 'G' || Key == 'g')
            //    { //下滚条
            //        keybd_event(VK_NEXT, 0, 0, 0);
            //    }
            //}
            //else
            //{
            //    if (Key == 'J' || Key == 'j')
            //    { //下滚条
            //        keybd_event(VK_NEXT, 0, 0, 0);
            //    }

            //}
            throw new NotImplementedException();

        }

        private void ComboBox3Change(object sender, EventArgs e)
        {
            //switch (ComboBox3->ItemIndex)
            //{
            //    case 0: Tj = " and "; break;
            //    case 1: Tj = "  or "; break;
            //}
            throw new NotImplementedException();

        }

        private void CheckBox1Click(object sender, EventArgs e)
        {
            //if (CheckBox1->Checked)
            //{
            //    Panel4->Visible = true;
            //    Height = 428;
            //}
            //else
            //{
            //    Table1->Filtered = false;
            //    Table1->Filter = "";
            //    Table1->Filtered = true;
            //    Panel4->Visible = false;
            //    Height = 348;
            //}
            throw new NotImplementedException();

        }

        private void Button1Click(object sender, EventArgs e)
        {
            //if (Edit1->Text == "")
            //{
            //    ShowMessage("输入的条件不符合要求，不能进行查询。");
            //    Edit1->Text = 0;
            //    return;
            //}
            //TListItem* ListItem = ListView1->Items->Add();
            //ListItem->Caption = mField + Fh + Edit1->Text.Trim() + Tj;
            throw new NotImplementedException();

        }

        private void ComboBox2Change(object sender, EventArgs e)
        {
            //switch (ComboBox2->ItemIndex)
            //{
            //    case 0: Fh = "="; break;
            //    case 1: Fh = ">="; break;
            //    case 2: Fh = ">"; break;
            //    case 3: Fh = "<="; break;
            //    case 4: Fh = "<"; break;
            //    case 5: Fh = "<>"; break;
            //}
            throw new NotImplementedException();

        }

        private void Button2Click(object sender, EventArgs e)
        {
            //AnsiString mTiaojian, temps;
            //for (int i = 0; i < ListView1->Items->Count; i++)
            //{
            //    mTiaojian += ListView1->Items->Item[i]->Caption;
            //}
            //temps = mTiaojian.SubString(mTiaojian.Length(), mTiaojian.Length());
            //if (temps == " ")
            //{
            //    mTiaojian.Delete(mTiaojian.Length() - 4, mTiaojian.Length());
            //}
            //Table1->Filtered = false;
            //Table1->Filter = mTiaojian;
            //Table1->Filtered = true;
            throw new NotImplementedException();
        }

        private void ComboBox1Change(object sender, EventArgs e)
        {
            //switch (ComboBox1->ItemIndex)
            //{
            //    case 0: mField = "chnl"; break;
            //    case 1: mField = "prob"; break;
            //    case 2: mField = "maxvalue"; break;
            //    case 3: mField = "flowtime"; break;
            //}
            throw new NotImplementedException();
        }

        private void Button3Click(object sender, EventArgs e)
        {
            //if (ListView1->Selected) ListView1->Selected->Delete();
            throw new NotImplementedException();
        }

        private void Button4Click(object sender, EventArgs e)
        {
            //ListView1->Items->Clear();
            throw new NotImplementedException();
        }

        private void Edit1KeyPress(object sender, EventArgs e)
        {
            //if (Key < 48 || Key > 57) Key = NULL;
            throw new NotImplementedException();
        }

        private void SpeedButton1Click(object sender, EventArgs e)
        {
            //Table1->Filtered = false;
            //Table1->Close();
            //Table1->Open();
            throw new NotImplementedException();
        }
    }
}
