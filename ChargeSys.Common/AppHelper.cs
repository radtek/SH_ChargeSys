using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Common
{
    public class AppHelper
    {
        private static AppHelper _appHelper = null;
        //配置文件夹路径
        public static string ConfigFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs");

        public static string DbConfigFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configs", "DbConfig.json");

        public static Form MainForm = null;

        public static volatile object AppLocker = new object();
        public AppHelper()
        {

        }
    }
}
