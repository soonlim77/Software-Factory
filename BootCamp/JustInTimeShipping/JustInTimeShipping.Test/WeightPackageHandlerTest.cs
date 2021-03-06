﻿using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JustInTimeShipping.Test
{
    
    
    /// <summary>
    ///This is a test class for WeightPackageHandlerTest and is intended
    ///to contain all WeightPackageHandlerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WeightPackageHandlerTest
    {
         ShippingDetailInfo detail = new ShippingDetailInfo();
        
       


        /// <summary>
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest()
        {
            ShippingDetailInfo input = new ShippingDetailInfo(); 
            input.PackageInfo = PackageInfoFactory.GetLetterPackageInstance("Plain");
            input.DeliveryMethod = DeliveryMethodEnum.Ground;
            input.OriginAddress = new AddressInfo("John Doe", "Happy Street", "KL", "Selangor", "56000");
            input.DestinationAddress = new AddressInfo("Jane Doe", "Sad Street", "KL", "Selangor", "56000"); 

            SamWeightAdapter target = new SamWeightAdapter();
            
            double actual;

            Assert.IsTrue(input.PackageInfo.Weight == 0);

            actual = target.GetWeight();

            Assert.IsTrue(actual > 0);
           
        }
    }
}
