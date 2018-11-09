using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    // Make sure all the address is filled.
    public class AddressValidator : IValidator<AddressInfo>
    {
        public IResult Validate(AddressInfo input)
        {

            if (String.IsNullOrEmpty(input.Name) ||
                String.IsNullOrEmpty(input.Street) ||
                String.IsNullOrEmpty(input.City) ||
                String.IsNullOrEmpty(input.State) ||
                String.IsNullOrEmpty(input.PostalCode))
            {

                return ResultFactory.GetFailResultInstance("One of the address field is not being fill up.");
            }

            return ResultFactory.GetSuccessResultInstance();
           
        }
    }
}
