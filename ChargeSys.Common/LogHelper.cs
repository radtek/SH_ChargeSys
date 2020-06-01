using ChargeSys.Common.ILog;
using HZH_Controls;
using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ChargeSys.Common
{
    public abstract class LogHelper
    {
        //public static Logger logger = LogManager.GetCurrentClassLogger();
        public static ILogHelper _logHelper = new Log(); 

        public static void Error(string msg)
        {
            _logHelper.Error(msg);
            if (AppHelper.MainForm != null)
            {
                ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                {
                    //Size size = new Size(300,900);
                    FrmTips.ShowTips(AppHelper.MainForm,msg,5*1000,true,System.Drawing.ContentAlignment.BottomRight,null,TipsSizeMode.Large, null, TipsState.Error);
                });
            }
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
