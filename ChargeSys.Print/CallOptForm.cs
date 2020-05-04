using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Print
{
    public partial class CallOptForm : FrmWithTitle
    {
        public CallOptForm(string plateNo,string no,string count)
        {
            InitializeComponent();
            this.Title = plateNo;
            this.labNo.Text = no;
            this.labCount.Text = count;
            timer1.Interval = 5 * 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
