using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.OldCpp.WriteData
{
    class WriteDataUdp
    {
        //TNMUDP* NMUDP_Send;//Detry change 2002.4.23
        //int Skip;
        //int Skip1;
        //int Acc;//抽样用
        //AnsiString DataFilePath;
        //int BoilerNo;
        //int boilerbh[4];    //Detry change 2002.4.23
        //int intChannelNo[4];//Detry change 2002.4.23
        //int DataProb[MAX_CHANNEL];   //Detry change 2002.4.23
        //short hisData[MAX_CHANNEL];  //Detry change 2002.4.23
        //short sx[MAX_CHANNEL];       //Detry change 2002.4.23
        //float Bangtu[MAX_CHANNEL];
        //int Status[MAX_CHANNEL];

        //short maxprob;
        //short DustClear;
        //short VaporFlux;
        //unsigned short intPackageLength;
        //short intMaxChannel;

        WriteDataUdp(bool CreateSuspended, int vBoilerNo)
        {
            //Acc = 0;
            //Skip = 0;
            //this->FreeOnTerminate = false;
            //BoilerNo = vBoilerNo;
            //Skip1 = 1;
            //for (int i = 0; i < MAX_CHANNEL; i++)
            //{
            //    DataProb[i] = 0; //泄漏概率
            //    sx[i] = 0;       //报警上限
            //    hisData[i] = 0;  //历史曲线
            //    Bangtu[i] = 0;
            //    Status[i] = 0;
            //}
            //maxprob = 0;         //最大泄漏概率
            //DustClear = 0;       //主蒸汽流量
            //VaporFlux = 0;       //堵灰
            //intPackageLength = 0;
            //intMaxChannel = 0;
        }

        /// <summary>
        /// 初始化com口
        /// </summary>
        void Execute()
        {
            //
        }

        /// <summary>
        /// UDP定义包,发包
        /// </summary>
        /// <param name="bh"></param>
        /// <param name="xh"></param>
        void writebar_Mone(int bh, int xh)
        {
            ////---------------------------------------------------------------------------------------------------
            ////广播包格式：
            //// 机组号（2）+ 起始ID号（2）+ 数据报长度（2）+ 测点数据1（6） + 测点数据2（6） + …… + 测点数据n（6）
            ////测点数据格式：
            ////  测点状态（__int2）+ 模拟量（float）
            ////函数内 M_Copy 见宏定义
            ////----------------------------------------------------------------------------------------------------

            //	intMaxChannel = intChannelNo[bh]; //通道数
            //	//初始化广播数据
            //	//定义包字节数
            //	intPackageLength = sizeof(unsigned short) * 3 + ((sizeof(float)+sizeof(unsigned short)) * intMaxChannel + (sizeof(float)+sizeof(unsigned short))) * 2; // 计算广播包长度 Detry add 2002.4.23
            //	//初始化包缓冲区
            // //	char *btbuffer = new char[intPackageLength];
            //	char btbuffer[1024];
            //char* p;    // p指向广播包寄存器首地址

            //MForm->DataCenter[bh]->showTFT(Bangtu, Status); //取实时棒图数据 赋Bangtu&Status

            //unsigned short w_xh = (unsigned short)xh; // w_xh为锅炉编号副本

            //	p = &btbuffer[0];
            ////	p = btbuffer;
            //	memcpy(p, (char*)(&w_xh),sizeof((unsigned short)xh)); //将锅炉编号写至btbuffer起始位置
            //	p += sizeof(unsigned short); //指针指向锅炉编号末尾，准备写下一个数据

            //	unsigned short b_StartID = H_StartID; //初始化起始ID号=0
            //M_Copy(b_StartID); // 写起始ID号至btbuffer

            ////第一个数据包：各通道实时值+各通道历史值+吹灰值+流量值
            ////	WORD length=498;
            ////	M_Copy(length);
            //M_Copy(intPackageLength); //写数据包长度至btbuffer


            //unsigned short i_Status = 0;    //声名测点状态临时变量
            //float i_fValue = 0.0f;   //声明测点值临时变量

            //	//各通道实时棒图值和状态值
            //	for(int i=0;i<intMaxChannel;i++){
            //		switch(Status[i]){
            //			case 1:           //越上限
            //				i_Status=7;
            //				break;
            //			case 2:           //越下限
            //				i_Status=1;
            //				break;
            //			case 3:           //泄漏报警
            //				i_Status=15;
            //				break;
            //			case 4:           //堵灰
            //				i_Status=9;
            //				break;
            //			default:          //正常
            //				i_Status=0;
            //		}
            //		M_Copy(i_Status);     //写测点状态至btbuffer
            //i_fValue=Bangtu[i];   //复制该通道棒图值
            //		M_Copy(i_fValue);     //写该通道棒图值至btbuffer
            //	}

            //	writehis_Mone(bh, intMaxChannel); //取历史曲线数据及上限值

            //	for(int i=intMaxChannel;i<intMaxChannel*2;i++){
            //		i_Status=0;         //设测点状态值为0
            //		M_Copy(i_Status);   //写测点状态值至btbuffer
            //i_fValue=hisData[i - intMaxChannel]/10.0; //复制历史通道值
            //		M_Copy(i_fValue);   //写历史值至btbuffer
            //	}

            //	i_Status=0;          //设测点状态值为0
            //	M_Copy(i_Status);    //写测点状态值至btbuffer

            //	if(DustClear){       //是否吹灰
            //		i_fValue=1;
            //	}else{
            //		i_fValue=0;
            //	}

            //	M_Copy(i_fValue);   //写吹灰值至btbuffer
            //i_Status=0;
            //	M_Copy(i_Status);   //写测点状态值为0至btbuffer
            //i_fValue=VaporFlux/10.0;  //取蒸汽流量值
            //	M_Copy(i_fValue);         //写流量值至btbuffer

            ////第一个数据包准备完毕，发送
            //NMUDP_Send->SendBuffer(btbuffer,sizeof(btbuffer),sizeof(btbuffer));

            ////----------------------------------------------------------------------------

            //p=&btbuffer[0]; //p重新指向btbuffer首地址

            //	memcpy(p, (char*)(&w_xh),sizeof((unsigned short)xh));  //写机组号至btbuffer
            //	p += sizeof(unsigned short);                             //指针移至机组号末尾
            //	b_StartID = intMaxChannel* 2 + 2;         //计算起始ID号
            //	M_Copy(b_StartID);                           //写起始ID号至btbuffer
            //                                                 //	length=498;
            //                                                 //	M_Copy(length);
            //M_Copy(intPackageLength); //写包长度至btbuffer

            //	for(int i=0;i<intMaxChannel;i++){ //写各通道上限值至btbuffer
            //		i_Status=0;
            //		M_Copy(i_Status);
            //i_fValue=sx[i]/10.0;
            //		M_Copy(i_fValue);
            //	 }
            //	for(int i=0;i<intMaxChannel;i++){ // 写各通道泄漏概率
            //		i_Status=0;
            //		M_Copy(i_Status);
            //i_fValue=DataProb[i];
            //		M_Copy(i_fValue);
            //	}
            //	i_Status=0;
            //	M_Copy(i_Status);
            //i_fValue=maxprob;
            //	M_Copy(i_fValue); //写最大泄漏概率
            //                      //发送第二个数据包
            //NMUDP_Send->SendBuffer(btbuffer,sizeof(btbuffer),sizeof(btbuffer));
        }

        /// <summary>
        /// 
        /// </summary>
        void writehis_Mone(
            //int bh,const int intChannelCount
            )
        {

            //short xb[MAX_CHANNEL];  // 小波
            //    bool BlockAsh[MAX_CHANNEL];  // 吹灰
            //    bool Save;            // 是否写报警记录

            //    MForm->DataCenter[bh]->SqlHisData(&Save, hisData, sx, xb,&DustClear, BlockAsh,&VaporFlux);
            //    int tempn;
            //    MForm->DataCenter[bh]->showLeakageProb(&tempn, DataProb);
            //    maxprob=MForm->DataCenter[bh]->SqlShowMaxProb();
        }
    }
}
