using ChargeSys.Common.ILog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Common
{
    public abstract class LogHelper
    {
        //public static Logger logger = LogManager.GetCurrentClassLogger();
        public static ILogHelper _logHelper = new Log(); 

        public static void Error(string msg)
        {
            _logHelper.Error(msg);
        }

        public static void Debug(string msg)
        {
            _logHelper.Debug(msg);
        }

        public static void Trace(string msg)
        {
            _logHelper.Trace(msg);
        }
    }
}
