﻿using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JustInTimeShipping.Test
{
    
    
    /// <summary>
    ///This is a test class for ZoneDifferenceDecoratorFactoryTest and is intended
    ///to contain all ZoneDifferenceDecoratorFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ZoneDifferenceDecoratorFactoryTest
    {


      

        /// <summary>
        ///A test for GetZoneDifferenceDecoratorInstance
        ///</summary>
        [TestMethod()]
        public void GetZoneDifferenceDecoratorInstanceTest()
        {
            ZoneDifferenceStrategyFactory target = ZoneDifferenceStrategyFactory.GetInstance();
            DeliveryMethodEnum input = DeliveryMethodEnum.Rail;
            IZoneDifferenceStrategy expected = ZoneDifferenceStrategyFactory.GetInstance().GetZoneDifferenceDecoratorInstance(DeliveryMethodEnum.Rail);
            IZoneDifferenceStrategy actual;
            actual = target.GetZoneDifferenceDecoratorInstance(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
