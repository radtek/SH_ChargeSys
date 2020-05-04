using ChargeSys.Common;
using ChargeSys.Common.Dtos;
using ChargeSys.Core.DicDefine;
using ChargeSys.Core.Service;
using ChargeSys.Entitys;
using HZH_Controls;
using HZH_Controls.Forms;
using Newtonsoft.Json;
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
    public partial class MainForm : FrmWithTitle
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Init()
        {         
            ScanService.SetAction(Print);
            ScanService.Work();
            ScanService.Satrt();
        }

        private void Print(string s)
        {
            ControlHelper.ThreadInvokerControl(this, () =>
            {
                try
                {
                    X18J52 entity = JsonConvert.DeserializeObject<X18J52>(s);
                    if (entity != null)
                    {
                        LogHelper.Trace("开始取号……");
                        CallEntity call = CallService.GetNo("普通车".Equals(entity.BusinessType) ? "B" : "A", entity.hphm);
                        CallOptForm callOptForm;
                        if ("1".Equals(call.State))
                        {
                            callOptForm = new CallOptForm(entity.hphm, call.ClientId, call.WaitCount);
                            (new ApplyTable(entity, call.ClientId)).CreatePDF();
                        }
                        else
                            callOptForm = new CallOptForm(entity.hphm, $"异常代码{call.State}", $"异常代码{SHDic.GetSHDeifine(call.State) ?? "未定义异常"}");
                        callOptForm.ShowDialog(this);
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Trace($"取号异常：{ex.Message}");
                }
            });
        }

        private void Clear()
        {
            this.labTips.Text = "请扫码取号……";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Init();
            //ApplyTable applyTable = new ApplyTable(null,"11");
            //Bitmap bitmap = applyTable.CreatePDF();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ScanService.Close();
        }
    }
}
