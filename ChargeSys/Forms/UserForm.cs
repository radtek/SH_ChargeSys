using ChargeSys.Common;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
using CI.UIComponents.Helper;
using HZH_Controls;
using HZH_Controls.Forms;
using Live0xUtils.DbUtils.SqlServer;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChargeSys.Main.Forms
{
    public partial class UserForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        public UserForm()
        {
            InitializeComponent();
            btnRefresh_Click(null, null);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserOptForm form = new UserOptForm();
            form.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow == null || dgv.CurrentRow.Index < 0)
                {
                    FrmTips.ShowTipsError(AppHelper.MainForm, "未选中任何行！", ContentAlignment.MiddleCenter, 1000);
                    return;
                }
                User entity = CGridHelper.GetCurrentData<User>(dgv);

                RbacApi constantApi = new RbacApi();
                var resp = constantApi.DeleteUser(entity.Id);
                if (resp.Code == 1)
                {
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "删除成功！", ContentAlignment.MiddleCenter, 1000);
                    CGridHelper.DeleteRow(dgv);
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "删除失败！"+resp.Message, ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "删除异常！" + ex.Message, ContentAlignment.MiddleCenter, 3000);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow == null || dgv.CurrentRow.Index < 0)
                {
                    FrmTips.ShowTipsError(AppHelper.MainForm, "未选中任何行！", ContentAlignment.MiddleCenter, 1000);
                    return;
                }
                User entity = CGridHelper.GetCurrentData<User>(dgv);
                UserOptForm form = new UserOptForm(entity);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "修改异常！" + ex.Message, ContentAlignment.MiddleCenter, 3000);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<User> list = null;
            ControlHelper.ThreadRunExt(AppHelper.MainForm, () =>
            {
                var succ = true;
                var msg = "";
                try
                {
                    ResponseModel responseModel = new ResponseModel();
                    RbacApi rbac = new RbacApi();
                    responseModel = rbac.GetUsers("", "");

                    if (responseModel.Code == 1)
                    {
                        if (responseModel.DataCount > 0)
                        {
                            list = JsonConvert.DeserializeObject<List<User>>(responseModel?.Data?.ToString());
                            ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                            {
                                if (list != null)
                                {
                                    CGridHelper.ClearGrid(dgv);
                                    CGridHelper.FillGrid<User>(dgv, list);
                                }
                            });
                        }
                        else
                        {
                            succ = false;
                            msg = "查询数据为空!";
                        }
                    }
                    else
                    {
                        succ = false;
                        msg = responseModel?.Message;
                    }
                }
                catch (Exception ex)
                {
                    succ = false;
                    msg = ex.Message;
                }
                if (!succ)
                {
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        FrmTips.ShowTips(AppHelper.MainForm, msg, 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                    });
                }
            }, null, AppHelper.MainForm, true, "正在刷新……", 200);
        }
    }
}
