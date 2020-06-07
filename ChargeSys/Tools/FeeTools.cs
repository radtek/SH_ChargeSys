using ChargeSys.Entitys;
using ChargeSys.Main.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main.Tools
{
    public class FeeTools
    {
        private static List<ChargeDefine> m_chargeDefines = new List<ChargeDefine>();
        
        public FeeTools()
        {
            ConstantApi constantApi = new ConstantApi();
            var resp = constantApi.GetChargeDefines();
            if (resp.Code == 1 && resp.DataCount > 0)
            {
                m_chargeDefines = JsonConvert.DeserializeObject<List<ChargeDefine>>(resp.Data?.ToString());
            }
        }

        public  decimal GetCharge(string itemName, int times)
        {
            decimal d = 0;
            var item = m_chargeDefines.Where(p => p.Times.Equals(times) && itemName.Equals(p.ItemName)).FirstOrDefault();
            if (item != null)
                d = item.Price;
            return d;
        }
    }
}
