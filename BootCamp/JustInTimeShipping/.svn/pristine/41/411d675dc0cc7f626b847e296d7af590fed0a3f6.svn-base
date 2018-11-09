using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JustInTimeShippingCore;

namespace JustInTimeShipping.Test
{
    public class TestShippingDetailFactory
    {
        private static  AddressInfo address1=new AddressInfo("Johnny One", "Jalan Satu", "One City", "Selangor", "11111");
        private static AddressInfo address2 = new AddressInfo("Cass Two", "Jalan Dua", "Two City", "Selangor", "21111");
        private static AddressInfo address3 = new AddressInfo("What THree", "Jalan 3", "3 City", "Selangor", "31111");

        public static ShippingDetailInfo GetAirBoxShippingDetailInstance()
        {
            ShippingDetailInfo instance = new ShippingDetailInfo();
            instance.DeliveryMethod = DeliveryMethodEnum.Air;
            instance.PackageInfo = PackageInfoFactory.GetBoxPackageInstance(10, 10, 10);
            instance.DestinationAddress = address1;
            instance.OriginAddress = address2;
            
            return instance;
        }

        public static ShippingDetailInfo GetGroundBoxShippingDetailInstance()
        {
            ShippingDetailInfo instance = new ShippingDetailInfo();
            instance.DeliveryMethod = DeliveryMethodEnum.Ground;
            instance.PackageInfo = PackageInfoFactory.GetBoxPackageInstance(10, 10, 10);
            instance.DestinationAddress = address1;
            instance.OriginAddress = address2;

            return instance;
        }

        public static ShippingDetailInfo GetGroundLetterPlainShippingDetailInstance()
        {
            ShippingDetailInfo instance = new ShippingDetailInfo();
            instance.DeliveryMethod = DeliveryMethodEnum.Ground;
            instance.PackageInfo = PackageInfoFactory.GetLetterPackageInstance("Plain");
            instance.DestinationAddress = address1;
            instance.OriginAddress = address2;

            return instance;
        }

        public static ShippingDetailInfo GetAirLetterPlainShippingDetailInstance()
        {
            ShippingDetailInfo instance = new ShippingDetailInfo();
            instance.DeliveryMethod = DeliveryMethodEnum.Air;
            instance.PackageInfo = PackageInfoFactory.GetLetterPackageInstance("Plain");
            instance.DestinationAddress = address1;
            instance.OriginAddress = address2;

            return instance;
        }
    }
}
