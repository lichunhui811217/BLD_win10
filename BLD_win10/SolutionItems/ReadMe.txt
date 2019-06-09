
[log]:

[2019-6-7]
增加CRC.cs, 把 WriteDataCom.cs, WriteDataDTU.cs 中的 CRC 校验部分抽象出来使用.
整理旧程序:
	WriteDataDTU.cs
	WriteDataUdp.cs
	BjqxForm.cs //报警曲线
	CdwzForm	//测点位置
		TL_Form1	//测点位置调用TL1-TL4窗体 只做了TL1的复制工作.
		TL2
		TL3
		TL4
	ChanelCheck	//通道检查
	CommonParam	//通用参数
	Constant.cs //常数类(是否应该和通用参数合并?)
	TcyForm		//TODO:去公司再看,不知道是啥窗口. **被实时ShshiParent引用.

[2019-6-6]
整理旧程序(*.cpp -> *.cs):
	aboutunit.cs
	Alarm.cs
	BjjlForm.cs //报警记录
	WriteData.cs
	WriteDataCom.cs