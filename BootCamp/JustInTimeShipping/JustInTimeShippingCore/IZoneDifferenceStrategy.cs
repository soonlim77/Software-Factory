﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public interface IZoneDifferenceStrategy
    {
        int Difference(string originPostCode, string destPostCode);
    }
}
