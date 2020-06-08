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
    public partial class UserOptForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private User m_user = null;
        private bool bIsUpdate = false;
        private bool IsModify = false;

        public UserOptForm()
        {
            InitializeComponent();
            m_user = new User();
            Init();
            entityFiller.DisplayEntity(m_user);
        }

        public UserOptForm(User user)
        {
            InitializeComponent();
            Init();
            SelectDefaultRoles(user.Id);
            m_user = user;
            IsModify = true;
            entityFiller.DisplayEntity(m_user);
        }

        private void Init()
        {
            RbacApi rbac = new RbacApi();
            var response = rbac.GetRoles();
            if (response.Code == 1 && response.DataCount > 0)
            {
                List<Role> roles = JsonConvert.DeserializeObject<List<Role>>(response.Data?.ToString());
                tvMenus.Nodes.Clear();
                tvMenus.CheckBoxes = true;
                foreach (var item in roles)
                {
                    TreeNode rootNode = new TreeNode(item.RoleName);
                    rootNode.Name = item.Id.ToString();
                    tvMenus.Nodes.Add(rootNode);
                    tvMenus.ExpandAll();
                }
            }
        }

        public bool IsUpdate { get { return bIsUpdate; } }

        private void btnSave_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (!validator1.Validate()) return;
                entityFiller.FillEntity(m_user);

                RbacApi rbac = new RbacApi();
                ResponseModel response = new ResponseModel();
                if (IsModify)
                     response = rbac.ModifyUser(m_user);
                else
                    response = rbac.AddUser(m_user);


                

                if (response.Code == 1)
                {
                    User user = JsonConvert.DeserializeObject<User>(response.Data.ToString()) ;
                    //保存角色信息
                    List<int> roleIds = new List<int>();
                    List<UserRoleMap> userRoleMaps = new List<UserRoleMap>();
                    GetCheckedMenuIds(tvMenus.Nodes, roleIds);
                    foreach (var item in roleIds)
                    {
                        userRoleMaps.Add(new UserRoleMap() { 
                            UserId = user.Id,
                            RoleId = item
                        });
                    }
                    rbac.SaveUserRole(userRoleMaps.ToArray());

                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功！", ContentAlignment.MiddleCenter, 1000);
                    bIsUpdate = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败！"+ response.Message, ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败！"+ex.Message, ContentAlignment.MiddleCenter, 1000);
            }
        }

        private void ValChangeOptForm_Load(object sender, EventArgs e)
        {

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

        private void SelectDefaultRoles(int userid)
        {
            RbacApi menuApi = new RbacApi();
            var response = menuApi.GetRoleByUser(userid);
            if (response.Code == 1 && response.DataCount > 0)
            {
                List<Role> roles = JsonConvert.DeserializeObject<List<Role>>(response.Data?.ToString());
                List<int> roleIds = roles.Select(m => m.Id).ToList();

                CheckTvNodes(tvMenus.Nodes, roleIds);
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

    }
}
