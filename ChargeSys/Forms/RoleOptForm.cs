using ChargeSys.Common;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
using ChargeSys.Main.Tools;
using HZH_Controls.Forms;
using Live0xUtils.DbUtils.SqlServer;
using Newtonsoft.Json;
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
    public partial class RoleOptForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private Role m_role = null;
        private bool bIsUpdate = false;
       

        public RoleOptForm()
        {
            InitializeComponent();
            m_role = new  Role();
            Init();
            entityFiller.DisplayEntity(m_role);
        }

        public RoleOptForm(Role role)
        {
            InitializeComponent();
            m_role = role;
            Init();
            SelectDefaultMenus(m_role.Id);
            entityFiller.DisplayEntity(m_role);
        }

        private void Init()
        {
            MenuApi menuApi = new MenuApi();
            var response = menuApi.GetMenuByUser(AppHelper.UserId);
            if (response.Code == 1 && response.DataCount > 0)
            {
                List<Menus> menuList = JsonConvert.DeserializeObject<List<Menus>>(response.Data?.ToString());
                tvMenus.Nodes.Clear();
                tvMenus.CheckBoxes = true;
                TreeNode rootNode = new TreeNode("系统菜单");
                rootNode.Name = "0";
                tvMenus.Nodes.Add(rootNode);
                CreateTreeNode(menuList, rootNode, 0);
                tvMenus.ExpandAll();
            }
        }

        private void CreateTreeNode(List<Menus> menuList, TreeNode pNode, int parentId)
        {
            var childList = menuList.Where(m => m.ParentId == parentId);
            foreach (var menu in childList)
            {
                TreeNode tn = new TreeNode(menu.MenuName);
                tn.Name = menu.Id.ToString();
                if (pNode != null)
                    pNode.Nodes.Add(tn);
                CreateTreeNode(menuList, tn, menu.Id);
            }
        }

        public bool IsUpdate { get { return bIsUpdate; } }

        private void btnSave_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (!validator1.Validate()) return;
                entityFiller.FillEntity(m_role);

               RbacApi rbac = new RbacApi();
               var  responseModel = rbac.SaveRole(m_role);
                if (responseModel.Code == 1)
                {
                    Role role = JsonConvert.DeserializeObject<Role>(responseModel.Data.ToString());
                    //保存角色信息
                    List<int> roleIds = new List<int>();
                    List<RoleMenuMap> roleMenuMaps = new List<RoleMenuMap>();
                    GetCheckedMenuIds(tvMenus.Nodes, roleIds);
                    foreach (var item in roleIds)
                    {
                        roleMenuMaps.Add(new RoleMenuMap()
                        {
                            RoleId = role.Id,
                            MenuId = item
                        });
                    }
                    rbac.SaveRoleMenu(roleMenuMaps.ToArray());
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功！", ContentAlignment.MiddleCenter, 1000);
                    bIsUpdate = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败！"+responseModel.Message, ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败！"+ex.Message, ContentAlignment.MiddleCenter, 1000);
            }
        }

        private void ValChangeOptForm_Load(object sender, EventArgs e)
        {

        }

        private void tvMenus_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse)
            {
                //e.Node 当前操作的节点
                //更改当前节点下面子节点的勾选
                SetChildNodesCheckState(e.Node);
                SetParentNodesCheckState(e.Node);
            }
        }

        /// <summary>
        /// 当前节点子节点的勾选
        /// </summary>
        /// <param name="node"></param>
        private void SetChildNodesCheckState(TreeNode node)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = node.Checked;
                SetChildNodesCheckState(child);
            }
        }

        /// <summary>
        /// 父节点的勾选处理
        /// </summary>
        /// <param name="node"></param>
        private void SetParentNodesCheckState(TreeNode node)
        {
            TreeNode pNode = node.Parent;
            if (pNode != null)
            {
                bool bl = false;
                foreach (TreeNode tn in pNode.Nodes)
                {
                    if (tn.Checked)
                    {
                        bl = true;
                        break;
                    }
                }
                pNode.Checked = bl;
                SetParentNodesCheckState(pNode);
            }

        }

        /// <summary>
        /// 获取已勾选的菜单编号集合
        /// </summary>
        /// <param name="tnc"></param>
        /// <param name="menuIds"></param>
        /// <returns></returns>
        private List<int> GetCheckedMenuIds(TreeNodeCollection tnc, List<int> menuIds)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.Checked)
                {
                    int mId = tn.Name.GetInt();
                    if (!menuIds.Contains(mId))
                        menuIds.Add(mId);
                }
                GetCheckedMenuIds(tn.Nodes, menuIds);
            }

            return menuIds;
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckNodes(tvMenus.Nodes, chkAll.Checked);
        }

        /// <summary>
        /// 全选或全不选
        /// </summary>
        /// <param name="tnc"></param>
        /// <param name="blCheck"></param>
        private void CheckNodes(TreeNodeCollection tnc, bool blCheck)
        {
            foreach (TreeNode tn in tnc)
            {
                tn.Checked = blCheck;
                CheckNodes(tn.Nodes, blCheck);
            }
        }

        private void SelectDefaultMenus(int roleid)
        {
            MenuApi menuApi = new MenuApi();
            var response = menuApi.GetMenuByRole(roleid);
            if (response.Code == 1 && response.DataCount > 0)
            {
                List<Menus> menuList = JsonConvert.DeserializeObject<List<Menus>>(response.Data?.ToString());
                List<int> MenuIds = menuList.Select(m => m.Id).ToList();

                CheckTvNodes(tvMenus.Nodes[0].Nodes, MenuIds);
            }
        }

        /// <summary>
        /// 将已设置的菜单节点选中
        /// </summary>
        /// <param name="tnc"></param>
        /// <param name="menuIds"></param>
        private void CheckTvNodes(TreeNodeCollection tnc, List<int> menuIds)
        {
            foreach (TreeNode tn in tnc)
            {
                if (menuIds.Contains(tn.Name.GetInt()))
                {
                    tn.Checked = true;
                }
                CheckTvNodes(tn.Nodes, menuIds);
            }
        }
    }
}
