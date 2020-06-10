using ChargeSys.Common;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChargeSys.Main.Forms
{
    public partial class DicDefineOptForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private ConstantDefine m_netTypeDefine = null;
        private bool bIsUpdate = false;

        public DicDefineOptForm()
        {
            InitializeComponent();
            Init();
            m_netTypeDefine = new ConstantDefine();
            entityFiller.DisplayEntity(m_netTypeDefine);
        }

        public DicDefineOptForm(ConstantDefine netTypeDefine)
        {
            InitializeComponent();
            Init();
            m_netTypeDefine = netTypeDefine;
            entityFiller.DisplayEntity(m_netTypeDefine);
            combDefine.SelectedText = netTypeDefine.ConstantName;
            combDefine.SelectedValue = netTypeDefine.TypeCode;
            combDefine.Enabled = false;
        }

        public bool IsUpdate { get { return bIsUpdate; } }

        private void btnSave_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (!validator1.Validate()) return;
                entityFiller.FillEntity(m_netTypeDefine);
                m_netTypeDefine.TypeName = combDefine.Text;
                m_netTypeDefine.TypeCode = combDefine.SelectedValue.ToString();

                ConstantApi constantApi = new ConstantApi();
                var responseModel = constantApi.SaveConstantDefine(m_netTypeDefine);
                //bool succ = _mssqlHelper.InsertOrUpdate(m_netTypeDefine, null, new string[] { "ID" }, null);
                if (responseModel.Code.Equals(1))
                {
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功！", ContentAlignment.MiddleCenter, 1000);
                    bIsUpdate = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败！"+ responseModel.Message, ContentAlignment.MiddleCenter, 1000);
            }
            catch (Exception ex)
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "保存失败！"+ex.Message, ContentAlignment.MiddleCenter, 1000);
            }
        }

        private void Init()
        {
           // ArrayList mylist = new ArrayList();
            var defines = MainCache.GetConstantTypes();
            //foreach (var item in defines)
            //{
            //    mylist.Add(new DictionaryEntry(item.Code, item.TypeName));
            //}
            combDefine.DataSource = defines;
            combDefine.DisplayMember = "TypeName";
            combDefine.ValueMember = "TypeCode";
        }

        private void ValChangeOptForm_Load(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
