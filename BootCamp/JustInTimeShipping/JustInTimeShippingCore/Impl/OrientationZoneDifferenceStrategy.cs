﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class OrientationZoneDifferenceStrategy : AbstractZoneDifferenceStrategy
    {
        Int32[] Coefficient = new Int32[] 
        {
            1,
            1,
            1,
            1,
            1,
            2,
            2,
            2,
            2,
            2
        };

        protected override int GetZoneCoefficient(int firstDigit)
        {
            return Coefficient[firstDigit];
        }
    }
}
