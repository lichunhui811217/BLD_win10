using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLD_win10.AppForms
{
    /// <summary>
    /// 测点位置地图
    /// </summary>
    public partial class ObservationMapForm: Form
    {
        public ObservationMapForm()
        {
            InitializeComponent();
        }

        private void ObservationMapForm_Load(object sender, EventArgs e)
        {
            //Image pic = Image.fr.FromFile(@"");//strFilePath是该图片的绝对路径
            //int intWidth = pic.Width;//长度像素值
            //int intHeight = pic.Height;//高度像素值  
            this.ClientSize = new Size(this.BackgroundImage.Width + 10, this.BackgroundImage.Height + 10);
        }

        private bool ColorController = true;
        private Color PointColor = Color.Silver;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //this.BackColor = Color.Silver;
            ColorController = !ColorController;
            if(ColorController)
            {
                PointColor = Color.Red;
            }
            else
            {
                PointColor = Color.Green;
            }

            label_Sensor_27.BackColor = PointColor;
        }
    }
}
