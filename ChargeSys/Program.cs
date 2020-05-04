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
                ////处理未捕获的异常，始终将异常传送到 ThreadException 处理程序。忽略应用程序配置文件。   

                //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                ////订阅ThreadException事件，处理UI线程异常，处理方法为 Application_ThreadException，关于事件的相关知识就不在这叙述了  

                //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

                ////订阅UnhandledException事件，处理非UI线程异常 ，处理方法为 CurrentDomain_UnhandledException  

                //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                AppHelper.GetInstance();
                Application.DoEvents();
                Application.Run(new MainForm());
            }




        }


        //static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        //{
        //    string str = "";
        //    string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "/r/n";
        //    Exception error = e.Exception as Exception;
        //    if (error != null)
        //    {
        //        str = string.Format(strDateInfo + "异常类型：{0}/r/n异常消息：{1}/r/n异常信息：{2}/r/n",
        //             error.GetType().Name, error.Message, error.StackTrace);
        //    }
        //    else
        //    {
        //        str = string.Format("应用程序线程错误:{0}", e);
        //    }

        //    if (!Directory.Exists("ErrLog"))
        //    {
        //        Directory.CreateDirectory("ErrLog");
        //    }
        //    writeLog(str);
        //    MessageBox.Show("发生致命错误，请及时联系作者！", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
    }
}
