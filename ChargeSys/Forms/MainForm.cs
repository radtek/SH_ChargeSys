using ChargeSys.Entitys;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Main.Forms
{
    public partial class MainForm : MaterialForm
    {
        private List<SysMenu> _list = new List<SysMenu>();

        public MainForm()
        {
            InitializeComponent();
            _list = JsonConvert.DeserializeObject<List<SysMenu>>(File.ReadAllText("MenuConfig.json")); //加载菜单列表
            InitMenu();
            tvMenu.AfterSelect += tvMenu_AfterSelect;
        }
		//初始化菜单
		private void InitMenu()
		{
			ControlHelper.FreezeControl(this, true);
            foreach (var item in _list.Where(p => p.ParentId.Equals(0)))
            {
                this.tvMenu.Nodes.Add(InitMenu(item, _list));
            }
		}

        private TreeNode InitMenu(SysMenu sysMenu, List<SysMenu> list, int parentId = 0)
        {
            TreeNode treeNode = new TreeNode() { Text = sysMenu.MenuName, Tag = sysMenu.MenuPath };
            foreach (var item in list.Where(p => p.ParentId.Equals(sysMenu.MenuId)))
                treeNode.Nodes.Add(InitMenu(item, list, item.MenuId));
            return treeNode;
        }

        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string strKey = (e.Node.Tag ?? "").ToString();

            if (string.IsNullOrEmpty(strKey)) return;
            Assembly assembly = Assembly.GetExecutingAssembly();
            object o =assembly.CreateInstance(strKey,true);
            if (o != null)
            {
                panControl.Controls.Clear();
                Control control = (Control)o;
                if (control is Form)
                    ((Form)control).TopLevel = false;
                control.Dock = DockStyle.Fill;
                control.AllowDrop = false;
                panControl.Controls.Add(control);
                control.BringToFront();
                control.Show();
            }
        }

    }
}
