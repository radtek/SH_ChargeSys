using ChargeSys.Common;
using ChargeSys.Common.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Core.Service
{
    public abstract class CallService
    {

        public static CallEntity GetNo(string carType,string plateNo)
        {
            CallEntity callEntity = null;
            try
            {
                var obj = new
                {
                    cmd = "AddClient",
                    QueueId = carType,
                    CardNo = plateNo
                };
                string requestStr = JsonConvert.SerializeObject(obj);
                Hashtable hashtable = new Hashtable();
                hashtable.Add("data", requestStr);
                Live0xUtils.HttpUtils.HttpRequest httpRequest = new Live0xUtils.HttpUtils.HttpRequest();
                string url = AppHelper.AppSetting.CallUrl.EndsWith("/") ? AppHelper.AppSetting.CallUrl + "getno" : AppHelper.AppSetting.CallUrl + "/getno";
                string result = httpRequest.HttpGet(url, hashtable);
                LogHelper.Trace($"请求叫号机：{url}-{requestStr}-{result}");
                callEntity =  JsonConvert.DeserializeObject<CallEntity>(result);
            }
            catch (Exception ex)
            {
                LogHelper.Error("请求叫号机异常:" + ex.Message);
            }
            return callEntity;
        }

        public static void CallNo(string address, string plateNo)
        {
            CallEntity callEntity = null;
            try
            {
                var obj = new
                {
                    cmd = "Call",
                    CallerAddr = address,
                    CardNo = plateNo
                };
                string requestStr = JsonConvert.SerializeObject(obj);
                Hashtable hashtable = new Hashtable();
                hashtable.Add("data", requestStr);
                Live0xUtils.HttpUtils.HttpRequest httpRequest = new Live0xUtils.HttpUtils.HttpRequest();
                string url = AppHelper.AppSetting.CallUrl.EndsWith("/") ? AppHelper.AppSetting.CallUrl + "getno" : AppHelper.AppSetting.CallUrl + "/getno";
                string result = httpRequest.HttpGet(url, hashtable);
                LogHelper.Trace($"请求叫号机：{url}-{requestStr}-{result}");
                callEntity = JsonConvert.DeserializeObject<CallEntity>(result);
            }
            catch (Exception ex)
            {
                LogHelper.Error("请求叫号机异常:" + ex.Message);
            }
        }
    }
}
