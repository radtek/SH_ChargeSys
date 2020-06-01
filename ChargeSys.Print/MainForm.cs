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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Print
{
    public partial class MainForm : FrmWithTitle
    {
        private static Dictionary<string, DateTime> _dicPlateNo = new Dictionary<string, DateTime>();

        public MainForm()
        {
            InitializeComponent();
            AppHelper.MainForm = this;
        }

        private void Init()
        {
            ScanService.SetAction(Print);
            ScanService.Work();
            ScanService.Satrt();
        }

        private static volatile object _lockObj = new object();
        private void Print(string s)
        {
                
 
                try
                {
                    ControlHelper.ThreadInvokerControl(this, () =>
                    {
                        lock (_lockObj)
                        {
                            try
                            {

                                X18J52 entity = JsonConvert.DeserializeObject<X18J52>(s);
                                if (entity != null)
                                {
                                    LogHelper.Trace($"处理数据[{entity.hphm}][{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]");
                                    if (_dicPlateNo.ContainsKey(entity.hphm))
                                        LogHelper.Trace($"上次处理时间[{entity.hphm}][{_dicPlateNo[entity.hphm].ToString("yyyy-MM-dd HH:mm:ss")}]");
                                    else
                                        LogHelper.Trace($"没有重复记录[{entity.hphm}]");
                                    if (_dicPlateNo.ContainsKey(entity.hphm) && _dicPlateNo[entity.hphm].AddSeconds(8) >= DateTime.Now)
                                    {
                                        LogHelper.Trace("重复扫码");
                                    }
                                    else
                                    {
                                        _dicPlateNo[entity.hphm] = DateTime.Now;
                                        LogHelper.Trace("开始取号……");
                                        string ticketType = "普通车".Equals(entity.BusinessType) ? "B" : "A";
                                        CallEntity call = CallService.GetNo(ticketType, entity.hphm);
                                        CallOptForm callOptForm;
                                        if ("1".Equals(call.State))
                                        {
                                            callOptForm = new CallOptForm(entity.hphm, call.ClientId, call.WaitCount);
                                            try
                                            {
                                                string ticket = ("B".Equals(ticketType) ? "普通车" : "网约车") + $":{call.ClientId}";
                                                ApplyTable applyTable = new ApplyTable(new CarInfo()
                                                {
                                                    PlateNo = entity.hphm,
                                                    Owner = entity.syr,
                                                    PlateType = AppHelper.GetNameByCode(entity.hpzl, "HPZL")
                                                }, ticket);
                                                applyTable.PrintMsg();
                                            }
                                            catch (Exception ex)
                                            {
                                                LogHelper.Error($"打印异常：{ex.Message}");
                                            }
                                        }
                                        else
                                            callOptForm = new CallOptForm(entity.hphm, $"异常代码{call.State}", $"异常代码{SHDic.GetSHDeifine(call.State) ?? "未定义异常"}");
                                        callOptForm.ShowDialog(this);
                                        _dicPlateNo[entity.hphm] = DateTime.Now;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                LogHelper.Trace($"取号异常：{ex.Message}");
                            }
                        }
                    });
                }
                catch (Exception ex)
                {
                    LogHelper.Error("打印异常"+ex.Message);
                }
            
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

        private void ami_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
