using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChargeSys.Entitys
{
    /// <summary>
    /// 收费项目配置
    /// </summary>
    public class ChargeDefine
    {
        public int ID { get; set; }

        public string ItemName { get; set; }

        public string ItemCode { get; set; }

        public string Times { get; set; }

        public double Price { get; set; }
    }
}
