using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HZH_Controls;
using ChargeSys.Core;
using ChargeSys.Core.Service;

namespace ChargeSys.Main.Controls
{
    public partial class UCCharge : UserControl
    {
        public UCCharge()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            materialListView1.Items.Clear();
            //var data = new[]
            //{
            //	new []{"Lollipop", "392", "0.2"},
            //	new []{"KitKat", "518", "26.0", "7"},
            //	new []{"Ice cream sandwich", "237", "9.0", "4.3"},
            //	new []{"Jelly Bean", "375", "0.0", "0.0"},
            //	new []{"Honeycomb", "408", "3.2", "6.5"}
            //};

            List<Items> list = new List<Items>();
            list.Add(new Items() { var1 = "1", var2 = "2" });
            //Add
            foreach (var version in list)
            {
                var item = new ListViewItem(version.var1, 1);
                materialListView1.Items.Add(item);
            }
        }


        public class Items
        {
            public string var1 { get; set; }
            public string var2 { get; set; }
        }

        private void Init()
        {
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string test = "检验流水号: 11003718083100081"
                                + "号牌号码: 京EBX815"
                                + "车辆类型: 小型轿车"
                                + "检测项目: 制动,灯光"
                                + "检测次数: 制动 1 次,灯光 2 次"
                                + "引车员: 尚小楠"
                                + "检测时间: 2018 - 09 - 01 08:11:26";
            ScanService.EnQueue(test);
        }
    }
}
