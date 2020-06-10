using ChargeSys.Common;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
using CI.UIComponents.Helper;
using HZH_Controls;
using HZH_Controls.Forms;
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
    public partial class ChargeDefineForm : FrmWithTitle
    {
        public ChargeDefineForm()
        {
            InitializeComponent();
            btnSearch_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChargeDefineOptForm form = new ChargeDefineOptForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ChargeDefine> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                var succ = true;
                var msg = "";
                try
                {
                    ResponseModel responseModel = new ResponseModel();
                    ConstantApi constantApi = new ConstantApi();
                    responseModel = constantApi.GetChargeDefines();
                    //Hashtable hashtable = null;
                    //string sql = "SELECT  * FROM ConstantDefine WHERE 1=1 ";

                    //if (!string.IsNullOrEmpty(txtSeach.Text.Trim()))
                    //{
                    //    hashtable = new Hashtable();
                    //    hashtable.Add("TypeName", "%" + txtSeach.Text.Trim() + "%");
                    //    sql += " AND TypeName like @DefineType";
                    //}
                    //list = AppHelper.DB.QueryList<ConstantDefine>(sql, hashtable).ToList();

                    if (responseModel.Code == 1)
                    {
                        if (responseModel.DataCount > 0)
                        {
                            list = JsonConvert.DeserializeObject<List<ChargeDefine>>(responseModel?.Data?.ToString());
                            ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                            {
                                if (list != null)
                                {
                                    CGridHelper.ClearGrid(dgv);
                                    CGridHelper.FillGrid<ChargeDefine>(dgv, list);
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
                    msg = ex.Message;
                }
                if (!succ)
                {
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        FrmTips.ShowTips(AppHelper.MainForm, msg, 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                    });
                }
            }, null, AppHelper.MainForm, true, "正在查询……", 200);
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
                ChargeDefine entity = CGridHelper.GetCurrentData<ChargeDefine>(dgv);
                ChargeDefineOptForm form = new ChargeDefineOptForm(entity);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    btnSearch_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "修改异常！" + ex.Message, ContentAlignment.MiddleCenter, 3000);
            }
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
                ChargeDefine entity = CGridHelper.GetCurrentData<ChargeDefine>(dgv);

                ConstantApi constantApi = new ConstantApi();
                var resp = constantApi.DeleteChargeDefine(entity.ID);
                //string sql = "DELETE ConstantType WHERE ID = @ID";
                //Hashtable hashtable = new Hashtable();
                //hashtable.Add("ID", entity.ID);
                //if (_mssqlHelper.ExcuteNonQuery(sql, hashtable) > 0)
                //{
                if (resp.Code == 1)
                {
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "删除成功！", ContentAlignment.MiddleCenter, 1000);
                    CGridHelper.DeleteRow(dgv);
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "删除失败！" + resp.Message, ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "删除异常！" + ex.Message, ContentAlignment.MiddleCenter, 3000);
            }
        }
    }
}
