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
    /// TCY Form ?
    /// </summary>
    public partial class TcyForm : Form
    {
        public TcyForm()
        {
            InitializeComponent();
        }

        private void TcyForm_Load(object sender, EventArgs e)
        {

        }

        short myshow(short s)
        {
            //TrackBar1->Position = s;
            //this->ShowModal();
            //return fh;
            throw new NotImplementedException();
        }


        void BitBtn1Click(object sender, EventArgs e)
        {
            //fh = TrackBar1->Position;
            Close();
        }


        void BitBtn2Click(object sender, EventArgs e)
        {
            //fh = 0;
        }


        void TrackBar1Change(object sender, EventArgs e)
        {
            //st->Caption = AnsiString(TrackBar1->Position);
        }
    }
}
