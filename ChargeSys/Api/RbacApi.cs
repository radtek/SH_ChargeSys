using ChargeSys.Entitys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main.Api
{
    public class RbacApi
    {
        ApiHelper apiHelper;
        public RbacApi()
        {
            apiHelper = new ApiHelper();
        }
        #region User
        public ResponseModel AddUser(User user)
        {
            return apiHelper.ReqPost("Rbac/AddUser", user);
        }

        public ResponseModel ModifyUser(User user)
        {
            return apiHelper.ReqPost("Rbac/ModifyUser", user);
        }

        public ResponseModel DeleteUser(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqGet("Rbac/DeleteUser", hashtable);
        }

        public ResponseModel GetUser(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqGet("Rbac/GetUser", hashtable);
        }

        public ResponseModel GetUsers(string name, string sex)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("name", name);
            hashtable.Add("sex", sex);
            return apiHelper.ReqGet("Rbac/GetUsers", hashtable);
        }


        #endregion

        #region Role
        public ResponseModel SaveRole(Role role)
        {
            return apiHelper.ReqPost("Rbac/SaveRole", role);
        }

        public ResponseModel DeleteRole(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqGet("Rbac/DeleteRole", hashtable);
        }

        public ResponseModel GetRole(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqGet("Rbac/GetRole", hashtable);
        }

        public ResponseModel GetRoles()
        {
            return apiHelper.ReqGet("Rbac/GetRoles", null);
        }
        #endregion

        #region User-Role
        public ResponseModel SaveUserRole(UserRoleMap[] userRoleMaps)
        {
            return apiHelper.ReqPost("Rbac/SaveUserRole", userRoleMaps);
        }
        public ResponseModel SaveRoleMenu(RoleMenuMap[] roleMenuMaps)
        {
            return apiHelper.ReqPost("Rbac/SaveRoleMenu", roleMenuMaps);
        }

        #endregion

        #region Permission
        public ResponseModel GetPermissions()
        {
            return apiHelper.ReqGet("Rbac/GetPermissions", null);
        }

        public ResponseModel GetRoleByUser(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("userid", id);
            return apiHelper.ReqGet("Rbac/GetRoleByUser", hashtable);
        }
        #endregion

        #region Role-Permission
        #endregion
    }
}
