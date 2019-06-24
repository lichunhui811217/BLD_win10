namespace BLD_win10.AppForms
{
    partial class ObservationMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Sensor_27 = new System.Windows.Forms.Label();
            this.label_Sensor_28 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.testpictureBox_27 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.testpictureBox_27)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Sensor_27
            // 
            this.label_Sensor_27.AutoSize = true;
            this.label_Sensor_27.BackColor = System.Drawing.Color.Silver;
            this.label_Sensor_27.Location = new System.Drawing.Point(628, 46);
            this.label_Sensor_27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sensor_27.Name = "label_Sensor_27";
            this.label_Sensor_27.Size = new System.Drawing.Size(23, 15);
            this.label_Sensor_27.TabIndex = 0;
            this.label_Sensor_27.Text = "  ";
            // 
            // label_Sensor_28
            // 
            this.label_Sensor_28.AutoSize = true;
            this.label_Sensor_28.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_Sensor_28.Location = new System.Drawing.Point(695, 46);
            this.label_Sensor_28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sensor_28.Name = "label_Sensor_28";
            this.label_Sensor_28.Size = new System.Drawing.Size(23, 15);
            this.label_Sensor_28.TabIndex = 1;
            this.label_Sensor_28.Text = "  ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // testpictureBox_27
            // 
            this.testpictureBox_27.BackColor = System.Drawing.Color.Lime;
            this.testpictureBox_27.Location = new System.Drawing.Point(622, 12);
            this.testpictureBox_27.Name = "testpictureBox_27";
            this.testpictureBox_27.Size = new System.Drawing.Size(16, 16);
            this.testpictureBox_27.TabIndex = 2;
            this.testpictureBox_27.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 586);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ObservationMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BLD_win10.Properties.Resources.cwt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(896, 650);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.testpictureBox_27);
            this.Controls.Add(this.label_Sensor_28);
            this.Controls.Add(this.label_Sensor_27);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObservationMapForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ObservationMapForm";
            this.Load += new System.EventHandler(this.ObservationMapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testpictureBox_27)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Sensor_27;
        private System.Windows.Forms.Label label_Sensor_28;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox testpictureBox_27;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}