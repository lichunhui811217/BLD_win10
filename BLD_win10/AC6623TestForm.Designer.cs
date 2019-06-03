namespace BLD_win10
{
    partial class AC6623TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AC6623TestForm));
            this.button_AD = new System.Windows.Forms.Button();
            this.listBox_ad = new System.Windows.Forms.ListBox();
            this.label_di = new System.Windows.Forms.Label();
            this.DI = new System.Windows.Forms.Button();
            this.DO = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_cnt = new System.Windows.Forms.Button();
            this.textBox_da = new System.Windows.Forms.TextBox();
            this.button_da = new System.Windows.Forms.Button();
            this.button_adstop = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PWM_END = new System.Windows.Forms.Button();
            this.button_pwm = new System.Windows.Forms.Button();
            this.textBox_do = new System.Windows.Forms.TextBox();
            this.label_cnt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AD
            // 
            resources.ApplyResources(this.button_AD, "button_AD");
            this.button_AD.Name = "button_AD";
            this.button_AD.UseVisualStyleBackColor = true;
            this.button_AD.Click += new System.EventHandler(this.button_AD_Click);
            // 
            // listBox_ad
            // 
            resources.ApplyResources(this.listBox_ad, "listBox_ad");
            this.listBox_ad.FormattingEnabled = true;
            this.listBox_ad.Name = "listBox_ad";
            // 
            // label_di
            // 
            resources.ApplyResources(this.label_di, "label_di");
            this.label_di.Name = "label_di";
            // 
            // DI
            // 
            resources.ApplyResources(this.DI, "DI");
            this.DI.Name = "DI";
            this.DI.UseVisualStyleBackColor = true;
            this.DI.Click += new System.EventHandler(this.DI_Click);
            // 
            // DO
            // 
            resources.ApplyResources(this.DO, "DO");
            this.DO.Name = "DO";
            this.DO.UseVisualStyleBackColor = true;
            this.DO.Click += new System.EventHandler(this.DO_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_cnt
            // 
            resources.ApplyResources(this.button_cnt, "button_cnt");
            this.button_cnt.Name = "button_cnt";
            this.button_cnt.UseVisualStyleBackColor = true;
            this.button_cnt.Click += new System.EventHandler(this.button_cnt_Click);
            // 
            // textBox_da
            // 
            resources.ApplyResources(this.textBox_da, "textBox_da");
            this.textBox_da.Name = "textBox_da";
            // 
            // button_da
            // 
            resources.ApplyResources(this.button_da, "button_da");
            this.button_da.Name = "button_da";
            this.button_da.UseVisualStyleBackColor = true;
            this.button_da.Click += new System.EventHandler(this.button_da_Click);
            // 
            // button_adstop
            // 
            resources.ApplyResources(this.button_adstop, "button_adstop");
            this.button_adstop.Name = "button_adstop";
            this.button_adstop.UseVisualStyleBackColor = true;
            this.button_adstop.Click += new System.EventHandler(this.button_adstop_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PWM_END
            // 
            resources.ApplyResources(this.PWM_END, "PWM_END");
            this.PWM_END.Name = "PWM_END";
            this.PWM_END.UseVisualStyleBackColor = true;
            this.PWM_END.Click += new System.EventHandler(this.PWM_END_Click);
            // 
            // button_pwm
            // 
            resources.ApplyResources(this.button_pwm, "button_pwm");
            this.button_pwm.Name = "button_pwm";
            this.button_pwm.UseVisualStyleBackColor = true;
            this.button_pwm.Click += new System.EventHandler(this.button_pwm_Click);
            // 
            // textBox_do
            // 
            resources.ApplyResources(this.textBox_do, "textBox_do");
            this.textBox_do.Name = "textBox_do";
            // 
            // label_cnt
            // 
            resources.ApplyResources(this.label_cnt, "label_cnt");
            this.label_cnt.Name = "label_cnt";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AC6623TestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_AD);
            this.Controls.Add(this.listBox_ad);
            this.Controls.Add(this.label_di);
            this.Controls.Add(this.DI);
            this.Controls.Add(this.DO);
            this.Controls.Add(this.button_cnt);
            this.Controls.Add(this.textBox_da);
            this.Controls.Add(this.button_da);
            this.Controls.Add(this.button_adstop);
            this.Controls.Add(this.PWM_END);
            this.Controls.Add(this.button_pwm);
            this.Controls.Add(this.textBox_do);
            this.Controls.Add(this.label_cnt);
            this.Name = "AC6623TestForm";
            this.Load += new System.EventHandler(this.AC6623TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AD;
        private System.Windows.Forms.ListBox listBox_ad;
        private System.Windows.Forms.Label label_di;
        private System.Windows.Forms.Button DI;
        private System.Windows.Forms.Button DO;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_cnt;
        private System.Windows.Forms.TextBox textBox_da;
        private System.Windows.Forms.Button button_da;
        private System.Windows.Forms.Button button_adstop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button PWM_END;
        private System.Windows.Forms.Button button_pwm;
        private System.Windows.Forms.TextBox textBox_do;
        private System.Windows.Forms.Label label_cnt;
        private System.Windows.Forms.Button button1;
    }
}