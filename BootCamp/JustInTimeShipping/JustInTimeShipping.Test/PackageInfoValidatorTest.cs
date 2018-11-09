using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JustInTimeShipping.Test
{
    
    
    /// <summary>
    ///This is a test class for PackageInfoValidatorTest and is intended
    ///to contain all PackageInfoValidatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PackageInfoValidatorTest
    {

             
        /// <summary>
        ///A test for Validate
        ///</summary>
        [TestMethod()]
        public void BoxInfoSuccessTest()
        {

            PackageInfo pinfo=PackageInfoFactory.GetBoxPackageInstance(20,10,5);
            pinfo.Weight = 30;
            PackageInfoValidator target = new PackageInfoValidator(); // TODO: Initialize to an appropriate value
            IResult expected = ResultFactory.GetSuccessResultInstance(); // TODO: Initialize to an appropriate value
            IResult actual = target.Validate(pinfo);

            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);
     
        }

        [TestMethod()]
        public void BoxInfoFailTest()
        {
            PackageInfo pinfo = PackageInfoFactory.GetBoxPackageInstance(0,0,0);
            PackageInfoValidator target = new PackageInfoValidator(); // TODO: Initialize to an appropriate value
            IResult expected = ResultFactory.GetFailResultInstance("All dimension of boxes must be greater than 0"); // TODO: Initialize to an appropriate value
            IResult actual = target.Validate(pinfo);
            Assert.AreEqual(expected.IsSuccess, actual.IsSuccess);

        }
    }
}
