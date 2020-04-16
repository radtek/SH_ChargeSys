using ChargeSys.Common;
using ChargeSys.Main.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChargeSys.Main
{
    static class Program
    {
        public static System.Threading.Mutex Run;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bRun = false;
            Run = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out bRun);
            if (bRun)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                AppHelper.GetInstance();
                Application.DoEvents();
                Application.Run(new MainForm());
            }
        }
    }
}
