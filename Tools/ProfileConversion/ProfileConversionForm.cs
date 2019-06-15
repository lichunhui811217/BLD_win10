using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace ProfileConversion
{
    public partial class ProfileConversionForm : Form
    {
        XDocument srcTree;

        public ProfileConversionForm()
        {
            InitializeComponent();
        }

        private void ButtonReadIni_Click(object sender, EventArgs e)
        {
            openIniFileDialog.InitialDirectory = @"d:\glsys\";
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
            int MAX_CHANNEL = 60;
            //UDP
            int udp, USEFFT, Cyyz, keysetValue, By_Alarm;

            //bool
            bool DA, WavRecord, boStandby, boLeak, dtuPortEnable;
            bool[] bQHKZh = new bool[4];     // 清灰控制
            string pwlsh;

            //炉数量, 炉号, 服务器, 管道, 采样间隔, 
            int lushu, luhao, fuwuqi, guandao, cyjg, xlych, dhych, chaoxian, duhui, guzhang, bool_tl, sleeptime;
            string Mingcheng, ComStr;
            float zyz, llyz, standard_tl;
            float[] jchzsh = new float[MAX_CHANNEL],
                shx = new float[MAX_CHANNEL],
                xiax = new float[MAX_CHANNEL],
                fftlimit = new float[MAX_CHANNEL];
            char[] PassWord = new char[50];

            string strcpy;
            string BeginTime;
            //--------------------- 读参数 glsys.ini文件 -----------------------
            try
            {
                lushu = Convert.ToInt32(IniFile.IniReadValue("炉数", "BoilerNumber", "1"));
                fuwuqi = Convert.ToInt32(IniFile.IniReadValue("服务器", "SupportServer", "0"));
                udp = Convert.ToInt32(IniFile.IniReadValue("服务器", "UDP", "0"));
                // CreateABoilerParam(lushu, fuwuqi);
                USEFFT = Convert.ToInt32(IniFile.IniReadValue("使用FFT", "USEFFT", "0"));
                Cyyz = Convert.ToInt32(IniFile.IniReadValue("历史曲线抽样倍数", "Cyyz", "1"));
                keysetValue = Convert.ToInt32(IniFile.IniReadValue("键盘", "KeyBoard", ""));
                pwlsh = IniFile.IniReadValue("口令", "Password", "");

                DA = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("监听", "DA", "0")));
                WavRecord = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("监听", "Record", "0")));

                boStandby = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("备用报警控制", "Standby", "0")));
                By_Alarm = Convert.ToInt32(IniFile.IniReadValue("备用报警控制", "StandbyAlarm", "0"));
                boLeak = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("备用报警控制", "LeakStandbyAlarm", "0")));

                // DTU通讯 add by lich @2019-5-6
                dtuPortEnable = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("DTU通讯", "dtuPortEnable", "1")));

                //for (int i = 0; i < PassWord.Length; i++)
                //{
                //    PassWord[i] = PassWord[i] ^ (0xf9);
                //}

                for (int i = 1; i <= lushu; i++)
                {
                    bQHKZh[i - 1] = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "清灰控制", "QHKZh", "0")));
                    ComStr = IniFile.IniReadValue(i.ToString() + "串行通讯", "ComPort", "COM1");
                    //if (ComStr != "")
                    //{
                    //    ComStatus[i - 1] = true;
                    //}
                    luhao = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "号炉", "BoilerNo", i.ToString()));
                    Mingcheng = IniFile.IniReadValue(i.ToString() + "名称", "Caption", "名称");

                    //_MenuItem[i - 1] = new TMenuItem(Watchgl);
                    //_MenuItem[i - 1]->Caption = Mingcheng;
                    //_MenuItem[i - 1]->Name = "MenuItem" + i.ToString();
                    //_MenuItem[i - 1]->RadioItem = true;
                    //_MenuItem[i - 1]->Tag = i;
                    //_MenuItem[i - 1]->OnClick = SwitchglExecute;
                    //if (i == 1)
                    //{
                    //    _MenuItem[i - 1]->Checked = true;
                    //}
                    //Watchgl->Add(_MenuItem[i - 1]);
                    guandao = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "管道数", "ChanelNumber", "60"));

                    //-------------------------------生成炉B参数----------------------------------
                    //CreateBBoilerParam(luhao, guandao, Mingcheng, AnsiString(PassWord));

                    //----------------------------------------------------------------------------
                    zyz = Convert.ToSingle(IniFile.IniReadValue(i.ToString() + "总因子", "GeneralFactor", "15"));
                    llyz = Convert.ToSingle(IniFile.IniReadValue(i.ToString() + "流量因子", "FluxFactor", "1.0"));
                    cyjg = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "采样间隔", "SamplingInterval", "60"));
                    xlych = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "泄漏报警延迟时间", "LeakageAlarmDelayTime", "60"));
                    dhych = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "堵灰报警延迟时间", "BlockAshDelayTime", "60"));
                    int tempi = i;
                    for (int j = 1; j <= guandao; j++)
                    {
                        jchzsh[j - 1] = Convert.ToSingle(IniFile.IniReadValue(tempi.ToString() + "基础噪音因子", j.ToString() + "号通道", "0"));
                        shx[j - 1] = Convert.ToSingle(IniFile.IniReadValue(tempi.ToString() + "上限", j.ToString() + "号通道", "4"));
                        xiax[j - 1] = Convert.ToSingle(IniFile.IniReadValue(tempi.ToString() + "下限", j.ToString() + "号通道", "0.5"));
                        fftlimit[j - 1] = Convert.ToSingle(IniFile.IniReadValue(tempi.ToString() + "FFT警戒限", j.ToString() + "号通道", "0"));
                    }

                    //---------------------------超限、堵灰、故障参数-----------------------------
                    chaoxian = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "超限报警开关", "AlarmSwitch", "0"));
                    duhui = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "堵灰报警开关", "AlarmSwitch", "0"));
                    guzhang = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "故障报警开关", "AlarmSwitch", "0"));
                    bool_tl = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "停炉报警开关", "AlarmSwitch", "0"));
                    sleeptime = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "线程休眠时间", "SleepTime", "0"));
                    standard_tl = Convert.ToSingle(IniFile.IniReadValue(i.ToString() + "判断停炉流量标准", "StopBoielrFlux", "0"));
                    strcpy = IniFile.IniReadValue(i.ToString() + "数据源", "odbcName", "0");
                    BeginTime = IniFile.IniReadValue(i.ToString() + "开始运行时间", "yearmonthday", DateTime.Now.ToString());

                    //history[i - 1] = new Thistory(i, guandao, AppPath);
                    //history[i - 1]->loadCurData();
                    //生成通道对象
                    //CreateChannelObject(luhao, guandao, jchzsh, shx, xiax, AnsiString(odbc[i - 1]), fftlimit);
                    //CreateglObject(luhao, guandao, zyz, llyz, cyjg, xlych, dhych, chaoxian, duhui, guzhang, ChanelParams[luhao - 1], bool_tl, sleeptime, standard_tl);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            srcTree = new XDocument(
                new XComment("This is a comment. 这是一行注释."),

                new XElement("Root", new XAttribute("ID", "IDABC"),
                    new XElement("XText", new XText("这是一个xml文本")),
                    new XElement("XCData", new XCData("这是个xml CData")),
                    new XElement("Child1", "data1"),
                    new XElement("Child2", "data2"),
                    new XElement("Child3", "data3"),
                    new XElement("Child2", "data4"),
                    new XElement("Info5", "info5"),
                    new XElement("Info6", "info6"),
                    new XElement("Info7", "info7"),
                    new XElement("Info8", "info8")
                )
            );

            //srcTree.Save(@"d:\glsys\glsys.xml");

            textBoxXml.Text = srcTree.ToString();
        }

        private void ButtonSaveXml_Click(object sender, EventArgs e)
        {
            string fileName;
            Stream myStream;
            //SaveFileDialog saveXmlFileDialog = new SaveFileDialog();
            saveXmlFileDialog.InitialDirectory = @"./";
            saveXmlFileDialog.Filter = "txt files (*.xml)|*.xml|All files (*.*)|*.*";
            saveXmlFileDialog.FilterIndex = 1;
            saveXmlFileDialog.RestoreDirectory = true;

            if (saveXmlFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveXmlFileDialog.FileName;
                if ((myStream = saveXmlFileDialog.OpenFile()) != null)
                {
                    //// Code to write the stream goes here.
                    
                    ////saveXmlFileDialog.FileName;
                    //StreamWriter writer = new StreamWriter(myStream, Encoding.GetEncoding("gb2312"));
                    //writer.Write(textBoxXml.Text);
                    myStream.Close();
                }
            }
            else
            {
                fileName = @"d:\glsys.xml";
            }

            srcTree.Save(fileName);
        }

        /// <summary>
        /// ini 转换为 xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxIni_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ini 转换为 xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxIni_TextChanged学习(object sender, EventArgs e)
        {
            //XNode xNode = new XNode();

            XElement root = new XElement("ElementName", "content");
            Console.WriteLine(root);

            XElement xmlTree1 = new XElement("PowerPlant",
                new XElement("Child1", 1),
                new XElement("Child2", 2),
                new XElement("Child3", 3),
                new XElement("Child4", 4),
                new XElement("Child5", 5),
                new XElement("Child6", 6)
            );

            XElement xmlTree2 = new XElement("Root",
                from el in xmlTree1.Elements()
                where ((int)el >= 3 && (int)el <= 5)
                select el
            );

            XDocument srcTree = new XDocument(
                new XComment("This is a comment. 这是一行注释."),

                new XElement("Root", new XAttribute("ID", "IDABC"),
                    new XElement("XText", new XText("这是一个xml文本")),
                    new XElement("XCData", new XCData("这是个xml CData")),
                    new XElement("Child1", "data1"),
                    new XElement("Child2", "data2"),
                    new XElement("Child3", "data3"),
                    new XElement("Child2", "data4"),
                    new XElement("Info5", "info5"),
                    new XElement("Info6", "info6"),
                    new XElement("Info7", "info7"),
                    new XElement("Info8", "info8")
                )
            );

            IEnumerable<XComment> comments;
            List<XElement> elements;

            XDocument doc = new XDocument(
                new XComment("This is a comment"),
                new XElement("Root",
                    from el in srcTree.Element("Root").Elements()
                    where ((string)el).StartsWith("data")
                    select el
                )
            );

            XDocument xmlTree = new XDocument(
                new XComment("a comment"),
                new XProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"hello.xsl\""),
                new XElement("Root",
                    new XAttribute("Att", "attContent"),
                    new XElement("Child1",
                        new XCData("CDATA content")
                    ),
                    new XElement("Child2", "Text content")
                )
            );

            // 每个节点和节点内属性值遍历
            foreach (XNode node in xmlTree.DescendantNodes())
            {
                Console.WriteLine(node.NodeType);
                if (node.NodeType == XmlNodeType.Element)
                {
                    foreach (XAttribute att in ((XElement)node).Attributes())
                        Console.WriteLine(att.NodeType);
                }
            }

            textBoxXml.Text = xmlTree1.ToString() + "\r\n"
                + xmlTree2.ToString() + "\r\n"
                + srcTree.ToString() + "\r\n"
                + doc + "\r\n"
                + xmlTree + "\r\n"
                ;
            /*
            < Root >
              < Child1 > 1 </ Child1 >
              < Child2 > 2 </ Child2 >
              < Child3 > 3 </ Child3 >
              < Child4 > 4 </ Child4 >
              < Child5 > 5 </ Child5 >
              < Child6 > 6 </ Child6 >
            </ Root >
            < Root >
              < Child3 > 3 </ Child3 >
              < Child4 > 4 </ Child4 >
              < Child5 > 5 </ Child5 >
            </ Root >
            */
        }

    }
}
