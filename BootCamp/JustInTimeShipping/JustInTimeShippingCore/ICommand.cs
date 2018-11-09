using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public interface ICommand<Tout, Tin>
    {
        Tout Execute(Tin input);
    }
}
