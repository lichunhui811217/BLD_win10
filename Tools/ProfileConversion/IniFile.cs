using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ProfileConversion
{
    public static class IniFile
    {
        public const string Path = @"d:\glsys\glsys.ini";

        //public IniFile(string path)
        //{
        //    this.Path = path;
        //}
        
        #region 声明读写INI文件的API函数 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        [DllImport("kernel32")] 
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath); 

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath); 

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string defVal, Byte[] retVal, int size, string filePath);
        #endregion

        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">键</param>
        /// <param name="iValue">值</param>
        public static void IniWriteValue(string section, string key, string iValue)
        {
            WritePrivateProfileString(section, key, iValue, Path);
        }

        /// <summary>
        /// 读取INI文件
        /// </summary>
        /// <param name="section">段落</param>
        /// <param name="key">键</param>
        /// <param name="defValue">默认值</param>
        /// <returns>返回的键值</returns>
        public static string IniReadValue(string section, string key, string defValue)
        {
            StringBuilder temp = new StringBuilder(255);

            int i = GetPrivateProfileString(section, key, defValue, temp, 255, Path);

            return temp.ToString();
        }

        /// <summary>
        /// 读取INI文件
        /// </summary>
        /// <param name="Section">段，格式[]</param>
        /// <param name="Key">键</param>
        /// <param name="defValue">默认值</param>
        /// <returns>返回byte类型的section组或键值组</returns>
        public static byte[] IniReadValues(string section, string key, string defValue)
        {
            byte[] temp = new byte[255];

            int i = GetPrivateProfileString(section, key, defValue, temp, 255, Path);
            return temp;
        }
    }
}