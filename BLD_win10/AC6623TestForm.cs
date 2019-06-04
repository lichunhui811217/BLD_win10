using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

using AC6623SimDll;
using BLD_win10.CaptureData;

namespace BLD_win10
{
    unsafe public partial class AC6623TestForm : Form
    {
        IntPtr hDevice;
        Int32[] addata;
        CaptureDriver captureDriver;
        public AC6623TestForm()
        {
            InitializeComponent();
        }

        private void AC6623TestForm_Load(object sender, EventArgs e)
        {
            foreach(CaptureDriver.EnumDriverName enumDriverName in Enum.GetValues(typeof(CaptureDriver.EnumDriverName)))
            {
                comboBox_ChooseDriver.Items.Add(enumDriverName);
            }

        }

        private void DO_Click(object sender, EventArgs e)
        {
            string str;
            Int32 i;
            str = textBox_do.Text;

            if (str == "")
                i = 0;
            i = Convert.ToInt32(str);
            captureDriver.DO(hDevice, i);
        }

        private void DI_Click(object sender, EventArgs e)
        {
            Int32 i = 0;
            string str;
            i = captureDriver.DI(hDevice);
            str = Convert.ToString(i);
            label_di.Text = str;
        }

        private void button_AD_Click(object sender, EventArgs e)
        {
            //AD(hDevice, 0, 14, 2, 1000);

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string str;

            captureDriver.TAD(hDevice, 0, 14, 2, 0, 0, 0, 0, 0, 0, 100);
            for (int m = 0; m < 1000; m++)
            {
                for (int n = 0; n < 1000; n++)
                {
                    ; ;
                }
            }

            if (captureDriver.TAD_Poll(hDevice) < 0)
            {
                timer1.Enabled = false;
                captureDriver.TAD_Stop(hDevice);
                listBox_ad.Items.Add("ad fifo over!!!");

            }
            else
            {
                if (captureDriver.TAD_Read(hDevice, captureDriver.TAD_Poll(hDevice), addata) == -1)
                    listBox_ad.Items.Add("ad fifo over!!!");
                else
                {
                    listBox_ad.Items.Clear();
                    for (Int16 i = 0; i < 15; i++)
                    {
                        str = Convert.ToString(((addata[i]) - 2048) * 5000 / 2048);//
                        //  int j = str.IndexOf('.');//
                        //      j = j + 3;
                        //    str = str.Substring(0, j);//
                        str = str + " mv";
                        listBox_ad.Items.Add(str);
                    }
                }

            }

            captureDriver.TAD_Stop(hDevice);
        }

        private void button_adstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button_da_Click(object sender, EventArgs e)
        {
            Int32 i;
            string str;
            str = textBox_da.Text;
            //label_di.Text = str;//for test

            i = Convert.ToInt32(str);

            captureDriver.DA(hDevice, 0, i);
        }

        private void button_cnt_Click(object sender, EventArgs e)
        {
            captureDriver.CNT_Run(hDevice, 0, 0);

            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Int32[] cdata;
            Int32[] tdata;
            string str;
            cdata = new Int32[10];
            tdata = new Int32[10];
            captureDriver.CNT_Read(hDevice, 0, cdata, tdata);

            str = Convert.ToString(cdata[0]);
            label_cnt.Text = str;
        }

        private void button_pwm_Click(object sender, EventArgs e)
        {
            captureDriver.PRun(hDevice, 0, 0, 1000, 500);
        }

        private void PWM_END_Click(object sender, EventArgs e)
        {
            captureDriver.PEnd(hDevice, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //captureDriver.PEnd(new IntPtr(), 0);
            int i = captureDriver.DI(new IntPtr());
        }

        private void ComboBox_ChooseDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                captureDriver = new CaptureDriver((CaptureDriver.EnumDriverName)comboBox_ChooseDriver.SelectedItem);

                hDevice = captureDriver.OpenDevice(0);
                captureDriver.CAL(hDevice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            addata = new Int32[600000];

            textBox_do.Text = "0";
            textBox_da.Text = "0";
        }
    }
}
