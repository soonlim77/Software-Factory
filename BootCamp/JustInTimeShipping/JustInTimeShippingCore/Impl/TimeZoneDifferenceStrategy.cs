using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class TimeZoneDifferenceStrategy : AbstractZoneDifferenceStrategy
    {
        private static Int32[] TimeZoneCoefficient = new Int32[]
        {
            1, // 0
            1, // 1
            1, // 2
            2, // 3
            2, // 4
            2, // 5
            3, // 6
            3, // 7
            4, // 8
            4  // 9
        };


        protected override int GetZoneCoefficient(int firstDigit)
        {
            return TimeZoneCoefficient[firstDigit];
        }


    }
}
