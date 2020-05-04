using ChargeSys.Common;
using ChargeSys.Entitys;
using CI.UIComponents.Helper;
using HZH_Controls;
using HZH_Controls.Forms;
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
    public partial class DicDefineForm : FrmWithTitle
    {
        public DicDefineForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DicDefineOptForm form = new DicDefineOptForm();
            form.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ConstantDefine> list = null;
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    Hashtable hashtable = null;
                    string sql = "SELECT  * FROM ConstantDefine WHERE 1=1 ";

                    if (!string.IsNullOrEmpty(txtSeach.Text.Trim()))
                    {
                        hashtable = new Hashtable();
                        hashtable.Add("TypeName", "%" + txtSeach.Text.Trim() + "%");
                        sql += " AND TypeName like @DefineType";
                    }
                    list = AppHelper.DB.QueryList<ConstantDefine>(sql, hashtable).ToList();
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

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
