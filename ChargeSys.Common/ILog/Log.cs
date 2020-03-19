using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Common.ILog
{
    public class Log : ILogHelper
    {
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        public void Debug(string Msg)
        {
            _logger.Debug(Msg);
        }

        public void Error(string Msg)
        {
            _logger.Error(Msg);
        }

        public void Trace(string Msg)
        {
            _logger.Trace(Msg);
        }
    }
}
