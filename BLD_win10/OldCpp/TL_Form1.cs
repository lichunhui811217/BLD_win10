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
    public partial class TL_Form1 : Form
    {
        //Tl1* l1;
        //extern int tongdaoshu[4];
        //        private:	// User declarations
        //	void __fastcall chuli(AnsiString temp, int n);
        //        int locationnum;
        //        int qiemianshu;
        //        //	TImage* image[50];
        //        //	TImage* imageline[20];
        //        //	int cx[50];
        //        //	int cy[50];
        //        //	int mx[20];
        //        //	int my[20];
        //        //	Tpingmian aa[20];
        //        //	int x[50];
        //        //	int y[50];
        //        TImage* image[MAX_CHANNEL];
        //        TImage* imageline[MAX_CHANNEL / 2];
        //        int cx[MAX_CHANNEL];
        //        int cy[MAX_CHANNEL];
        //        int mx[MAX_CHANNEL / 2];
        //        int my[MAX_CHANNEL / 2];
        //        Tpingmian aa[MAX_CHANNEL / 2];
        //        int x[MAX_CHANNEL];
        //        int y[MAX_CHANNEL];

        //        AnsiString AppPath;
        //        //    void __fastcall refreshstate();
        //        public:		// User declarations
        ////	  int flag_tongdao[50];
        ////	  int old_flag[50];
        //	int flag_tongdao[MAX_CHANNEL];
        //        int old_flag[MAX_CHANNEL];

        //        void __fastcall Init();
        //        __fastcall Tl1(TComponent* Owner);

        public TL_Form1()
        {
            InitializeComponent();
            //Init();
        }


        private void TL_Form1_Load(object sender, EventArgs e)
        {
            ////  for(int i=0;i<50;i++)
            //for (int i = 0; i < MAX_CHANNEL; i++)
            //{
            //    x[i] = 2;
            //    y[i] = 2;
            //}
            //AppPath = ExtractFilePath(Application->ExeName);
            //Init();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        void Init()
        {
            //for (int i = 0; i < tongdaoshu[0]; i++)
            //{
            //    old_flag[i] = 0;
            //}
            //AnsiString temp;
            //AnsiString getstring;
            //int pos;
            ////取背景图片
            //Tpingmian bb;

            //TIniFile* cdwzini = new TIniFile(AppPath + "cdwz1.INI");
            //AnsiString backimagefile = cdwzini->ReadString("背景图片", "bgimage", "");
            //Image1->Picture->LoadFromFile(AppPath + backimagefile);
            ////取其它参数
            //locationnum = cdwzini->ReadInteger("测点数", "locationnum", 0);
            //qiemianshu = cdwzini->ReadInteger("切面数", "qiemianshu", 0);
            //for (int i = 0; i < locationnum; i++)
            //{
            //    getstring = cdwzini->ReadString("测点位置坐标", "c" + IntToStr(i + 1), 0);
            //    pos = AnsiPos(",", getstring);
            //    cx[i] = StrToInt(getstring.SubString(1, pos - 1));
            //    cy[i] = StrToInt(getstring.SubString(pos + 1, getstring.Length()));
            //    //cx[i]=cdwzini->ReadInteger("测点位置坐标","cx"+IntToStr(i+1),0);
            //    //cy[i]=cdwzini->ReadInteger("测点位置坐标","cy"+IntToStr(i+1),0);
            //    image[i] = new TImage(this);
            //    image[i]->Parent = this;
            //    image[i]->AutoSize = true;

            //    image[i]->Picture->LoadFromFile(AppPath + "image\\cwt3.bmp");
            //    image[i]->Transparent = true;
            //    image[i]->Left = cx[i] + Image1->Left - 3;
            //    image[i]->Top = cy[i] + Image1->Top - 2;
            //}
            //for (int j = 0; j < qiemianshu; j++)
            //{
            //    getstring = cdwzini->ReadString("切线位置坐标", "xy" + IntToStr(j + 1), 0);
            //    pos = AnsiPos(",", getstring);
            //    mx[j] = StrToInt(getstring.SubString(1, pos - 1));
            //    my[j] = StrToInt(getstring.SubString(pos + 1, getstring.Length()));
            //    //mx[j]=cdwzini->ReadInteger("切线位置坐标","x"+IntToStr(j+1),0);
            //    //my[j]=cdwzini->ReadInteger("切线位置坐标","y"+IntToStr(j+1),0);
            //    imageline[j] = new TImage(this);
            //    imageline[j]->Parent = this;
            //    imageline[j]->AutoSize = true;

            //    imageline[j]->Picture->LoadFromFile(AppPath + "image\\warningline.bmp");

            //    imageline[j]->Left = mx[j];
            //    imageline[j]->Top = my[j];
            //    imageline[j]->Visible = true;
            //    temp = cdwzini->ReadString("每个切面包括的测点", "m" + IntToStr(j + 1), 0);
            //    chuli(temp, j);
            //}
            //delete cdwzini;

            throw new NotImplementedException();
        }


        void Timer1Timer(object sender, EventArgs e)
        {
            //bool IsWarningline[20];

            /////初始化是否画警戒线变量
            //for (int i = 0; i < 20; i++) IsWarningline[i] = false;
            //for (int i = 0; i < tongdaoshu[0]; i++)
            //{
            //    if (flag_tongdao[i] == 1)
            //    {
            //        for (int j = 0; j < qiemianshu; j++)
            //        {
            //            if (aa[j].Contains(i + 1))
            //            {
            //                IsWarningline[j] = true;
            //            }
            //        }
            //        old_flag[i] = 1;
            //        if (y[i] == 1)
            //        {
            //            image[i]->Picture->LoadFromFile(AppPath + "image\\cwt1.bmp");
            //        }
            //        if (y[i] == 2)
            //        {
            //            image[i]->Picture->LoadFromFile(AppPath + "image\\cwt3.bmp");
            //        }
            //        y[i] = (y[i] == 1 ? 2 : 1);
            //    }
            //    else
            //    {
            //        if (old_flag[i] == 1) image[i]->Picture->LoadFromFile(AppPath + "image\\cwt3.bmp");
            //        old_flag[i] = 0;
            //    }
            //}
            //for (int i = 0; i < qiemianshu; i++)
            //{
            //    if (IsWarningline[i] == true)
            //    {
            //        imageline[i]->Visible = true;
            //        if (x[i] == 1)
            //        {
            //            imageline[i]->Picture->LoadFromFile(AppPath + "image\\warningline.bmp");
            //        }
            //        if (x[i] == 2)
            //        {
            //            imageline[i]->Picture->LoadFromFile(AppPath + "image\\nowarningline.bmp");
            //        }
            //        x[i] = (x[i] == 1 ? 2 : 1);
            //        //imageline[i]->Picture->LoadFromFile("image\\warningline.bmp");
            //    }
            //    else
            //    {
            //        imageline[i]->Visible = false;
            //    }
            //}
            throw new NotImplementedException();
        }


        void chuli(string temp, int n)
        {
            //Tpingmian t1;
            //int weizhi;
            //weizhi = AnsiPos(",", temp);

            //if (weizhi == 0)
            //{
            //    t1 << StrToInt(temp);
            //    aa[n] = aa[n] + t1;
            //    return;
            //}
            //else
            //{
            //    t1 << StrToInt(temp.SubString(1, weizhi - 1));
            //    aa[n] = aa[n] + t1;

            //    temp = temp.SubString(weizhi + 1, temp.Length());
            //    chuli(temp, n);
            //}
            throw new NotImplementedException();
        }
    }
}
