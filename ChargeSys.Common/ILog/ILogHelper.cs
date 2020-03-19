using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Common.ILog
{
    public interface ILogHelper
    {
        void Debug(string Msg);

        void Trace(string Msg);

        void Error(string Msg);
    }
}
