using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace JustInTimeShipping.Test
{
    [TestClass()]
    public class ShippingCostHandlerTest
    {

        [TestMethod()]
        public void ProcessAirPackageTest()
        {
           
            ShippingDetailInfo input = new ShippingDetailInfo();
            input.PackageInfo = PackageInfoFactory.GetLetterPackageInstance("Plain");
            input.PackageInfo.Weight = 20;
            input.DeliveryMethod = DeliveryMethodEnum.Air;
            input.OriginAddress = new AddressInfo("John Doe", "Happy Street", "KL", "Selangor", "56000");
            input.DestinationAddress = new AddressInfo("Jane Doe", "Sad Street", "KL", "Selangor", "56000"); 
                 
         
            ShippingCostCommand target = new ShippingCostCommand();

            ShippingDetailInfo actual;
                        
            actual = target.Execute(input);

            Assert.IsTrue(input.Cost==1.25);

        }


        [TestMethod()]
        public void ProcessGroundPackageTest()
        {

            ShippingDetailInfo input = new ShippingDetailInfo();
            input.PackageInfo = PackageInfoFactory.GetLetterPackageInstance("Plain");
            input.PackageInfo.Weight = 20;
            input.DeliveryMethod = DeliveryMethodEnum.Ground;
            input.OriginAddress = new AddressInfo("John Doe", "Happy Street", "KL", "Selangor", "56000");
            input.DestinationAddress = new AddressInfo("Jane Doe", "Sad Street", "KL", "Selangor", "56000");


            ShippingCostCommand target = new ShippingCostCommand();

            ShippingDetailInfo actual;

            actual = target.Execute(input);

            Assert.IsTrue(input.Cost == 1.25);

        }


        [TestMethod()]
        public void ProcessGroundBoxInsuredPackageTest()
        {

            ShippingDetailInfo input = new ShippingDetailInfo();
            input.IsInsured = true;
            input.PackageInfo = PackageInfoFactory.GetBoxPackageInstance(10,10,10);
            input.PackageInfo.Weight = 20;
            input.DeliveryMethod = DeliveryMethodEnum.Ground;
            input.OriginAddress = new AddressInfo("John Doe", "Happy Street", "KL", "Selangor", "56000");
            input.DestinationAddress = new AddressInfo("Jane Doe", "Sad Street", "KL", "Selangor", "56000");


            ShippingCostCommand target = new ShippingCostCommand();

            ShippingDetailInfo actual;

            actual = target.Execute(input);

            Assert.IsTrue(input.Cost == 1.275);

        }

        [TestMethod()]
        public void ProcessRailBoxInsuredPackageTest()
        {

            ShippingDetailInfo input = new ShippingDetailInfo();
            input.IsInsured = true;
            input.PackageInfo = PackageInfoFactory.GetBoxPackageInstance(10, 10, 10);
            input.PackageInfo.Weight = 20;
            input.DeliveryMethod = DeliveryMethodEnum.Rail;
            input.OriginAddress = new AddressInfo("John Doe", "Happy Street", "KL", "Selangor", "16000");
            input.DestinationAddress = new AddressInfo("Jane Doe", "Sad Street", "KL", "Selangor", "46000");


            ShippingCostCommand target = new ShippingCostCommand();

            ShippingDetailInfo actual;

            actual = target.Execute(input);

            Assert.IsTrue(input.Cost == 1.275);

        }

    }
}
