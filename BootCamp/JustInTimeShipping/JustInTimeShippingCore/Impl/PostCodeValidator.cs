using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace JustInTimeShippingCore
{
    public class PostCodeValidator : IValidator<String>
    {

        string pattern = "[0-9]+";

        public IResult Validate(string input)
        {

            if (input.Length == 5 && Regex.Match(input, pattern).Success)
            {
                return ResultFactory.GetSuccessResultInstance();
            }
            else
            {
                return ResultFactory.GetFailResultInstance("Postcode must be 5 digit only.");
            }
    
        }
    }
}
