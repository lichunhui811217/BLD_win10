using BLD_win10.Device;
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
    public partial class ObservationMapForm : Form
    {
        public ObservationMapForm()
        {
            InitializeComponent();

        }

        List<PictureBox> listPictureBoxes;
        private void ObservationMapForm_Load(object sender, EventArgs e)
        {

            //Image pic = Image.fr.FromFile(@"");//strFilePath是该图片的绝对路径
            //int intWidth = pic.Width;//长度像素值
            //int intHeight = pic.Height;//高度像素值  
            this.ClientSize = new Size(this.BackgroundImage.Width + 10, this.BackgroundImage.Height + 10);



            foreach (Sensor aSensor in DevicesDataCenter.allSensorsList)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Lime;
                pictureBox.Left = aSensor.MapLeft;
                pictureBox.Top = aSensor.MapTop;
                //pictureBox.Location = new Point(aSensor.MapLeft, aSensor.MapTop);
                pictureBox.Name = "pictureBox_" + aSensor.SensorID.ToString();
                pictureBox.Size = new Size(16, 16);
                //listPictureBoxes.Add(pictureBox);

                this.Controls.Add(pictureBox);
            }

        }

        private bool ColorController = true;
        private Color PointColor = Color.Silver;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ColorController = !ColorController;
            if (ColorController)
            {
                PointColor = Color.Red;
            }
            else
            {
                PointColor = Color.Yellow;
            }

            //添加PictureBox控件,作为颜色显示框
            this.SuspendLayout();

            
            foreach (Sensor aSensor in DevicesDataCenter.allSensorsList)
            {
                if (this.Controls.Find("pictureBox_" + aSensor.SensorID.ToString(), false) != null)
                {
                    PictureBox o =(PictureBox) this.Controls.Find("pictureBox_" + aSensor.SensorID.ToString(), false)[0];
                    o.BackColor = aSensor.Color;
                }
            }

            this.ResumeLayout();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
