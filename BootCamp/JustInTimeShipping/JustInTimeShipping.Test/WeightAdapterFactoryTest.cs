﻿using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JustInTimeShipping.Test
{
    
    
    /// <summary>
    ///This is a test class for WeightAdapterFactoryTest and is intended
    ///to contain all WeightAdapterFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WeightAdapterFactoryTest
    {



        /// <summary>
        ///A test for GetWeightAdapterInstance
        ///</summary>
        [TestMethod()]
        public void GetWeightAdapterInstanceTest()
        {
            WeightAdapterEnum input = WeightAdapterEnum.SAM;
            WeightAdapterFactory factory = WeightAdapterFactory.GetInstance();
            IWeightAdapter expected = factory.GetWeightAdapterInstance(input);
            IWeightAdapter actual = factory.GetWeightAdapterInstance(input);
            Assert.AreEqual(expected, actual);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        // Test the Singleton GetInstance() method
        ///</summary>
        [TestMethod()]
        public void GetInstanceTest()
        {
            WeightAdapterFactory expected = WeightAdapterFactory.GetInstance();
            WeightAdapterFactory actual  = WeightAdapterFactory.GetInstance();
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
