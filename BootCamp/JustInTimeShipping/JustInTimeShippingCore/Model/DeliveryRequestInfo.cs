﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class DeliveryRequestInfo
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public AddressInfo Origin { get; set; }
        public AddressInfo Dest { get; set; }
        public string LType { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string Depth { get; set; }
         

        public DeliveryRequestInfo() { }

        public DeliveryRequestInfo(string type, string id, AddressInfo origin, AddressInfo dest, string lType, string h, string w, string d)
        {
            Type = type;
            Id = id;
            Origin = origin;
            LType = lType;
            Height = h;
            Width = w;
            Depth = d;
           
        }
    }

}
