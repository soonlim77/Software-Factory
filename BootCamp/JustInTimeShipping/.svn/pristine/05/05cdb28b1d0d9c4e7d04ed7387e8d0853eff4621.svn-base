using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    [Serializable]
    public class ShippingDetailInfo : IEntity
    {
        public double Cost { get; set; }
        public double DeliveryTime { get; set; }
        public AddressInfo OriginAddress { get; set; }
        public AddressInfo DestinationAddress { get; set; }
        public long Id { get; set; }
        public PackageInfo PackageInfo { get; set; } 
        public DeliveryMethodEnum DeliveryMethod { get; set; }
        public bool IsInsured { get; set; }

        public ShippingDetailInfo()
        {
            IsInsured = false;
            this.Id = new Random().Next(99999, 99999999);
        }
    }

    public enum DeliveryMethodEnum
    {
        Air,
        Ground,
        Rail
    };
}
