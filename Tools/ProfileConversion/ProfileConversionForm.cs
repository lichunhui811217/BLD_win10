using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileConversion
{
    public partial class ProfileConversionForm : Form
    {
        public ProfileConversionForm()
        {
            InitializeComponent();
        }

        private void ButtonReadIni_Click(object sender, EventArgs e)
        {
            openIniFileDialog.InitialDirectory = @"E:\MyDoc\Documents";
            openIniFileDialog.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*";
            openIniFileDialog.FilterIndex = 1;
            openIniFileDialog.RestoreDirectory = true;

            if (openIniFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Read the contents of the file into a stream
                var fileStream = openIniFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream, Encoding.GetEncoding("gb2312")))
                {
                    string fileContent = reader.ReadToEnd();
                    textBoxIni.Text = fileContent;
                }
            }
        }

        private void OpenIniFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ButtonSaveXml_Click(object sender, EventArgs e)
        {
            Stream myStream;
            //SaveFileDialog saveXmlFileDialog = new SaveFileDialog();
            saveXmlFileDialog.InitialDirectory = @"./";
            saveXmlFileDialog.Filter = "txt files (*.xml)|*.xml|All files (*.*)|*.*";
            saveXmlFileDialog.FilterIndex = 1;
            saveXmlFileDialog.RestoreDirectory = true;

            if (saveXmlFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveXmlFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    StreamWriter writer = new StreamWriter(myStream, Encoding.GetEncoding("gb2312"));
                    writer.Write(textBoxXml.Text);
                    myStream.Close();
                }
            }
        }

        /// <summary>
        /// ini 转换为 xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxIni_TextChanged(object sender, EventArgs e)
        {
            textBoxXml.Text = textBoxIni.Text;
        }
    }
}
