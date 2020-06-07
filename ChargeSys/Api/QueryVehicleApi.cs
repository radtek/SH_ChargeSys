using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main.Api
{
    public class QueryVehicleApi
    {
        public ResponseModel Query18J52(string plateNo,string user,string plateType,string vin)
        {
            var obj = new {
                dly = user,
                hpzl = plateType,
                hphm = plateNo,
                clsbdh = vin
            };
            ApiHelper apiHelper = new ApiHelper();
            return apiHelper.ReqPost("QueryCar/Query18J52", obj);
        }
    }
}
