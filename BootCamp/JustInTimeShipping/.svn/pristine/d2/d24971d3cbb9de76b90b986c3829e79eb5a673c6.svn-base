using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JustInTimeShipping.Test
{
    
    
    /// <summary>
    ///This is a test class for DeliveryTypeValidatorTest and is intended
    ///to contain all DeliveryTypeValidatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DeliveryTypeValidatorTest
    {


    
        [TestMethod()]
        public void DeliveryTypeSuccessTest()
        {
            DeliveryTypeValidator target = new DeliveryTypeValidator(); // TODO: Initialize to an appropriate value
            String input = "Air";
            IResult expected = ResultFactory.GetSuccessResultInstance();
            IResult actual;
            actual = target.Validate(input);
            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);

        }



        [TestMethod()]
        public void DeliveryTypeFailTest()
        {
            DeliveryTypeValidator target = new DeliveryTypeValidator(); // TODO: Initialize to an appropriate value
            String input = "";
            IResult expected = ResultFactory.GetFailResultInstance("Deliver type must be filled");
            IResult actual;
            actual = target.Validate(input);
            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);

        }
      

    }
}
