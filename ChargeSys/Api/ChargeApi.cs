using ChargeSys.Entitys;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main.Api
{
    public class ChargeApi
    {
        ApiHelper apiHelper;
        public ChargeApi()
        {
            apiHelper = new ApiHelper();
        }

        //保存收费记录
        public ResponseModel SaveChargeRecord(ChargeRecord chargeRecord)
        {
            return apiHelper.ReqPost("Charge/SaveChargeRecord", chargeRecord);
        }

        //保存收费明心
        public ResponseModel SaveChargeDetails(List<ChargeDetail> chargeDetails)
        { 
            return apiHelper.ReqPost($"Charge/SaveChargeDetails", chargeDetails);
        }

        public ResponseModel CallService(string windowStr,string plateNo)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("WinAddr", windowStr);
            hashtable.Add("PlateNo", plateNo);            
            return apiHelper.ReqGet($"Charge/CallService", hashtable);
        }
    }
}
