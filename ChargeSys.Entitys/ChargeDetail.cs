﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Entitys
{
    public class ChargeDetail
    {
        public int ID { get; set; }

        public string PlateNo { get; set; }

        public string TestNo { get; set; }

        public string TestItem { get; set; }

        public int TestTimes { get; set; }

        public string Remark { get; set; }

        public Decimal Price { get; set; }
    }
}
