using ChargeSys.Common;
using ChargeSys.Common.Dtos;
using ChargeSys.Core;
using ChargeSys.Core.Service;
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

        public ChargeForm()
        {
            InitializeComponent();
            labPrice.Text = "";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string test = "检验流水号: 11003718083100081"
                                + "号牌号码: 京EBX815"
                                + "车辆类型: 小型轿车"
                                + "检测项目: 制动,灯光,策划"
                                + "检测次数: 制动 1 次,灯光 2 次"
                                + "引车员: 尚小楠"
                                + "检测时间: 2018-09-01 08:11:26";
            ScanService.EnQueue(test);

        }

        private void ExplainText(string s)
        {
            ControlHelper.ThreadInvokerControl(this, () =>
             {
                 Clear();
                 _carInfo = new CarInfo();
                 _carInfo.TestNo = RegexVal(s, @"检验流水号:(.*)号牌号码");
                 _carInfo.PlateNo = RegexVal(s, @"号牌号码:(.*)车辆类型");
                 _carInfo.CarType = RegexVal(s, @"车辆类型:(.*)检测项目");
                 _carInfo.TestItem = RegexVal(s, @"检测项目:(.*)检测次数");
                 string testTimes = RegexVal(s, @"检测次数:(.*)引车员");
                 _carInfo.Guider = RegexVal(s, @"引车员:(.*)检测时间");
                 _carInfo.TestDate = RegexVal(s, @"检测时间:(.*)");

                 Task.Run(()=> {
                     try
                     {
                         LogHelper.Trace($"开始叫号{AppHelper.AppSetting.WindowAddr}-{_carInfo.PlateNo}");
                         CallService.CallNo(AppHelper.AppSetting.WindowAddr, _carInfo.PlateNo);
                     }
                     catch (Exception ex)
                     {
                         LogHelper.Error($"叫号异常：{ex.Message}");
                     }
                 });
                 
                 List<Tuple<string, int,double>> list = new List<Tuple<string, int,double>>();
                 //处理检验项目和检验次数
                 string[] testItems = _carInfo.TestItem.Split(',');
                 for (int i = 0; i < testItems.Length; i++)
                 {
                     int times = RegexVal(testTimes, $@"{testItems[i]}(.*?)次").ToInt();
                     double price = CalPrice(testItems[i].Trim(),times);
                     list.Add(new Tuple<string, int, double>(testItems[i].ToString(), times, price));
                     var item = new ListViewItem(new string[] { testItems[i],  times.ToString(), price.ToString() });
                     materialListView1.Items.Add(item);
                 }

                 double totalPrice = 0;
                 foreach (var item in list)
                 {
                     totalPrice += item.Item3;
                 }
                 _carInfo.Price = totalPrice;
                 carFiller.DisplayEntity(_carInfo);             
                 labPrice.Text = ExtendMethod.MoneyToCap(totalPrice); 
             });
        }



        private void Clear()
        {
            materialListView1.Items.Clear();
        }

        private double CalPrice(string itemName,int times)
        {
            double itemPrice = 0;
            double firstPrice = MainCache.GetCharge(itemName, 1); //初检费用
            itemPrice += firstPrice;

            for (int i = 2; i <= times; i++)
            {
                itemPrice += MainCache.GetCharge(itemName, 2);
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

    }
}
