using ChargeSys.Common;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
using HZH_Controls.Forms;
using Live0xUtils.DbUtils.SqlServer;
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
    public partial class DicTypeOptForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private ConstantType m_netTypeDefine = null;
        private bool bIsUpdate = false;

        public DicTypeOptForm()
        {
            InitializeComponent();
            m_netTypeDefine = new ConstantType();
            entityFiller.DisplayEntity(m_netTypeDefine);
        }

        public DicTypeOptForm(ConstantType netTypeDefine)
        {
            InitializeComponent();
            m_netTypeDefine = netTypeDefine;
            entityFiller.DisplayEntity(m_netTypeDefine);
        }

        public bool IsUpdate { get { return bIsUpdate; } }

        private void btnSave_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (!validator1.Validate()) return;
                entityFiller.FillEntity(m_netTypeDefine);

                ConstantApi constantApi = new ConstantApi();
               var  responseModel = constantApi.SaveConstantType(m_netTypeDefine);
                //bool succ = _mssqlHelper.InsertOrUpdate(m_netTypeDefine, null, new string[] { "ID" }, null);
                if (responseModel.Code == 1)
                {
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
    }
}
