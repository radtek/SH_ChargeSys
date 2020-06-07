using ChargeSys.Common;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChargeSys.Main.Forms
{
    public partial class ChargeDefineOptForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private ChargeDefine m_chargeDefine = null;
        private bool bIsUpdate = false;

        public ChargeDefineOptForm()
        {
            InitializeComponent();
            Init();
            m_chargeDefine = new ChargeDefine();
            entityFiller.DisplayEntity(m_chargeDefine);
        }

        public ChargeDefineOptForm(ChargeDefine chargeDefine)
        {
            InitializeComponent();
            Init();
            m_chargeDefine = chargeDefine;
            entityFiller.DisplayEntity(m_chargeDefine);
            combDefine.SelectedText = m_chargeDefine.ItemName;
            combDefine.SelectedValue = m_chargeDefine.ItemCode;
        }

        public bool IsUpdate { get { return bIsUpdate; } }

        private void btnSave_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (!validator1.Validate()) return;
                entityFiller.FillEntity(m_chargeDefine);
                m_chargeDefine.ItemName = combDefine.Text;
                m_chargeDefine.ItemCode = combDefine.SelectedValue.ToString();

                ConstantApi constantApi = new ConstantApi();
                var responseModel = constantApi.SaveChargeDefine(m_chargeDefine);
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

            List<ConstantDefine> constantDefines = new List<ConstantDefine>();
            ConstantApi constantApi = new ConstantApi();

            var respType = constantApi.GetConstantDefines();
            if (respType.Code == 1 && respType.DataCount > 0)
                constantDefines = JsonConvert.DeserializeObject<List<ConstantDefine>>(respType.Data.ToString()).Where(p => p.TypeName.Equals("收费项目")).ToList();
            //foreach (var item in defines)
            //{
            //    mylist.Add(new DictionaryEntry(item.Code, item.TypeName));
            //}
            combDefine.DataSource = constantDefines;
            combDefine.DisplayMember = "ConstantName";
            combDefine.ValueMember = "ConsatntCode";
        }

        private void ValChangeOptForm_Load(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
