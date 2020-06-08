using ChargeSys.Entitys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main.Api
{
    public class MenuApi
    {
        ApiHelper apiHelper;
        public MenuApi()
        {
            apiHelper = new ApiHelper();
        }
        public ResponseModel AddMenu(Menus menu)
        {
            return apiHelper.ReqPost("Menu/AddMenu", menu);
        }

        public ResponseModel ModifyMenu(Menus menu)
        {
            return apiHelper.ReqPost("Menu/ModifyMenu", menu);
        }

        public ResponseModel DeleteMenu(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id",id);
            return apiHelper.ReqGet("Menu/DeleteMenu", hashtable);
        }

        public ResponseModel GetMenus()
        {
            return apiHelper.ReqGet("Menu/GetMenus", null);
        }

        public ResponseModel GetMenu(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqGet("Menu/GetMenu", hashtable);
        }

        public ResponseModel GetMenuByUser(int userId)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("userid", userId);
            return apiHelper.ReqGet("Menu/GetMenuByUser", hashtable);
        }

        public ResponseModel GetMenuByRole(int roleId)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("roleid", roleId);
            return apiHelper.ReqGet("Menu/GetMenuByRole", hashtable);
        }
    }
}
