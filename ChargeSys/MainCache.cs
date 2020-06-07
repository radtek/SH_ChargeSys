using ChargeSys.Common;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main
{
    public abstract  class MainCache
    {
        private static List<ChargeDefine> _chargeDefines ;
        private static List<ConstantType> _constantTypes ;


        static MainCache()
        {
            Init();
        }

        public static void Init()
        {
            _chargeDefines = new List<ChargeDefine>();
            _constantTypes = new List<ConstantType>();
            try
            {
           
            }
            catch (Exception ex)
            {
                LogHelper.Error("值初始化异常" + ex.Message) ;
            }
        }

    

        public static List<ConstantType> GetConstantTypes()
        {
            ConstantApi constantApi = new ConstantApi();

            var respType = constantApi.GetConstantTypes();
            if (respType.Code == 1 && respType.DataCount > 0)
                _constantTypes = JsonConvert.DeserializeObject<List<ConstantType>>(respType.Data.ToString());
           return  _constantTypes;
        }
        

    }
}
