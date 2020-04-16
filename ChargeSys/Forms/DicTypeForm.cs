﻿using ChargeSys.Common;
using ChargeSys.Entitys;
using CI.UIComponents.Helper;
using HZH_Controls;
using HZH_Controls.Forms;
using Live0xUtils.DbUtils.SqlServer;
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
    public partial class DicTypeForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        public DicTypeForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ConstantType> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable = null;
                    string sql = "SELECT  * FROM ConstantType WHERE 1=1 ";

                    if (!string.IsNullOrEmpty(txtSeach.Text.Trim()))
                    {
                        hashtable = new Hashtable();
                        hashtable.Add("TypeName", "%" + txtSeach.Text.Trim() + "%");
                        sql += " AND TypeName like @DefineType";
                    }
                    list = _mssqlHelper.QueryList<ConstantType>(sql, hashtable).ToList();
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        if (list != null)
                        {
                            CGridHelper.ClearGrid(dgv);
                            CGridHelper.FillGrid<ConstantType>(dgv, list);
                        }
                    });
                }
                catch (Exception ex)
                {
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        FrmTips.ShowTips(AppHelper.MainForm, ex.Message, 2000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Medium, new Size(300, 100), TipsState.Error);
                    });
                }

            }, null, AppHelper.MainForm, true, "正在查询……", 200);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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
                ConstantType entity = CGridHelper.GetCurrentData<ConstantType>(dgv);
                string sql = "DELETE ConstantType WHERE ID = @ID";
                Hashtable hashtable = new Hashtable();
                hashtable.Add("ID", entity.ID);
                if (_mssqlHelper.ExcuteNonQuery(sql, hashtable) > 0)
                {
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "删除成功！", ContentAlignment.MiddleCenter, 1000);
                    CGridHelper.DeleteRow(dgv);
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "删除失败！", ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "删除异常！" + ex.Message, ContentAlignment.MiddleCenter, 3000);
            }
        }
    }
}
