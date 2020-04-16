using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChargeSys.Common.Dtos
{
    public class KVEntity
    {
        private string _key;

        private string _val;

        private string _defineType;

        public string Key { get => _key; set => _key = value; }
        public string Val { get => _val; set => _val = value; }
        public string DefineType { get => _defineType; set => _defineType = value; }
    }
}
