namespace ProfileConversion
{
    partial class ProfileConversionForm
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
            this.buttonReadIni = new System.Windows.Forms.Button();
            this.textBoxIni = new System.Windows.Forms.TextBox();
            this.openIniFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveXml = new System.Windows.Forms.Button();
            this.saveXmlFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxXml = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonReadIni
            // 
            this.buttonReadIni.Location = new System.Drawing.Point(338, 528);
            this.buttonReadIni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReadIni.Name = "buttonReadIni";
            this.buttonReadIni.Size = new System.Drawing.Size(86, 22);
            this.buttonReadIni.TabIndex = 0;
            this.buttonReadIni.Text = "Read ini";
            this.buttonReadIni.UseVisualStyleBackColor = true;
            this.buttonReadIni.Click += new System.EventHandler(this.ButtonReadIni_Click);
            // 
            // textBoxIni
            // 
            this.textBoxIni.Location = new System.Drawing.Point(10, 7);
            this.textBoxIni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIni.Multiline = true;
            this.textBoxIni.Name = "textBoxIni";
            this.textBoxIni.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIni.Size = new System.Drawing.Size(414, 517);
            this.textBoxIni.TabIndex = 2;
            this.textBoxIni.TextChanged += new System.EventHandler(this.TextBoxIni_TextChanged);
            // 
            // openIniFileDialog
            // 
            this.openIniFileDialog.DefaultExt = "ini";
            this.openIniFileDialog.FileName = "openIniFileDialog";
            this.openIniFileDialog.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*";
            this.openIniFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenIniFileDialog_FileOk);
            // 
            // buttonSaveXml
            // 
            this.buttonSaveXml.Location = new System.Drawing.Point(911, 528);
            this.buttonSaveXml.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveXml.Name = "buttonSaveXml";
            this.buttonSaveXml.Size = new System.Drawing.Size(86, 22);
            this.buttonSaveXml.TabIndex = 4;
            this.buttonSaveXml.Text = "Save Xml";
            this.buttonSaveXml.UseVisualStyleBackColor = true;
            this.buttonSaveXml.Click += new System.EventHandler(this.ButtonSaveXml_Click);
            // 
            // textBoxXml
            // 
            this.textBoxXml.Location = new System.Drawing.Point(428, 7);
            this.textBoxXml.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxXml.Multiline = true;
            this.textBoxXml.Name = "textBoxXml";
            this.textBoxXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxXml.Size = new System.Drawing.Size(569, 517);
            this.textBoxXml.TabIndex = 5;
            // 
            // ProfileConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.textBoxXml);
            this.Controls.Add(this.buttonSaveXml);
            this.Controls.Add(this.textBoxIni);
            this.Controls.Add(this.buttonReadIni);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileConversionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileConversionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadIni;
        private System.Windows.Forms.TextBox textBoxIni;
        private System.Windows.Forms.OpenFileDialog openIniFileDialog;
        private System.Windows.Forms.Button buttonSaveXml;
        private System.Windows.Forms.SaveFileDialog saveXmlFileDialog;
        private System.Windows.Forms.TextBox textBoxXml;
    }
}

