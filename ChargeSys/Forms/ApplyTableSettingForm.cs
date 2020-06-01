using ChargeSys.Common;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Main.Forms
{
    public partial class ApplyTableSettingForm : FrmWithTitle
    {
        public ApplyTableSettingForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            pointFiller.DisplayEntity(AppHelper.ApplyPointSetting);
        }

        private void btnSavePoint_Click(object sender, EventArgs e)
        {
            pointFiller.FillEntity(AppHelper.ApplyPointSetting);
            File.WriteAllText(AppHelper.ApplyConfigPath, JsonConvert.SerializeObject(AppHelper.ApplyPointSetting, Formatting.Indented));
            FrmTips.ShowTipsSuccess(AppHelper.MainForm,"保存成功",ContentAlignment.MiddleCenter);
        }
    }
}
