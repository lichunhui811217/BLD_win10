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
using System.IO.Ports;

namespace ProfileConversion
{
    public partial class ProfileConversionForm : Form
    {
        XDocument config_Xml;

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
            int sensorID = 1;
            List<XNode> systemParameters = new List<XNode>();     //系统参数 server
            List<XObject> boilerParameters;    //炉参数 Boiler
            List<XNode> captureCardsParameters = new List<XNode>();    //采集卡 CaptureCards
            List<XNode> sensorsParameters;    //传感器参数 sensor
            List<XNode> serialPortsParameters = new List<XNode>();    //串口通讯参数 serialPorts

            #region 读参数 glsys.ini文件 
            #region 系统参数
            //[炉数]
            int BoilerNumber = Convert.ToInt32(IniFile.IniReadValue("炉数", "BoilerNumber", "1"));
            systemParameters.Add(new XElement("炉数",
                    new XAttribute("BoilerNumber", BoilerNumber)
                )); //炉数 不应该在这使用,暂时先加在这吧.
            //[服务器]
            int SupportServer = Convert.ToInt32(IniFile.IniReadValue("服务器", "SupportServer", "0"));
            int UDP = Convert.ToInt32(IniFile.IniReadValue("服务器", "UDP", "0"));
            int RemotePort = Convert.ToInt32(IniFile.IniReadValue("服务器", "RemotePort", "6803"));
            string RemoteHost = IniFile.IniReadValue("服务器", "RemoteHost", "10.164.12.200");
            systemParameters.Add(new XElement("服务器"
                , new XAttribute("SupportServer", SupportServer)
                , new XAttribute("UDP", UDP)
                , new XAttribute("RemotePort", RemotePort)
                , new XAttribute("RemoteHost", RemoteHost)
                ));
            //[板卡数量] 弃用,改为 CaptureCards下的元素
            int CardCount = Convert.ToInt32(IniFile.IniReadValue("板卡数量", "CardCount", "1"));
            //[DTU通讯]
            bool dtuPortEnable = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("DTU通讯", "dtuPortEnable", "1")));
            string dtuPort = IniFile.IniReadValue("DTU通讯", "dtuPort", "COM1"); //dtuPort =COM7
            string dtuProtocol = IniFile.IniReadValue("DTU通讯", "dtuProtocol", "Modbus"); //dtuProtocol = Modbus
            string dtuDataModal = IniFile.IniReadValue("DTU通讯", "dtuDataModal", "DTU"); //dtuDataModal =DTU
            int dtuAddress = Convert.ToInt32(IniFile.IniReadValue("DTU通讯", "dtuAddress", "1")); //dtuAddress = 1 通讯站号 UnitID
            string dtuDcb = IniFile.IniReadValue("DTU通讯", "dtuDcb", "19200,E,8,1"); //dtuDcb =19200,E,8,1 TODO:需要拆分.
            string[] dtuDcbSplit = dtuDcb.Split(',');
            Parity parity = GetParity(dtuDcbSplit[1]);
            serialPortsParameters.Add(new XElement("SerialPort"
                        , new XAttribute("PortName", dtuPort)
                        , new XAttribute("BaudRate", dtuDcbSplit[0])
                        , new XAttribute("Parity", parity)
                        , new XAttribute("DataBits", dtuDcbSplit[2])
                        , new XAttribute("StopBits", dtuDcbSplit[3])
                        , new XAttribute("Handshake", 0)
                        , new XAttribute("ReadTimeout", 300)
                        , new XAttribute("WriteTimeout", 300)

                        , new XAttribute("UnitID", dtuAddress)
                        , new XAttribute("DtuUsed", dtuPortEnable)
                        , new XAttribute("PortEnable", true)
                    ));

            //[键盘]
            int keysetValue = Convert.ToInt32(IniFile.IniReadValue("键盘", "KeyBoard", ""));
            //[使用FFT]
            int USEFFT = Convert.ToInt32(IniFile.IniReadValue("使用FFT", "USEFFT", "0"));
            //[历史曲线抽样倍数]
            int Cyyz = Convert.ToInt32(IniFile.IniReadValue("历史曲线抽样倍数", "Cyyz", "1"));
            //[[口令]
            string pwlsh = IniFile.IniReadValue("口令", "Password", "");
            //[历史数据保存天数]
            int DaysOfData = Convert.ToInt32(IniFile.IniReadValue("历史数据保存天数", "DaysOfData", "360")); //DaysOfData =360
            //[吹灰状态]
            int ChHStatus = Convert.ToInt32(IniFile.IniReadValue("吹灰状态", "ChHStatus", "1")); //ChHStatus =1
            //[吹灰报警时间]
            int ChHAlarmtime = Convert.ToInt32(IniFile.IniReadValue("吹灰报警时间", "ChHAlarmtime", "1")); //ChHAlarmtime = 8
            //[备用报警控制]
            bool boStandby = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("备用报警控制", "Standby", "0")));
            int By_Alarm = Convert.ToInt32(IniFile.IniReadValue("备用报警控制", "StandbyAlarm", "0"));
            bool boLeak = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("备用报警控制", "LeakStandbyAlarm", "0")));
            //[监听]
            bool DA = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("监听", "DA", "0")));
            bool Record = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue("监听", "Record", "0")));
            #endregion

            #region 炉参数
            boilerParameters = new List<XObject>();
            bool[] bQHKZh = new bool[4];        //清灰控制
            for (int i = 1; i <= BoilerNumber; i++)    //炉参数
            {
                boilerParameters = new List<XObject>();
                //号炉
                int BoilerNo = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "号炉", "BoilerNo", i.ToString()));
                boilerParameters.Add(new XAttribute("BoilerID", BoilerNo));
                //名称
                string Caption = IniFile.IniReadValue(i.ToString() + "名称", "Caption", "名称");
                string 厂内编号 = IniFile.IniReadValue(i.ToString() + "名称", "厂内编号", "1");
                boilerParameters.Add(new XAttribute("Caption", Caption));
                boilerParameters.Add(new XAttribute("厂内编号", 厂内编号));

                //[1串行通讯] 改为通讯池
                string ComPort = IniFile.IniReadValue(i.ToString() + "串行通讯", "dtuPort", "COM1");
                string ComProtocol = IniFile.IniReadValue(i.ToString() + "串行通讯", "dtuProtocol", "Modbus");
                string ComDataModal = IniFile.IniReadValue(i.ToString() + "串行通讯", "dtuDataModal", "RTU");
                int ComAddress = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "串行通讯", "dtuAddress", "9")); //通讯站号 UnitID
                string ComDCB = IniFile.IniReadValue(i.ToString() + "串行通讯", "dtuDcb", "19200,E,8,1"); // TODO:需要拆分.
                string[] ComDCBSplit = dtuDcb.Split(',');
                parity = GetParity(ComDCBSplit[1]);
                serialPortsParameters.Add(new XElement("SerialPort"
                    , new XAttribute("PortName", ComPort)
                    , new XAttribute("BaudRate", ComDCBSplit[0])
                    , new XAttribute("Parity", parity)
                    , new XAttribute("DataBits", ComDCBSplit[2])
                    , new XAttribute("StopBits", ComDCBSplit[3])
                    , new XAttribute("Handshake", 0)
                    , new XAttribute("ReadTimeout", 300)
                    , new XAttribute("WriteTimeout", 300)

                    , new XAttribute("UnitID", ComAddress)
                    , new XAttribute("DtuUsed", false)
                    , new XAttribute("PortEnable", true)
                ));

                //清灰控制和报警开关量没读取到XML
                //TODO:报警开关量 
                //Switch = 0
                //Switch1 = QHKZ1
                //Switch2 = QHKZ2
                //Switch3 = QHKZ3
                //Switch4 = QHKZ4
                //Switch5 = QHKZ5
                //Switch6 = QHKZ6
                //Switch7 = QHKZ7
                //Switch8 = QHKZ8
                boilerParameters.Add(new XElement("报警开关量", "TODO:暂缺"));
                //清灰控制 TODO: 缺后几个参数 
                bQHKZh[i - 1] = Convert.ToBoolean(Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "清灰控制", "QHKZh", "0")));
                //AutoEachTime = 5
                //AutoBreakTime = 10
                //SelectedGroup1 = 1
                //SelectedGroup2 = 0
                //SelectedGroup3 = 0
                //SelectedGroup4 = 0
                //SelectedGroup5 = 0
                //SelectedGroup6 = 0
                //SelectedGroup7 = 0
                //SelectedGroup8 = 0
                boilerParameters.Add(new XElement("清灰控制", "TODO:暂缺"));

                //管道数 白字先生 :P
                int ChannelNumber = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "管道数", "ChanelNumber", "60"));
                boilerParameters.Add(new XElement("管道数", ChannelNumber));
                //总因子 TODO:改为各通道倍数因子
                float GeneralFactor = Convert.ToSingle(IniFile.IniReadValue(i.ToString() + "总因子", "GeneralFactor", "15"));
                boilerParameters.Add(new XElement("总因子", GeneralFactor));
                //流量因子
                float FluxFactor = Convert.ToSingle(IniFile.IniReadValue(i.ToString() + "流量因子", "FluxFactor", "1.0"));
                boilerParameters.Add(new XElement("流量因子", FluxFactor));
                //采样间隔
                int SamplingInterval = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "采样间隔", "SamplingInterval", "60"));
                boilerParameters.Add(new XElement("采样间隔", SamplingInterval));
                //泄漏报警延迟时间
                int LeakageAlarmDelayTime = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "泄漏报警延迟时间", "LeakageAlarmDelayTime", "60"));
                boilerParameters.Add(new XElement("泄漏报警延迟时间", LeakageAlarmDelayTime));
                //堵灰报警延迟时间
                int BlockAshDelayTime = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "堵灰报警延迟时间", "BlockAshDelayTime", "60"));
                boilerParameters.Add(new XElement("堵灰报警延迟时间", BlockAshDelayTime));
                //超限、堵灰、故障参数 等等
                int AlarmSwitch1 = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "超限报警开关", "AlarmSwitch", "0"));
                boilerParameters.Add(new XElement("超限报警开关", AlarmSwitch1));

                int AlarmSwitch2 = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "堵灰报警开关", "AlarmSwitch", "0"));
                boilerParameters.Add(new XElement("堵灰报警开关", AlarmSwitch2));

                int AlarmSwitch3 = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "故障报警开关", "AlarmSwitch", "0"));
                boilerParameters.Add(new XElement("故障报警开关", AlarmSwitch3));

                int AlarmSwitch4 = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "停炉报警开关", "AlarmSwitch", "0"));
                boilerParameters.Add(new XElement("停炉报警开关", AlarmSwitch4));

                int sleeptime = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "线程休眠时间", "SleepTime", "0"));
                boilerParameters.Add(new XElement("线程休眠时间", sleeptime));

                float StopBoielrFlux = Convert.ToSingle(IniFile.IniReadValue(i.ToString() + "判断停炉流量标准", "StopBoielrFlux", "0"));
                boilerParameters.Add(new XElement("判断停炉流量标准", StopBoielrFlux));

                string odbcName = IniFile.IniReadValue(i.ToString() + "数据源", "odbcName", "0");
                boilerParameters.Add(new XElement("数据源", odbcName));

                int sqlTableNameNum = Convert.ToInt32(IniFile.IniReadValue(i.ToString() + "sql表名编号", "sqlTableNameNum", "1"));
                boilerParameters.Add(new XElement("sql表名编号", sqlTableNameNum));

                string BeginTime = IniFile.IniReadValue(i.ToString() + "开始运行时间", "yearmonthday", DateTime.Now.ToString());
                boilerParameters.Add(new XElement("开始运行时间", BeginTime));
                #endregion

                #region 通道参数
                int tempi = i;
                float BaseNoise;
                float Uplimit;
                float Downlimit;
                float FFT;

                captureCardsParameters = new List<XNode>();
                sensorsParameters = new List<XNode>();
                for (int j = 1; j <= ChannelNumber; j++)
                {
                    BaseNoise = Convert.ToSingle(IniFile.IniReadValue(tempi.ToString() + "基础噪声因子", j.ToString() + "号通道", "0"));
                    Uplimit = Convert.ToSingle(IniFile.IniReadValue(tempi.ToString() + "上限", j.ToString() + "号通道", "4"));
                    Downlimit = Convert.ToSingle(IniFile.IniReadValue(tempi.ToString() + "下限", j.ToString() + "号通道", "0.5"));
                    FFT = Convert.ToSingle(IniFile.IniReadValue(tempi.ToString() + "FFT警戒限", j.ToString() + "号通道", "0"));
                    sensorsParameters.Add(new XElement("Sensor"
                        , new XAttribute("SensorID", sensorID)
                        , new XAttribute("ChannelNumber", j)
                        , new XAttribute("BoilerID", BoilerNo)
                        , new XAttribute("Multiplicative", GeneralFactor)
                        , new XAttribute("BaseNoise", BaseNoise)
                        , new XAttribute("Uplimit", Uplimit)
                        , new XAttribute("Downlimit", Downlimit)
                        , new XAttribute("FFT", FFT)
                    ));
                    sensorID++;
                }
                captureCardsParameters.Add(new XElement("CaptureCard"
                    , new XAttribute("CaptureCardID", i)
                    , new XAttribute("Driver", "AC6623")
                    , new XComment("Sensor 传感器配置 :ChannelNumber 通道序号, BoilerID 锅炉, BaseNoise 基础噪音因子, Uplimit 上限, Downlimit 下限, FFT 警戒限")
                    , sensorsParameters));
                #endregion
            }

            systemParameters.Add(new XElement("SerialPorts", serialPortsParameters));
            systemParameters.Add(new XElement("Boilers", new XElement("Boiler", boilerParameters)));
            systemParameters.Add(new XElement("CaptureCards"
                , new XComment("CaptureCardID 采集卡ID, Driver 驱动. 驱动目前支持: AC6623, AC6623SIM, PC6311, PC6311SIM.")
                , captureCardsParameters));
            #endregion

            config_Xml = new XDocument(
                    new XDeclaration("1.0", "gb2312", "yes")
                    , new XComment("BLD系统配置文件, 非专业人士请勿修改.")
                    , new XComment("Edit by lich @2019-6-16")

                    , new XElement("PowerPlant"    //根节点 
                        , new XAttribute("ID", "随便")
                        , new XAttribute("Name", "吉林开元")
                        , new XAttribute("LastUpdate", DateTime.Now.ToString())
                        , new XAttribute("Description", "电厂信息. 例:吉林开元. PowerPlant是根节点, 每个程序必须有且只能有一个")

                        , new XElement("Server"
                            , new XAttribute("ID", "随便")
                            , new XAttribute("Name", "五号机组BLD")
                            , new XAttribute("Description", "服务器主机信息. 例:五号机组BLD")
                            , systemParameters
                        )
                    )
                );



            textBoxXml.Text = config_Xml.ToString();
        }

        private static Parity GetParity(string FirstCaptionOfParity)
        {
            Parity parity;
            switch (FirstCaptionOfParity)
            {
                case "N":
                    parity = Parity.None;
                    break;
                case "O":
                    parity = Parity.Odd;
                    break;
                case "E":
                    parity = Parity.Even;
                    break;
                case "M":
                    parity = Parity.Mark;
                    break;
                case "S":
                    parity = Parity.Space;
                    break;
                default:
                    parity = Parity.None;
                    break;
            }
            return parity;
        }

        /// <summary>
        /// save config.xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            config_Xml.Save(fileName);
            MessageBox.Show("配置文件保存为:" + fileName);
        }

        /// <summary>
        /// ini 转换为 xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxIni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
