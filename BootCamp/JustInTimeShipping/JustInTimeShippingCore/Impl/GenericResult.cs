﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class GenericResult : IResult
    {

        public GenericResult(bool value)
        {
            IsSuccess = value;
        }

        public GenericResult(bool value, string msg)
        {
            IsSuccess = value;
            Message = msg;
        }


        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
