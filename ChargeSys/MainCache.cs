﻿using ChargeSys.Common;
using ChargeSys.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Main
{
    public abstract class MainCache
    {
        private static List<ChargeDefine> _chargeDefines = new List<ChargeDefine>();
        private static List<ConstantType> _constantTypes = new List<ConstantType>();

        public static void Init()
        {
            _chargeDefines = AppHelper.DB.QueryList<ChargeDefine>("SELECT * FROM ChargeDefine", null).ToList();
            _constantTypes = AppHelper.DB.QueryList<ConstantType>("SELECT * FROM ConstantType", null).ToList();
        }

        //收费定义
        public static double GetCharge(string itemName, int times)
        {
            double d = 0;
            var item = _chargeDefines.Where(p => p.Times.Equals(times) && itemName.Equals(p.ItemName)).FirstOrDefault();
            if (item != null)
                d = item.Price;
            return d;
        }

        public static List<ConstantType> GetConstantTypes() => _constantTypes;
        

    }
}