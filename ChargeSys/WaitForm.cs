using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChargeSys.Main
{
    public partial class WaitForm : Form
    {
        private EventHandler<EventArgs> _method;
        private IAsyncResult asyncResult;
        public WaitForm(EventHandler<EventArgs> EventHandler,string msg)
        {
            InitializeComponent();
            _method = EventHandler;
            timer1.Start();
            labTips.Text = msg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (asyncResult != null && asyncResult.IsCompleted)
                this.Close();
        }

        private void WaitForm_Shown(object sender, EventArgs e)
        {
            if (_method != null)
                asyncResult = _method.BeginInvoke(null, null, null, null);
            else
                this.Close();
        }


    }
}
