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
    /// 弃用页面
    /// 编辑曲线组页面。//报警曲线？
    /// </summary>
    public partial class BjqxForm : Form
    {
        bool fh;

        public BjqxForm()
        {

            InitializeComponent();
        }

        private void Bjqxz_Load(object sender, EventArgs e)
        {
            //fh = false;
            throw new NotImplementedException();
        }

        bool MyShow(short x, short[] xx, short gdh)
        {
            //  gdsh=gdh;
            //  for(int i=0;i<gdh;i++)
            //     {
            //       clb->Items->Add(AnsiString(i+1)+"号通道");
            //     }
            //  for(int i=0;i<x;i++)
            //     {
            //       clb->Checked[xx[i]]=true;
            //     }
            //ShowModal();
            //  return fh;
            throw new NotImplementedException();
        }

        void BitBtn2Click(object sender, EventArgs e)
        {
            fh = false;
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BitBtn1Click(object sender, EventArgs e)
        {
            //int x = 0;
            //for (int i = 0; i < gdsh; i++)
            //{
            //if (clb->Checked[i]) x++;
            //}
            //if (x > 4)
            //{
                //ShowMessage("对不起，您选择的曲线不能超过4条！");
                //MessageBox.Show("");
                //return;
            //}
            //fh = true;
            //Close();
        }
    }
}
