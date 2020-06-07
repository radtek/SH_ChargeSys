using ChargeSys.Common;
using ChargeSys.Common.Dtos;
using ChargeSys.Core;
using ChargeSys.Core.Service;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
using ChargeSys.Main.Tools;
using HZH_Controls;
using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Main.Forms
{
    public partial class ChargeForm : FrmWithTitle
    {
        private CarInfo _carInfo = null;
        private static bool WinVisible = true;
        private Form form = null;
        private decimal TOTAL_PRICE = 0;
        private List<Tuple<string, int, decimal>> ItemList = new List<Tuple<string, int, decimal>>();

        public ChargeForm()
        {
            InitializeComponent();
            labPrice.Text = "";
            form = this;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string test = "检验流水号: 11003718083100081"
                                + "号牌号码: 京EBX815"
                                + "车辆类型: 小型轿车"
                                + "检测项目: 制动,灯光,策划"
                                + "检测次数: 制动 1 次,灯光 10 次"
                                + "引车员: 尚小楠"
                                + "检测时间: 2018-09-01 08:11:26";
            ScanService.EnQueue(test);

        }

        private void ExplainText(string s)
        {
            if (!WinVisible) return;

            ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
            {
                Clear();
                ControlHelper.ThreadRunExt(AppHelper.MainForm, () =>
                {
                    FeeTools feeTools = new FeeTools();
                    _carInfo = new CarInfo();
                    _carInfo.TestNo = RegexVal(s, @"检验流水号:(.*)号牌号码");
                    _carInfo.PlateNo = RegexVal(s, @"号牌号码:(.*)车辆类型");
                    _carInfo.CarType = RegexVal(s, @"车辆类型:(.*)检测项目");
                    _carInfo.TestItem = RegexVal(s, @"检测项目:(.*)检测次数");
                    string testTimes = RegexVal(s, @"检测次数:(.*)引车员");
                    _carInfo.Guider = RegexVal(s, @"引车员:(.*)检测时间");
                    _carInfo.TestDate = RegexVal(s, @"检测时间:(.*)");
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        //处理检验项目和检验次数
                        string[] testItems = _carInfo.TestItem.Split(',');
                        for (int i = 0; i < testItems.Length; i++)
                        {
                            int times = RegexVal(testTimes, $@"{testItems[i]}(.*?)次").ToInt();
                            decimal price = CalPrice(feeTools, testItems[i].Trim(), times);
                            ItemList.Add(new Tuple<string, int, decimal>(testItems[i].ToString(), times, price));
                            var item = new ListViewItem(new string[] { testItems[i], times.ToString(), price.ToString() });
                            materialListView1.Items.Add(item);
                        }


                        foreach (var item in ItemList)
                        {
                            TOTAL_PRICE += item.Item3;
                        }
                        _carInfo.Price = TOTAL_PRICE;
                        carFiller.DisplayEntity(_carInfo);
                        labPrice.Text = ExtendMethod.MoneyToCap(TOTAL_PRICE);
                    });
                }, null, AppHelper.MainForm, true, "", 200);
            });


        }

        private void Clear()
        {
            ItemList.Clear();
            TOTAL_PRICE = 0;
            carFiller.DisplayEntity(null);
            materialListView1.Items.Clear();
        }

        private decimal CalPrice(FeeTools feeTools, string itemName, int times)
        {
            decimal itemPrice = 0;
            decimal firstPrice = feeTools.GetCharge(itemName, 1); //初检费用
            itemPrice += firstPrice;

            for (int i = 2; i <= times; i++)
            {
                itemPrice += feeTools.GetCharge(itemName, i);
            }
            return itemPrice;
        }

        private string RegexVal(string source, string pattern)
        {
            Regex regex = new Regex(pattern);
            Match match = regex.Match(source);
            return match.Groups[1].Value.Trim();
        }

        private void ChargeForm_Shown(object sender, EventArgs e)
        {
            ScanService.SetAction(ExplainText);
            ScanService.Work();
            ScanService.Satrt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var testItem = "";

            ChargeRecord chargeRecord = new ChargeRecord();
            chargeFiller.FillEntity(chargeRecord);
            chargeRecord.DateOfCharge = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            List<ChargeDetail> details = new List<ChargeDetail>();
            foreach (var item in ItemList)
            {
                ChargeDetail detail = new ChargeDetail();
                detail.PlateNo = chargeRecord.PlateNo;
                detail.TestNo = chargeRecord.TestNo;
                detail.TestItem = item.Item1;
                detail.TestTimes = item.Item2;
                detail.Price = item.Item3;
                details.Add(detail);
                if (testItem == "")
                    testItem = detail.TestItem;
                else
                    testItem = $"{testItem},{detail.TestItem}";
            }
            
            //其他费用
            decimal otherPrice = 0;
            decimal.TryParse(txtOtherFee.Text.Trim(), out otherPrice);
            details.Add(new ChargeDetail()
            {
                PlateNo = chargeRecord.PlateNo,
                TestNo = chargeRecord.TestNo,
                TestItem = "其他",
                TestTimes = 0,
                Price = otherPrice,
                Remark = txtOtherFeeRemark.Text.Trim()
            });


            chargeRecord.TestItem = testItem;

            ChargeApi chargeApi = new ChargeApi();
            chargeApi.SaveChargeDetails(details);

            var resp = chargeApi.SaveChargeRecord(chargeRecord);

            if (resp.Code == 1)
            {
                FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功", ContentAlignment.MiddleCenter);
            }
            else
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败"+resp?.Message, ContentAlignment.MiddleCenter);
            }
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            ControlHelper.ThreadRunExt(AppHelper.MainForm, () =>
             {
                 try
                 {
                     LogHelper.Trace($"开始叫号{AppHelper.AppSetting.WindowAddr}-{_carInfo.PlateNo}");
                     CallService.CallNo(AppHelper.AppSetting.WindowAddr, _carInfo.PlateNo);
                 }
                 catch (Exception ex)
                 {
                     LogHelper.Error($"叫号异常：{ex.Message}");
                 }
             }, null, AppHelper.MainForm, true, "正在呼叫……", 200);
        }

        private void ChargeForm_VisibleChanged(object sender, EventArgs e)
        {
            WinVisible = this.Visible;
        }

        private void txtOtherFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键 
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字 
                {
                    e.Handled = true;
                }
            }

        }

        private void CalTotalPrice()
        {
            decimal total = 0;
            if (decimal.TryParse(txtOtherFee.Text.Trim(), out decimal d))
                total = TOTAL_PRICE + d;
            else
                total = TOTAL_PRICE;
            txtPrice.Text = total.ToString();
            labPrice.Text = ExtendMethod.MoneyToCap(total);
        }

        private void txtOtherFee_KeyUp(object sender, KeyEventArgs e)
        {
            CalTotalPrice();
        }
    }
}
