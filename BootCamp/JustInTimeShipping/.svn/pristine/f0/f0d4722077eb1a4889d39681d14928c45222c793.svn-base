using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class ResultFactory
    {
        public static IResult GetSuccessResultInstance()
        {
            return new GenericResult(true);
        }

        public static IResult GetSuccessWithMessageResultInstance(string msg)
        {
            return new GenericResult(true, msg);

        }

        public static IResult GetFailResultInstance(string message)
        {
            return new GenericResult(false, message);
        }
    }
}
