using ChargeSys.Common;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Main.Forms
{
    public partial class SysSettingForm : FrmWithTitle
    {
        public SysSettingForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            settingFiller.DisplayEntity(AppHelper.AppSetting);
            string tt = string.Empty;
            PrintDocument prtdoc = new PrintDocument();
            List<string> list = new List<string>();
            foreach (String str in PrinterSettings.InstalledPrinters)
            {
                combPrinter.Items.Add(str);
            }
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            settingFiller.FillEntity(AppHelper.AppSetting);
            File.WriteAllText(AppHelper.SettingPath, JsonConvert.SerializeObject(AppHelper.AppSetting, Formatting.Indented));
            FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功", ContentAlignment.MiddleCenter);
        }
    }
}
