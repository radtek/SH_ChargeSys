using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChargeSys.Scan
{
    public partial class CaptionLabel : UserControl
    {
        public CaptionLabel()
        {
            InitializeComponent();
        }

        [Description("Caption"), Category("自定义")]
        public string Caption
        {
            get
            {
                return labCaption.Text;
            }
            set
            {
                labCaption.Text = value;
            }
        }

        [Description("Text"), Category("自定义")]
        public string Text
        {
            get
            {
                return labText.Text;
            }
            set
            {
                labText.Text = value;
            }
        }

        private void labCaption_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(labText.Text.Trim(), true);
        }
    }
}
