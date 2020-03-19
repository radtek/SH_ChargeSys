using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChargeSys.Entitys;
using HZH_Controls;
using HZH_Controls.Forms;
using System.Collections;
using CI.UIComponents.Helper;
using Live0xUtils.DbUtils.SqlServer;

namespace ChargeSys.Main.Controls
{
    public partial class UCChargeSetting : UserControl
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();

        public UCChargeSetting()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ConstantDefine> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable = null;
                    string sql = "SELECT  * FROM NetTypeDefine WHERE 1=1 ";

                    if (!string.IsNullOrEmpty(txtSeachPlateNo.Text.Trim()))
                    {
                        hashtable = new Hashtable();
                        hashtable.Add("DefineType", "%" + txtSeachPlateNo.Text.Trim() + "%");
                        sql += " AND DefineType like @DefineType";
                    }
                    list = _mssqlHelper.QueryList<ConstantDefine>(sql, hashtable).ToList();
                    ControlHelper.ThreadInvokerControl(AppHelper.MainForm, () =>
                    {
                        if (list != null)
                        {
                            CGridHelper.ClearGrid(dgv);
                            CGridHelper.FillGrid<ConstantDefine>(dgv, list);
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

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
