using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JustInTimeShipping.Test
{

    [TestClass()]
    public class DeliveryTimeHandlerTest
    {


        /// <summary>
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest()
        {
            DeliveryTimeCommand target = new DeliveryTimeCommand(); 
            ShippingDetailInfo input = TestShippingDetailFactory.GetAirBoxShippingDetailInstance();
            ShippingDetailInfo expected = TestShippingDetailFactory.GetAirBoxShippingDetailInstance();
            expected.DeliveryTime = 0.25;
            ShippingDetailInfo actual;
            actual = target.Execute(input);
            Assert.AreEqual(expected.DeliveryTime, actual.DeliveryTime);
           
        }
    }
}
