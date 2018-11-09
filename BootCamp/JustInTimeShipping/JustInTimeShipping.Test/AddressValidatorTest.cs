﻿using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JustInTimeShipping.Test
{
    
    
    /// <summary>
    ///This is a test class for AddressValidatorTest and is intended
    ///to contain all AddressValidatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AddressValidatorTest
    {

        /// <summary>
        ///A test for address 
        ///</summary>
        [TestMethod()]
        public void ValidateSuccessTest()
        {
            AddressValidator target = new AddressValidator(); // TODO: Initialize to an appropriate value
            AddressInfo input =new AddressInfo("John","happy street","KL","Selangor","33333"); // TODO: Initialize to an appropriate value
            IResult expected = ResultFactory.GetSuccessResultInstance();
            IResult actual;
            actual = target.Validate(input);
            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
           
        }


        [TestMethod()]
        public void ValidateFailTest()
        {
            AddressValidator target = new AddressValidator(); // TODO: Initialize to an appropriate value
            AddressInfo input = new AddressInfo("John", "happy street", "", "Selangor", "33333"); // TODO: Initialize to an appropriate value
            IResult expected = ResultFactory.GetFailResultInstance("None of fields can be null");
            IResult actual;
            actual = target.Validate(input);
            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
        }

    }
}
