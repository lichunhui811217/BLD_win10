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
            this.SuspendLayout();
            // 
            // label_Sensor_27
            // 
            this.label_Sensor_27.AutoSize = true;
            this.label_Sensor_27.BackColor = System.Drawing.Color.Silver;
            this.label_Sensor_27.Location = new System.Drawing.Point(471, 37);
            this.label_Sensor_27.Name = "label_Sensor_27";
            this.label_Sensor_27.Size = new System.Drawing.Size(17, 12);
            this.label_Sensor_27.TabIndex = 0;
            this.label_Sensor_27.Text = "  ";
            // 
            // label_Sensor_28
            // 
            this.label_Sensor_28.AutoSize = true;
            this.label_Sensor_28.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_Sensor_28.Location = new System.Drawing.Point(521, 37);
            this.label_Sensor_28.Name = "label_Sensor_28";
            this.label_Sensor_28.Size = new System.Drawing.Size(17, 12);
            this.label_Sensor_28.TabIndex = 1;
            this.label_Sensor_28.Text = "  ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ObservationMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BLD_win10.Properties.Resources.cwt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(672, 520);
            this.Controls.Add(this.label_Sensor_28);
            this.Controls.Add(this.label_Sensor_27);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObservationMapForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ObservationMapForm";
            this.Load += new System.EventHandler(this.ObservationMapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Sensor_27;
        private System.Windows.Forms.Label label_Sensor_28;
        private System.Windows.Forms.Timer timer1;
    }
}