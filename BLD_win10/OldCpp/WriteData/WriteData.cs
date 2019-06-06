using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.OldCpp.WriteData
{
    struct bangtudata
    {
        int ID;
        int ChanelNumber;
        DateTime NowTime;
        //float Bangtu[MAX_CHANNEL];   // 棒图数据
        //float sx[MAX_CHANNEL];  // 上限
        //float xx[MAX_CHANNEL];  // 下限
        int BoilerStatus;
    };

    struct historydata
    {
        int ID;
        int ChanelNumber;
        DateTime NowTime;
        //short Data[MAX_CHANNEL];
        //bool BlockAsh[MAX_CHANNEL];
        //short sx[MAX_CHANNEL];
        //short DustClear;      // 是否吹灰
        //short VaporFlux;      // 流量
        //int Sy;
        //////
        //int DataProb[MAX_CHANNEL];
        //short Maxprob;
    };

    class WriteData
    {
        public WriteData(bool CreateSuspended, int vChanelNumber, /*TDataCenter* dc, TChanelParams* cp, */int vBoilerNo)
        {
            //Acc = 0;
            //ChanelNumber = vChanelNumber;
            //DataCenter = dc;
            //ChanelParams = cp;
            //Skip = 0;
            //this->FreeOnTerminate = false;
            //BoilerNo = vBoilerNo;
            //Skip1 = 1;
        }

        public void Execute()
        {
            //System::AnsiString AppPath1 = ExtractFilePath(Application->ExeName);
            //TIniFile* myPath = new TIniFile(AppPath1 + "DataPath.INI");
            //DataFilePath = myPath->ReadString("数据临时存放路径", "DataPath", DataFilePath);
            //delete myPath;
            //if (DataFilePath == NULL)
            //    DataFilePath = ExtractFilePath(Application->ExeName);

            //while (!Terminated)
            //{
            //    Skip++;
            //    Skip1++;
            //    if (Skip1 > 1000) Skip1 = 1;
            //    writebangtu();
            //    if (Skip >= 120)
            //    {
            //        writehistory();
            //        Skip = 0;
            //    }
            //    Sleep(5000);
            //}
        }

        public void writebangtu()
        {
            //float* Bangtu = new float[MAX_CHANNEL];
            //int* Status = new int[MAX_CHANNEL];
            //float* sx = new float[MAX_CHANNEL];
            //float* xx = new float[MAX_CHANNEL];
            //int BoilerStatus;

            //for (int i = 0; i < ChanelNumber; i++)
            //{
            //    Bangtu[i] = 0;
            //    sx[i] = 0;
            //    xx[i] = 0;
            //}
            //DataCenter->showTFT(Bangtu, Status);
            //ChanelParams->showUpLimitA(sx);
            //ChanelParams->showLowLimitA(xx);
            //BoilerStatus = DataCenter->showBoilerStatus();
            //TDateTime NowTime = Now();

            //struct bangtudata s;
            //for (int i = 0; i<ChanelNumber; i++)
            //{
            // s.Bangtu[i] = Bangtu[i];
            // s.sx[i] = sx[i];
            // s.xx[i] = xx[i];
            //}
            //   s.NowTime = NowTime;
            //s.BoilerStatus = BoilerStatus;
            //s.ID = Skip;
            //s.ChanelNumber = ChanelNumber;

            //char ParaName[200];
            //   char temp_ParaName[200];
            //   strcpy(ParaName, DataFilePath.c_str());
            //   strcpy(temp_ParaName, "bangtufiles");
            //   temp_ParaName[11] = BoilerNo + '0';
            //temp_ParaName[12] = '\0';
            //StrCat(ParaName, temp_ParaName);
            //if ((stream = fopen(ParaName, "wb")) != NULL)
            //{
            // fwrite(&s, sizeof(s), 1, stream);
            //       fclose(stream);
            //   }

            //delete xx;
            //delete sx;
            //delete Status;
            //delete Bangtu;

        }

        public void writehistory()
        {
            /*
            // 计算索引值（抽点用）
            int Sy = 0;  // 索引，对应表中的Sy字段，抽条用
            if (Acc == ((long)(Acc / 2)) * 2)
            {
                Sy = 1;
                if (Acc == ((long)(Acc / 4)) * 4)
                {
                    Sy = 2;
                    if (Acc == ((long)(Acc / 8)) * 8)
                    {
                        Sy = 3;
                        if (Acc == ((long)(Acc / 16)) * 16)
                        {
                            Sy = 4;
                            if (Acc == ((long)(Acc / 32)) * 32)
                            {
                                Sy = 5;
                                if (Acc == ((long)(Acc / 64)) * 64)
                                {
                                    Sy = 6;
                                }
                            }
                        }
                    }
                }
            }
            Acc++;

            // 读取数据
            short* Data = new short[MAX_CHANNEL];   // 通道历史数据
            short* sx = new short[MAX_CHANNEL];  // 上限
            short* xb = new short[MAX_CHANNEL];  // 小波
            bool* BlockAsh = new bool[MAX_CHANNEL];  // 吹灰
            short DustClear;      // 是否吹灰
            short VaporFlux;      // 流量
            bool Save;            // 是否写报警记录

            for (int i = 0; i < ChanelNumber; i++)
            {
                Data[i] = 0;
                sx[i] = 0;
                xb[i] = 0;
                BlockAsh[i] = 0;
            }
            DataCenter->SqlHisData(&Save, Data, sx, xb, &DustClear, BlockAsh, &VaporFlux);
            TDateTime NowTime = Now();

            int* DataProb = new int[MAX_CHANNEL];
            int tempn;
            short maxprob;
            DataCenter->showLeakageProb(&tempn, DataProb);
            maxprob = DataCenter->SqlShowMaxProb();

            ////////////////////////////////
            struct historydata s;
	        for (int i = 0; i<ChanelNumber; i++)
	        {
		        s.Data[i] = Data[i];
		        s.BlockAsh[i] = BlockAsh[i];
		        s.sx[i] = sx[i];
		        s.DataProb[i] = DataProb[i];
	        }
            s.ID = Skip1;
	        s.NowTime = NowTime;
	        s.DustClear = DustClear;
	        s.VaporFlux = VaporFlux;
	        s.Sy = Sy;
	        s.Maxprob = maxprob;
	        s.ChanelNumber = ChanelNumber;

	        ///////////////////////////////////////////
	        char ParaName[200];
            char temp_ParaName[200];
            strcpy(ParaName, DataFilePath.c_str());
            strcpy(temp_ParaName, "sqlhisfiles");
            temp_ParaName[11] = BoilerNo + '0';
	        temp_ParaName[12] = '\0';
	        StrCat(ParaName, temp_ParaName);
	        if ((stream = fopen(ParaName, "wb")) != NULL)
	        {
		        fwrite(&s, sizeof(s), 1, stream);
                fclose(stream);
            }

            ////////////////////////////////
            delete Data;
            delete sx;
            delete xb;
            delete BlockAsh;
            delete DataProb;
            */
        }
    }
}
