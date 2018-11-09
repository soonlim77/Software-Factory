﻿using JustInTimeShippingCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace JustInTimeShipping.Test
{


    /// <summary>
    ///This is a test class for XmlPersistantHandlerTest and is intended
    ///to contain all XmlPersistantHandlerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class XmlPersistantHandlerTest
    {


        /// <summary>
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest()
        {
            XmlPersistantCommand target = new XmlPersistantCommand(); // TODO: Initialize to an appropriate value
            ShippingDetailInfo input = TestShippingDetailFactory.GetGroundBoxShippingDetailInstance();


            string expected = String.Format("C:\\TEMP\\ShippingDetails-{0}.xml",input.Id); // TODO: Initialize to an appropriate value
            IResult actual;
            actual = target.Execute(input);
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(File.Exists(actual.Message));
            Assert.IsTrue(File.ReadAllBytes(actual.Message).Length > 0);

            StreamReader reader = new StreamReader(actual.Message);
            string strcontent = reader.ReadToEnd();
            Console.WriteLine(strcontent);
            reader.Close();
        }
    }
}
