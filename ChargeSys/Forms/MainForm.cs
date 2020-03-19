using ChargeSys.Main.Controls;
using EASkins.Controls;
using HZH_Controls;
using Newtonsoft.Json;
using System;
using System.Collections;
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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
			InitMenu();
            tvMenu.AfterSelect += tvMenu_AfterSelect;

        Hashtable hashtable =     JsonConvert.DeserializeObject<Hashtable>(File.ReadAllText("Test.txt"));
         List<Hashtable>   hashtables  = JsonConvert.DeserializeObject<List<Hashtable>>(hashtable["moduleData"].ToString());
        }
		//初始化菜单
		private void InitMenu()
		{
			ControlHelper.FreezeControl(this, true);

			TreeNode tnDataManager = new TreeNode("数据管理");
			tnDataManager.Nodes.Add("收费");
			this.tvMenu.Nodes.Add(tnDataManager);

			TreeNode tnSetting = new TreeNode("系统管理");
			tnSetting.Nodes.Add("系统设置");
            tnDataManager.Nodes.Add("收费配置");
            this.tvMenu.Nodes.Add(tnSetting);
		}

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strName = e.Node.Text.Trim();
            if (!new string[] { "车辆报检", "数据管理", "系统管理" }.Contains(strName))
            {
                panControl.Controls.Clear();
            }
            switch (strName)
            {
                case "收费":
                    AddControl(new UCCharge());
                    break;
            }
        }

        public void AddControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            control.AllowDrop = false;
            panControl.Controls.Add(control);
            control.BringToFront();
            control.Show();
        }

    }


}
