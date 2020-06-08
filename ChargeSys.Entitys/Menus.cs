using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Entitys
{
   public class Menus
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string ParentName { get; set; }

        public string MenuName { get; set; }

        public string MenuPath { get; set; }

        public string OrderNo { get; set; }
    }
}
