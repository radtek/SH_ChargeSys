using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live0xUtils.DbUtils.SqlServer;
using System.Collections;
using HZH_Controls;
using System.Threading;
using ChargeSys.Main.Api;
using ChargeSys.Entitys;
using Newtonsoft.Json;
using ChargeSys.Common;
using ChargeSys.Main.Forms;

namespace VehicleManagerSys.Main.CustomForms
{
    public partial class LoginForm : FrmWithTitle
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnCancel_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_BtnClick(object sender, EventArgs e)
        {
            labWarn.Text = "";
            string user = txtUser.InputText.Trim();
            string pwd = txtPwd.InputText.Trim();
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pwd))
            {
                labWarn.Text = "用户名、密码不能为空！";
                return;
            }
            //pwd =  Live0xUtils.Encryption.EncryptionMD5.GetMD5Hash(user+pwd);
            ControlHelper.ThreadRunExt(this, () =>
            {
                try
                {
                    RbacApi api = new RbacApi();
                    var response = api.UserLogin(user,pwd);
                        ControlHelper.ThreadInvokerControl(this, () =>
                        {

                            if (response.Code == 1)
                            {
                                User user1 = JsonConvert.DeserializeObject<User>(response.Data.ToString());
                                AppHelper.UserId = user1.Id;
                                AppHelper.UserName = user1.UserName;
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                labWarn.Text = "*登录失败！"+ response?.Message;
                            }
                        });
                }
                catch (Exception ex)
                {
                    ControlHelper.ThreadInvokerControl(this, () =>
                    {
                        FrmTips.ShowTipsError(this,ex.Message);
                    });
                }
            }, null, this,true,"正在登录……",200);
        
        }

        private void labDbSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SysSettingForm dbSettingForm = new SysSettingForm();
            dbSettingForm.IsShowCloseBtn = true;
            dbSettingForm.ShowDialog(this);
        }


        protected override void DoEnter()
        {
            btnOK_BtnClick(null,null);
        }
    }
}
