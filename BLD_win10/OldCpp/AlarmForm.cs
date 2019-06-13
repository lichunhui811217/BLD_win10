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
    public partial class AlarmForm : Form
    {
        public AlarmForm()
        {
            InitializeComponent();
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            //CheckBox1->Checked = boLeak;
            //RadioGroup1->ItemIndex = By_Alarm;
            //boCheckChannel = true;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            //AnsiString AppPath = ExtractFilePath(Application->ExeName);
            //TIniFile* myPath = new TIniFile(AppPath + "DataPath.INI");
            //AppPath = myPath->ReadString("数据临时存放路径", "DataPath", AppPath);
            //delete myPath;
            //By_Alarm = RadioGroup1->ItemIndex;
            //boLeak = CheckBox1->Checked;
            //TIniFile* Glsys = new TIniFile(AppPath + "glsys.INI");
            //Glsys->WriteInteger("备用报警控制", "StandbyAlarm", By_Alarm);
            //Glsys->WriteBool("备用报警控制", "LeakStandbyAlarm", boLeak);
            //delete Glsys;
            //Close();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBox1Click(object sender, EventArgs e)
        {
            //if (CheckBox1->Checked && RadioGroup1->ItemIndex > 0)
            //    RadioGroup1->ItemIndex = 0;
        }
        private void RadioGroup1Click(object sender, EventArgs e)
        {
            //if (RadioGroup1->ItemIndex > 0)
            //    CheckBox1->Checked = false;
        }
        private void FormClose(object sender, EventArgs e)
        {
            //boCheckChannel = false;
            //CloseJZH(0, MForm->glNum, 0);
        }
        private void Timer1Timer(object sender, EventArgs e)
        {
            Close();
        }
    }
}
