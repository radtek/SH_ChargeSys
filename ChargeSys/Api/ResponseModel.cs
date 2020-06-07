using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main.Api
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            Code = 0;
            Message = "请求失败";
            DataCount = 0;
        }

        public int Code { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

        public int DataCount { get; set; }
    }
}
