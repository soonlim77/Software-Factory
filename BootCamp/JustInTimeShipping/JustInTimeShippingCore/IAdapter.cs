using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    // Base adapter
    public interface IAdapter<Tout, Tin>
    {
        Tout Process(Tin input);
    }
}
