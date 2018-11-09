using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JustInTimeShipping.Test
{
    

    [TestClass()]
    public class PostCodeValidatorTest
    {
        

        /// <summary>
        ///A test for Validate
        ///</summary>
        [TestMethod()]
        public void ValidateSuccessTest()
        {
            PostCodeValidator target = new PostCodeValidator(); 
            string input = "12345"; 
            IResult expected = ResultFactory.GetSuccessResultInstance();
            IResult actual;
            actual = target.Validate(input);
            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
            
        }

        [TestMethod()]
        public void ValidateFailTest()
        {
            PostCodeValidator target = new PostCodeValidator(); 
            string input = "123456";
            IResult expected = ResultFactory.GetFailResultInstance("Postcode must be 5 digit only.");
            IResult actual;
            actual = target.Validate(input);
            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
            
        }
    }
}
