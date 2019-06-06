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
    public partial class aboutunit : Form
    {
        public aboutunit()
        {
            InitializeComponent();
        }

        private void Aboutunit_Load(object sender, EventArgs e)
        {

        }

        private void OKButtonClick(object sender, EventArgs e)
        {
            Close();
        }


        private void StaticText1Click(object sender, EventArgs e)
        {
            //OleContainer1->DoVerb(ovShow);
            //StaticText1->SetFocus();
        }
    }
}
