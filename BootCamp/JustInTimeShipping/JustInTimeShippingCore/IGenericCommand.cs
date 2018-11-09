using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    // anytype of input and output
    public interface IGenericCommand<Tout,Tin>
    {
        Tout Execute(Tin input);
    }
}
