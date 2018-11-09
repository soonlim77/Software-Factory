using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JustInTimeShippingCore
{
    [Serializable]
    public class AddressInfo
    {
        public AddressInfo()
        {
        }

        public AddressInfo(string name, string street, string city, string state, string postalCode)
        {
            this.Name = name;
            this.Street = street;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
        }

        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return "{Name:" + Name + ",Street:" + Street + ",City:" + City + ",State:" + State + ",PostalCode:" + PostalCode + "}";
        }
    }
}
