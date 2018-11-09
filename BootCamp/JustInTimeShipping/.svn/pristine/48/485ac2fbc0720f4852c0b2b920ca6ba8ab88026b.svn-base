using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
   public class DeliveryTypeValidator:IValidator<String>
    {

      
        #region IValidator<string> Members

       public IResult Validate(string input)
        {
            if (!string.IsNullOrEmpty(input))
                return ResultFactory.GetSuccessResultInstance();
            else
                return ResultFactory.GetFailResultInstance("Delivery type can't be blank");


        }

        #endregion
   }
}
