﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    public class calNormal : CalFather
    {
        public override double RealMoney(double money)
        {
            return money;
        }
    }
}
