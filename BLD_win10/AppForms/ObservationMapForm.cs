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

        private void ObservationMapForm_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            tabControl1.Controls.Clear();
            foreach(Boiler boiler in DevicesDataCenter.boilersList)
            {
                //TabPage
                TabPage tabPage = new TabPage();
                tabPage.Name = "tabPage_" + boiler.BoilerID;
                tabPage.Text = boiler.Caption;
                tabPage.BackgroundImage = new Bitmap(boiler.MapFilePath);
                tabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                tabPage.Location = new System.Drawing.Point(4, 25);
                tabPage.Padding = new System.Windows.Forms.Padding(3);
                tabPage.TabIndex = 0;
                tabPage.Text = boiler.Caption;
                tabPage.UseVisualStyleBackColor = true;
                tabPage.ClientSize = new Size(tabPage.BackgroundImage.Width, tabPage.BackgroundImage.Height);
                
                //pictureBoxes
                foreach (Sensor aSensor in DevicesDataCenter.allSensorsList)
                {
                    if (aSensor.BoilerID == boiler.BoilerID)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.BackColor = Color.Lime;
                        pictureBox.Left = aSensor.MapLeft;
                        pictureBox.Top = aSensor.MapTop;
                        pictureBox.Name = "pictureBox_" + aSensor.SensorID.ToString();
                        pictureBox.Size = new Size(16, 16);

                        tabPage.Controls.Add(pictureBox);
                    }
                }

                tabControl1.Controls.Add(tabPage);
            }
            this.ResumeLayout();

            TabPage selectedTabPage = tabControl1.SelectedTab;
            selectedTabPage.ClientSize = new Size(selectedTabPage.BackgroundImage.Width, selectedTabPage.BackgroundImage.Height);
            this.tabControl1.ClientSize = new Size(selectedTabPage.ClientSize.Width, selectedTabPage.ClientSize.Height);
            this.ClientSize = new Size(this.tabControl1.Width + 24, this.tabControl1.Height + 24);

            
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

            TabPage tabPage = tabControl1.SelectedTab;

            //pictureBoxes
            foreach (Sensor aSensor in DevicesDataCenter.allSensorsList)
            {
                if (this.Controls.Find("pictureBox_" + aSensor.SensorID.ToString(), true).Length > 0)
                { 
                    PictureBox pictureBox = (PictureBox)this.Controls.Find("pictureBox_" + aSensor.SensorID.ToString(), true)[0];
                    pictureBox.BackColor = aSensor.Color;

                }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl1.SelectedTab;
            tabPage.ClientSize = new Size(tabPage.BackgroundImage.Width, tabPage.BackgroundImage.Height);
            this.tabControl1.ClientSize = new Size(tabPage.ClientSize.Width, tabPage.ClientSize.Height);
            this.ClientSize = new Size(this.tabControl1.Width + 24, this.tabControl1.Height + 24);
        }
    }
}
