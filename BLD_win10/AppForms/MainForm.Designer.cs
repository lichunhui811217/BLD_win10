namespace BLD_win10.AppForms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observationMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.probabilityOfLeakageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AlarmLog = new System.Windows.Forms.ToolStripMenuItem();
            this.fftAndWaveletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SystemConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alternateAlarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildRemoteSupportFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leakRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leakQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ac6623TestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveletTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leakJudgmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.mainMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.configToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            resources.ApplyResources(this.systemToolStripMenuItem, "systemToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem,
            this.historicalGraphToolStripMenuItem,
            this.observationMapToolStripMenuItem,
            this.probabilityOfLeakageToolStripMenuItem,
            this.toolStripSeparator4});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            resources.ApplyResources(this.watchToolStripMenuItem, "watchToolStripMenuItem");
            this.watchToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            resources.ApplyResources(this.histogramToolStripMenuItem, "histogramToolStripMenuItem");
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // historicalGraphToolStripMenuItem
            // 
            this.historicalGraphToolStripMenuItem.Name = "historicalGraphToolStripMenuItem";
            resources.ApplyResources(this.historicalGraphToolStripMenuItem, "historicalGraphToolStripMenuItem");
            this.historicalGraphToolStripMenuItem.Click += new System.EventHandler(this.HistoricalGraphToolStripMenuItem_Click);
            // 
            // observationMapToolStripMenuItem
            // 
            this.observationMapToolStripMenuItem.Name = "observationMapToolStripMenuItem";
            resources.ApplyResources(this.observationMapToolStripMenuItem, "observationMapToolStripMenuItem");
            this.observationMapToolStripMenuItem.Click += new System.EventHandler(this.ObservationMapToolStripMenuItem_Click);
            // 
            // probabilityOfLeakageToolStripMenuItem
            // 
            this.probabilityOfLeakageToolStripMenuItem.Name = "probabilityOfLeakageToolStripMenuItem";
            resources.ApplyResources(this.probabilityOfLeakageToolStripMenuItem, "probabilityOfLeakageToolStripMenuItem");
            this.probabilityOfLeakageToolStripMenuItem.Click += new System.EventHandler(this.ProbabilityOfLeakageToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AlarmLog,
            this.fftAndWaveletToolStripMenuItem,
            this.checkChannelsToolStripMenuItem,
            this.systemLogToolStripMenuItem,
            this.listenerToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            resources.ApplyResources(this.analysisToolStripMenuItem, "analysisToolStripMenuItem");
            // 
            // ToolStripMenuItem_AlarmLog
            // 
            this.ToolStripMenuItem_AlarmLog.Name = "ToolStripMenuItem_AlarmLog";
            resources.ApplyResources(this.ToolStripMenuItem_AlarmLog, "ToolStripMenuItem_AlarmLog");
            // 
            // fftAndWaveletToolStripMenuItem
            // 
            this.fftAndWaveletToolStripMenuItem.Name = "fftAndWaveletToolStripMenuItem";
            resources.ApplyResources(this.fftAndWaveletToolStripMenuItem, "fftAndWaveletToolStripMenuItem");
            // 
            // checkChannelsToolStripMenuItem
            // 
            this.checkChannelsToolStripMenuItem.Name = "checkChannelsToolStripMenuItem";
            resources.ApplyResources(this.checkChannelsToolStripMenuItem, "checkChannelsToolStripMenuItem");
            // 
            // systemLogToolStripMenuItem
            // 
            this.systemLogToolStripMenuItem.Name = "systemLogToolStripMenuItem";
            resources.ApplyResources(this.systemLogToolStripMenuItem, "systemLogToolStripMenuItem");
            // 
            // listenerToolStripMenuItem
            // 
            this.listenerToolStripMenuItem.Name = "listenerToolStripMenuItem";
            resources.ApplyResources(this.listenerToolStripMenuItem, "listenerToolStripMenuItem");
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SystemConfig,
            this.changePasswordToolStripMenuItem,
            this.alternateAlarmToolStripMenuItem,
            this.alarmConfigToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            resources.ApplyResources(this.configToolStripMenuItem, "configToolStripMenuItem");
            // 
            // ToolStripMenuItem_SystemConfig
            // 
            this.ToolStripMenuItem_SystemConfig.Name = "ToolStripMenuItem_SystemConfig";
            resources.ApplyResources(this.ToolStripMenuItem_SystemConfig, "ToolStripMenuItem_SystemConfig");
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            // 
            // alternateAlarmToolStripMenuItem
            // 
            this.alternateAlarmToolStripMenuItem.Name = "alternateAlarmToolStripMenuItem";
            resources.ApplyResources(this.alternateAlarmToolStripMenuItem, "alternateAlarmToolStripMenuItem");
            // 
            // alarmConfigToolStripMenuItem
            // 
            this.alarmConfigToolStripMenuItem.Name = "alarmConfigToolStripMenuItem";
            resources.ApplyResources(this.alarmConfigToolStripMenuItem, "alarmConfigToolStripMenuItem");
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildRemoteSupportFilesToolStripMenuItem,
            this.leakRegistrationToolStripMenuItem,
            this.leakQueryToolStripMenuItem,
            this.toolStripSeparator1,
            this.ac6623TestToolStripMenuItem,
            this.waveletTestToolStripMenuItem,
            this.otherTestToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // buildRemoteSupportFilesToolStripMenuItem
            // 
            this.buildRemoteSupportFilesToolStripMenuItem.Name = "buildRemoteSupportFilesToolStripMenuItem";
            resources.ApplyResources(this.buildRemoteSupportFilesToolStripMenuItem, "buildRemoteSupportFilesToolStripMenuItem");
            // 
            // leakRegistrationToolStripMenuItem
            // 
            this.leakRegistrationToolStripMenuItem.Name = "leakRegistrationToolStripMenuItem";
            resources.ApplyResources(this.leakRegistrationToolStripMenuItem, "leakRegistrationToolStripMenuItem");
            // 
            // leakQueryToolStripMenuItem
            // 
            this.leakQueryToolStripMenuItem.Name = "leakQueryToolStripMenuItem";
            resources.ApplyResources(this.leakQueryToolStripMenuItem, "leakQueryToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ac6623TestToolStripMenuItem
            // 
            this.ac6623TestToolStripMenuItem.Name = "ac6623TestToolStripMenuItem";
            resources.ApplyResources(this.ac6623TestToolStripMenuItem, "ac6623TestToolStripMenuItem");
            this.ac6623TestToolStripMenuItem.Click += new System.EventHandler(this.ac6623TestToolStripMenuItem_Click);
            // 
            // waveletTestToolStripMenuItem
            // 
            this.waveletTestToolStripMenuItem.Name = "waveletTestToolStripMenuItem";
            resources.ApplyResources(this.waveletTestToolStripMenuItem, "waveletTestToolStripMenuItem");
            // 
            // otherTestToolStripMenuItem
            // 
            this.otherTestToolStripMenuItem.Name = "otherTestToolStripMenuItem";
            resources.ApplyResources(this.otherTestToolStripMenuItem, "otherTestToolStripMenuItem");
            this.otherTestToolStripMenuItem.Click += new System.EventHandler(this.OtherTestToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpFileToolStripMenuItem,
            this.leakJudgmentToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpFileToolStripMenuItem
            // 
            this.helpFileToolStripMenuItem.Name = "helpFileToolStripMenuItem";
            resources.ApplyResources(this.helpFileToolStripMenuItem, "helpFileToolStripMenuItem");
            // 
            // leakJudgmentToolStripMenuItem
            // 
            this.leakJudgmentToolStripMenuItem.Name = "leakJudgmentToolStripMenuItem";
            resources.ApplyResources(this.leakJudgmentToolStripMenuItem, "leakJudgmentToolStripMenuItem");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::BLD_win10.Properties.Resources.bmp;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(2);
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButton2.Image = global::BLD_win10.Properties.Resources.jpg;
            this.toolStripButton2.Name = "toolStripButton2";
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observationMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem probabilityOfLeakageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AlarmLog;
        private System.Windows.Forms.ToolStripMenuItem fftAndWaveletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkChannelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SystemConfig;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alternateAlarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildRemoteSupportFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leakRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leakQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ac6623TestToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem waveletTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem leakJudgmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

