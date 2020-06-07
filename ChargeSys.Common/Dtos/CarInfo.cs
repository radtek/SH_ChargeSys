using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Common.Dtos
{
    public class CarInfo
    {
        public string PlateNo { get; set; }

        public string Owner { get; set; }

        public string TestNo { get; set; }

        public decimal Price { get; set; }

        public int TestTimes { get; set; }

        public string Guider { get; set; }

        public string TestDate { get; set; }

        public string CarType { get; set; }

        public string MobilePhone { get; set; }

        public string Addr { get; set; }

        public string PlateType { get; set; }

        public string TestItem { get; set; }
    }
}
