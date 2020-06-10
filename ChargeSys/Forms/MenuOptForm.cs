using ChargeSys.Common;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
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
    public partial class MenuOptForm : FrmWithTitle
    {
        private MssqlHelper _mssqlHelper = MssqlHelper.GetInstance();
        private Menus m_menus = null;
        private bool bIsUpdate = false;
        private bool IsModify = false;

        public MenuOptForm()
        {
            InitializeComponent();
            m_menus = new Menus();
            Init();
            entityFiller.DisplayEntity(m_menus);
        }

        public MenuOptForm(Menus  menus)
        {
            InitializeComponent();
            m_menus = menus;
            Init();
            IsModify = true;
            entityFiller.DisplayEntity(m_menus);
        }

        public bool IsUpdate { get { return bIsUpdate; } }

        public Menus GetMenus{ get { return m_menus; } }

        private void Init()
        {
            List<Menus> menus = new List<Menus>();
            menus.Add(new Menus() { 
                    Id = 0,
                    MenuName = "请选择"
            });

            MenuApi menuApi = new MenuApi();
            var response = menuApi.GetMenus();
            if (response.Code == 1 && response.DataCount > 0)
            {
                var menus1 = JsonConvert.DeserializeObject<List<Menus>>(response.Data?.ToString());
                menus.AddRange(menus1);
            }
            combMenus.DataSource = menus;
            combMenus.DisplayMember = "MenuName";
            combMenus.ValueMember = "Id";
        }

        private void btnSave_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (!validator1.Validate()) return;
                entityFiller.FillEntity(m_menus);
                m_menus.ParentId = Convert.ToInt32(combMenus.SelectedValue);
                if (m_menus.ParentId != 0)
                {
                    m_menus.ParentName = combMenus.Text;
                }

                MenuApi menuApi = new MenuApi();
                ResponseModel responseModel = new ResponseModel();
                if(!IsModify)
                    responseModel = menuApi.AddMenu(m_menus);
                else
                    responseModel = menuApi.ModifyMenu(m_menus);
                if (responseModel.Code == 1)
                {
                    FrmTips.ShowTipsSuccess(AppHelper.MainForm, "保存成功！", ContentAlignment.MiddleCenter, 1000);
                    m_menus = JsonConvert.DeserializeObject<Menus>(responseModel.Data.ToString());
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
