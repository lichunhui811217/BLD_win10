using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.OldCpp
{
    /// <summary>
    /// 通用参数
    /// </summary>
    public class CommonParam
    {
        //成员变量
        //bool  DustClear; //吹灰信号
        public float GenFactor;//总因子
        public float VaporFactor { get; set; } //蒸气流量因子
        public float VaporNoise { get; set; } //蒸气流量噪音因子
        public int SamplingInterval { get; set; } //采样信号
        public int UpDelayTime { get; set; } //泄漏报警延迟时间
        public int LowDelayTime { get; set; }  //堵灰或断路报警延迟时间
        public bool LeakageAlarm { get; set; }  //泄漏报警开关
        public bool BlockAshAlarm { get; set; } //堵灰或断路报警开关
        public bool FaultAlarm { get; set; }  //故障报警开关
        public class dbStruct
        {
            public dbStruct()
            {

            }
            public dbStruct(string odbcName,string HisDataTableName,string HisLimitTableName,string HisXbjlTableName,string xlBjjlTableName,string dhBjjlTableName)
            {

            }

            public string odbcName { get; set; }              //odbc名称
            public string HisDataTableName;      //通道历史数据表
            public string HisLimitTableName;     //历史数据上下限表
            public string HisXbjlTableName;      //小波记录数据表
            public string xlBjjlTableName;       //泄漏报警记录数据表
            public string dhBjjlTableName;      //堵灰报警记录数据表

        }
        //dbParams 
        ;



        //public
        //	 CommonParam();               //Construnctor Function
        //        void setParams(string odbcName, string hisdatatablename, string hislimittablename, string hisxbjltablename, string xlbjjltablename, string dhbjjltablename);
        //        void setGenFactor(int GF);
        //        int showGenFactor();
        //        void setVaporFactor(float VF);
        //        float showVaporFactor();
        //        void setVaporNoise(float VN);
        //        float showVaporNoise();
        //        void setSamplingInterval(int SI);
        //        int showSamplingInterval();
        //        void setUpDelayTime(int UDP);
        //        int showUpDelayTime();
        //        void setLowDelayTime(int LDT);
        //        int showLowDelayTime();
        //        void setLeakageAlarm(bool LA);
        //        bool showLeakageAlarm();
        //        void setBlockAshAlarm(bool BA);
        //        bool showBlockAshAlarm();
        //        void setFaultAlarm(bool FA);
        //        bool showFaultAlarm();

        //        string showodbcTN();
        //        string showhisdataTN();
        //        string showhislimitTN();
        //        string showhisxbjlTN();
        //        string showxlbjjlTN();
        //        string showdhbjjlTN();
        public CommonParam()
        {
        }

        //    void  setGenFactor(int GF)
        //{
        //	GenFactor = GF;
        //}
        //int  showGenFactor()
        //{
        //	return GenFactor;
        //}
        //void  setVaporFactor(float VF)
        //{
        //	VaporFactor = VF;
        //}
        //float  showVaporFactor()
        //{
        //	return VaporFactor;
        //}

        //void  setVaporNoise(float VN)
        //{
        //	VaporNoise = VN;
        //}
        //float  showVaporNoise()
        //{
        //	return VaporNoise;
        //}
        //void  setSamplingInterval(int SI)
        //{
        //	SamplingInterval = SI;
        //}
        //int  showSamplingInterval()
        //{
        //	return SamplingInterval;
        //}
        //void  setUpDelayTime(int UDP)
        //{
        //	UpDelayTime = UDP;
        //}
        //int  showUpDelayTime()
        //{
        //	return UpDelayTime;
        //}
        //void  setLowDelayTime(int LDT)
        //{
        //	LowDelayTime = LDT;
        //}
        //int  showLowDelayTime()
        //{
        //	return LowDelayTime;
        //}
        //void  setLeakageAlarm(bool LA)
        //{
        //	LeakageAlarm = LA;
        //}
        //bool  showLeakageAlarm()
        //{
        //	return LeakageAlarm;
        //}
        //void  setBlockAshAlarm(bool BA)
        //{
        //	BlockAshAlarm = BA;
        //}
        //bool  showBlockAshAlarm()
        //{
        //	return BlockAshAlarm;
        //}
        //void  setFaultAlarm(bool FA)
        //{
        //}
        //bool showFaultAlarm()
        //{
        //    return FaultAlarm;
        //}

        //void setParams(string odbcName, string hisdatatablename, string hislimittablename, string hisxbjltablename, string xlbjjltablename, string dhbjjltablename)
        //{
        //    dbParams.odbcName = odbcName;
        //    dbParams.HisDataTableName = hisdatatablename;
        //    dbParams.HisLimitTableName = hislimittablename;
        //    dbParams.HisXbjlTableName = hisxbjltablename;
        //    dbParams.xlBjjlTableName = xlbjjltablename;
        //    dbParams.dhBjjlTableName = dhbjjltablename;
        //}

        //string showodbcTN()
        //{
        //    return dbParams.odbcName;
        //}

        //string showhisdataTN()
        //{
        //    return dbParams.HisDataTableName;
        //}
        //string showhislimitTN()
        //{
        //    return dbParams.HisLimitTableName;
        //}
        //string showhisxbjlTN()
        //{
        //    return dbParams.HisXbjlTableName;
        //}
        //string showxlbjjlTN()
        //{
        //    return dbParams.xlBjjlTableName;
        //}
        //string showdhbjjlTN()
        //{
        //    return dbParams.dhBjjlTableName;
        //}
    }

    class testCls
    {
        void main()
        {
            CommonParam cp = new CommonParam();
            CommonParam.dbStruct dbs;

            cp.GenFactor = 1.0f;
            float f = cp.GenFactor;
            dbs = new CommonParam.dbStruct();
            dbs.odbcName = "";
            dbs.dhBjjlTableName = "";
        }
    }
}
