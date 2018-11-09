﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public abstract class AbstractZoneDifferenceStrategy : IZoneDifferenceStrategy
    {
        protected abstract int GetZoneCoefficient(int firstDigit);
 




        // Returns the time zone difference by Postcode
        private int GetZoneDifference(string fromPostCode, string toPostCode)
        {
            int fromDigit = Convert.ToInt32(fromPostCode.Substring(0, 1));
            int toDigit = Convert.ToInt32(toPostCode.Substring(0, 1));
            int difference = Math.Abs(GetZoneCoefficient(fromDigit) - GetZoneCoefficient(toDigit)) + 1;
            return difference;
        }


        public int Difference(string originPostCode, string destPostCode)
        {
            return GetZoneDifference(originPostCode, destPostCode);
        }
    }
}
