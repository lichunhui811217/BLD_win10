﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLD_win10.OldCpp.WriteData
{
    /// <summary>   
    /// 消息CRC校验算法   
    /// </summary>   
    public class CRC
    {

        public static String getCrc16Code(String crcString)
        {

            // 转换成字节数组  
            byte[] creBytes = HexString2Bytes(crcString);

            // 开始crc16校验码计算  
            CRC16Util crc16 = new CRC16Util();
            crc16.reset();
            crc16.update(creBytes);
            int crc = crc16.getCrcValue();
            // 16进制的CRC码  
            String crcCode = Convert.ToString(crc, 16).ToUpper();
            // 补足到4位  
            if (crcCode.Length < 4)
            {
                // crcCode = StringUtil.lefgPadding(crcCode, '0', 4);  
                crcCode = crcCode.PadLeft(4, '0');
            }
            return crcCode;
        }


        public static String RealHexToStr(String str)
        {
            String hText = "0123456789ABCDEF";
            StringBuilder bin = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                bin.Append(hText[str[i] / 16]).Append(hText[str[i] % 16]).Append(' ');
            }
            return bin.ToString();
        }
        /** 
        * 十六进制字符串转换成字节数组 
        *  
        * @param hexstr 
        * @return 
        */
        public static byte[] HexString2Bytes(String hexstr)
        {
            byte[] b = new byte[hexstr.Length / 2];
            int j = 0;
            for (int i = 0; i < b.Length; i++)
            {
                char c0 = hexstr[j++];
                char c1 = hexstr[j++];
                b[i] = (byte)((parse(c0) << 4) | parse(c1));
            }
            return b;
        }


        /** 
        * 16进制char转换成整型 
        *  
        * @param c 
        * @return 
        */
        public static int parse(char c)
        {
            if (c >= 'a')
                return (c - 'a' + 10) & 0x0f;
            if (c >= 'A')
                return (c - 'A' + 10) & 0x0f;
            return (c - '0') & 0x0f;
        }




        public static string ByteArrayToHexString(byte[] data)//字节数组转为十六进制字符串  
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

    }




    public class CRC16Util
    {

        /**CRC值*/
        private int value = 0xffff;

        private static int[] CRC16_TABLE = {
        0x0000, 0x1189, 0x2312, 0x329b, 0x4624, 0x57ad, 0x6536, 0x74bf,
        0x8c48, 0x9dc1, 0xaf5a, 0xbed3, 0xca6c, 0xdbe5, 0xe97e, 0xf8f7,
        0x1081, 0x0108, 0x3393, 0x221a, 0x56a5, 0x472c, 0x75b7, 0x643e,
        0x9cc9, 0x8d40, 0xbfdb, 0xae52, 0xdaed, 0xcb64, 0xf9ff, 0xe876,
        0x2102, 0x308b, 0x0210, 0x1399, 0x6726, 0x76af, 0x4434, 0x55bd,
        0xad4a, 0xbcc3, 0x8e58, 0x9fd1, 0xeb6e, 0xfae7, 0xc87c, 0xd9f5,
        0x3183, 0x200a, 0x1291, 0x0318, 0x77a7, 0x662e, 0x54b5, 0x453c,
        0xbdcb, 0xac42, 0x9ed9, 0x8f50, 0xfbef, 0xea66, 0xd8fd, 0xc974,
        0x4204, 0x538d, 0x6116, 0x709f, 0x0420, 0x15a9, 0x2732, 0x36bb,
        0xce4c, 0xdfc5, 0xed5e, 0xfcd7, 0x8868, 0x99e1, 0xab7a, 0xbaf3,
        0x5285, 0x430c, 0x7197, 0x601e, 0x14a1, 0x0528, 0x37b3, 0x263a,
        0xdecd, 0xcf44, 0xfddf, 0xec56, 0x98e9, 0x8960, 0xbbfb, 0xaa72,
        0x6306, 0x728f, 0x4014, 0x519d, 0x2522, 0x34ab, 0x0630, 0x17b9,
        0xef4e, 0xfec7, 0xcc5c, 0xddd5, 0xa96a, 0xb8e3, 0x8a78, 0x9bf1,
        0x7387, 0x620e, 0x5095, 0x411c, 0x35a3, 0x242a, 0x16b1, 0x0738,
        0xffcf, 0xee46, 0xdcdd, 0xcd54, 0xb9eb, 0xa862, 0x9af9, 0x8b70,
        0x8408, 0x9581, 0xa71a, 0xb693, 0xc22c, 0xd3a5, 0xe13e, 0xf0b7,
        0x0840, 0x19c9, 0x2b52, 0x3adb, 0x4e64, 0x5fed, 0x6d76, 0x7cff,
        0x9489, 0x8500, 0xb79b, 0xa612, 0xd2ad, 0xc324, 0xf1bf, 0xe036,
        0x18c1, 0x0948, 0x3bd3, 0x2a5a, 0x5ee5, 0x4f6c, 0x7df7, 0x6c7e,
        0xa50a, 0xb483, 0x8618, 0x9791, 0xe32e, 0xf2a7, 0xc03c, 0xd1b5,
        0x2942, 0x38cb, 0x0a50, 0x1bd9, 0x6f66, 0x7eef, 0x4c74, 0x5dfd,
        0xb58b, 0xa402, 0x9699, 0x8710, 0xf3af, 0xe226, 0xd0bd, 0xc134,
        0x39c3, 0x284a, 0x1ad1, 0x0b58, 0x7fe7, 0x6e6e, 0x5cf5, 0x4d7c,
        0xc60c, 0xd785, 0xe51e, 0xf497, 0x8028, 0x91a1, 0xa33a, 0xb2b3,
        0x4a44, 0x5bcd, 0x6956, 0x78df, 0x0c60, 0x1de9, 0x2f72, 0x3efb,
        0xd68d, 0xc704, 0xf59f, 0xe416, 0x90a9, 0x8120, 0xb3bb, 0xa232,
        0x5ac5, 0x4b4c, 0x79d7, 0x685e, 0x1ce1, 0x0d68, 0x3ff3, 0x2e7a,
        0xe70e, 0xf687, 0xc41c, 0xd595, 0xa12a, 0xb0a3, 0x8238, 0x93b1,
        0x6b46, 0x7acf, 0x4854, 0x59dd, 0x2d62, 0x3ceb, 0x0e70, 0x1ff9,
        0xf78f, 0xe606, 0xd49d, 0xc514, 0xb1ab, 0xa022, 0x92b9, 0x8330,
        0x7bc7, 0x6a4e, 0x58d5, 0x495c, 0x3de3, 0x2c6a, 0x1ef1, 0x0f78
    };

        /** 
         * 计算一个字节数组的CRC值 
         * @param data 
         */
        public void update(byte[] data)
        {
            //int fcs = 0xffff;  
            for (int i = 0; i < data.Length; i++)
            {
                // 1.value 右移8位(相当于除以256)  
                // 2.value与进来的数据进行异或运算后再与0xFF进行与运算  
                //    得到一个索引index，然后查找CRC16_TABLE表相应索引的数据  
                // 1和2得到的数据再进行异或运算。  
                value = (value >> 8) ^ CRC16_TABLE[(value ^ data[i]) & 0xff];
            }
            // 取反  
            //return ~fcs;  
        }

        /** 
         * 计算一个byte的CRC值 
         *  
         * @param aByte 
         */
        public void update(byte aByte)
        {
            value = (value >> 8) ^ CRC16_TABLE[(value ^ aByte) & 0xff];
        }

        /** 
         * 重新设定CRC初始值 
         */
        public void reset()
        {
            value = 0xffff;
        }

        /** 
         * 获取计算好的CRC值 
         *  
         * @return 
         */
        public int getCrcValue()
        {
            return ~value & 0xffff;
        }

        /// <summary>  
        /// 生成FCS校验值  
        /// </summary>  
        /// <param name="ccc"></param>  
        /// <returns></returns>  
        public static byte[] makeCrc16(byte[] ccc)
        {

            CRC16Util crc16 = new CRC16Util();
            crc16.reset();
            crc16.update(ccc);
            //Console.WriteLine(RealHexToStr(crc16.getCrcValue().ToString()));  
            byte[] test = intToByte(crc16.getCrcValue());
            //log(RealHexToStr(crc16.getCrcValue().ToString()));  
            return test;

        }

        private static int[] copy(byte[] aa)
        {
            int[] cc = new int[aa.Length];
            for (int i = 0; i < aa.Length; i++)
            {
                cc[i] = aa[i];
            }
            return cc;
        }

        public static byte[] intToByte(int i)
        {
            byte[] abyte0 = new byte[4];
            abyte0[0] = (byte)(0xff & i);
            abyte0[1] = (byte)((0xff00 & i) >> 8);
            abyte0[2] = (byte)((0xff0000 & i) >> 16);
            abyte0[3] = (byte)((0xff000000 & i) >> 24);
            return abyte0;
        }

        private static void log(Object obj)
        {
            //(obj);  
        }

        private static void printBytes(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                //System.out.print(bytes[i]+ "-");  
            }
        }

        public static String RealHexToStr(String str)
        {
            String hText = "0123456789ABCDEF";
            StringBuilder bin = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                bin.Append(hText[str[i] / 16]).Append(hText[str[i] % 16]).Append(' ');
            }
            return bin.ToString();
        }

    }

    class CRC2
    {

        /// <summary>
        /// CRC校验//--------------------- 
        /// 作者：koloumi
        /// 来源：CSDN
        /// 原文：https://blog.csdn.net/koloumi/article/details/69808783 
        /// 版权声明：本文为博主原创文章，转载请附上博文链接！
        /// </summary>
        /// <param name="data">校验数据</param>
        /// <returns>高低8位</returns>
        public static string CRCCalc(string data)
        {
            string[] datas = data.Split(' ');
            List<byte> bytedata = new List<byte>();

            foreach (string str in datas)
            {
                bytedata.Add(byte.Parse(str, System.Globalization.NumberStyles.AllowHexSpecifier));
            }
            byte[] crcbuf = bytedata.ToArray();
            //计算并填写CRC校验码
            int crc = 0xffff;
            int len = crcbuf.Length;
            for (int n = 0; n < len; n++)
            {
                byte i;
                crc = crc ^ crcbuf[n];
                for (i = 0; i < 8; i++)
                {
                    int TT;
                    TT = crc & 1;
                    crc = crc >> 1;
                    crc = crc & 0x7fff;
                    if (TT == 1)
                    {
                        crc = crc ^ 0xa001;
                    }
                    crc = crc & 0xffff;
                }

            }
            string[] redata = new string[2];
            redata[1] = Convert.ToString((byte)((crc >> 8) & 0xff), 16);
            redata[0] = Convert.ToString((byte)((crc & 0xff)), 16);

            //return FormatHEX(redata[0]) + " " + FormatHEX(redata[1]);
            return redata[0] + " " + redata[1];
        }
        
    }
}
