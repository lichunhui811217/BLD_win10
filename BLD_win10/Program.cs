using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration.Assemblies;

using BLD_win10.AppForms;

namespace BLD_win10
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainForm());
        }

        /// <summary>
        /// 读取参数设置
        /// </summary>
        private static void LoaderParameters()
        {
             
        }

        /// <summary>
        /// 初始化一些东西
        /// </summary>
        private static void InitializeComponent()
        {

        }
    }
}
