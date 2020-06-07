using ChargeSys.Entitys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main.Api
{
    public class ConstantApi
    {
        ApiHelper apiHelper;
        public ConstantApi()
        {
            apiHelper = new ApiHelper();
        }

        //获取字典类型集合
        public ResponseModel GetConstantTypes()
        {
            return apiHelper.ReqGet("ConstantDefine/GetConstantTypes", null);
        }

        //获取字典类型
        public ResponseModel GetConstantType(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqGet($"ConstantDefine/GetConstantType/{id}", hashtable);
        }

        public ResponseModel SaveConstantType(ConstantType constantType)
        {
            return  apiHelper.ReqPost("ConstantDefine/SaveConstantType", constantType);
        }

        //获取常量定义集合
        public ResponseModel GetConstantDefines()
        {
            return apiHelper.ReqGet("ConstantDefine/GetConstantDefines", null);
        }

        //获取常量定义
        public ResponseModel GetConstantDefine(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return  apiHelper.ReqGet($"ConstantDefine/GetConstantDefine", hashtable);
        }

        public ResponseModel SaveConstantDefine(ConstantDefine constantDefine)
        {
            return apiHelper.ReqPost("ConstantDefine/SaveConstantDefine", constantDefine);
        }

        public ResponseModel DeleteConstantType(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqDelete($"ConstantDefine/DeleteConstantType/{id}", hashtable);
        }

        public ResponseModel DeleteConstantDefine(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqDelete($"ConstantDefine/DeleteConstantDefine/{id}", hashtable);
        }


        #region 收费定义
        public ResponseModel GetChargeDefines()
        {
            return apiHelper.ReqGet("ConstantDefine/GetChargeDefines", null);
        }

        public ResponseModel GetChargeDefine(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqGet($"ConstantDefine/GetChargeDefine", hashtable);
        }

        public ResponseModel SaveChargeDefine(ChargeDefine constantDefine)
        {
            return apiHelper.ReqPost("ConstantDefine/SaveChargeDefine", constantDefine);
        }


        public ResponseModel DeleteChargeDefine(int id)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id", id);
            return apiHelper.ReqDelete($"ConstantDefine/DeleteChargeDefine/{id}", hashtable);
        }

        #endregion
    }
}
