﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustInTimeShippingCore;

namespace JustInTimeShipping.Test
{

    [TestClass()]
    public class DeliveryRequestHandlerTest
    {


        private DeliveryRequestInfo data = new DeliveryRequestInfo()
        {
            Depth = "1",
            Height = "1",
            Width = "1",
            Id = "23423",
            LType = "Plain",
            Type = "BG",
            Origin = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999"),
            Dest = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999")
        };

        private DeliveryRequestInfo dataDimensionAndPostCodeError = new DeliveryRequestInfo()
        {
            Depth = "0",
            Height = "0",
            Width = "0",
            Id = "23423",
            LType = "Plain",
            Type = "BG",
            Origin = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999999"),
            Dest = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999")
        };

        private DeliveryRequestInfo dataWithException = new DeliveryRequestInfo()
        {
            Depth = "A",
            Height = "0",
            Width = "0",
            Id = "23423",
            LType = "Plain",
            Type = "BG",
            Origin = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999999"),
            Dest = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999")
        };

        private DeliveryRequestInfo dataWithExceptionInPackageType = new DeliveryRequestInfo()
        {
            Depth = "0",
            Height = "0",
            Width = "0",
            Id = "23423",
            LType = "Plain",
            Type = "ZG",
            Origin = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999"),
            Dest = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999")
        };

        //private DeliveryRequestInfo dataWithExceptionInDeliveryType = new DeliveryRequestInfo("0","0","0",12345,"Plain","lZ", new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999"),new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999") );
                                                                                                                                
        private DeliveryRequestInfo dataWithExceptionInDeliveryType = new DeliveryRequestInfo()
        {
            Depth = "0",
            Height = "0",
            Width = "0",
            Id = "23423",
            LType = "Plain",
            Type = "LZ",
            Origin = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999"),
            Dest = new AddressInfo("John Doe", "Jalan GIla", "Gila Kuching", "Johor", "99999")
        };

        IGenericCommand<IResult, DeliveryRequestInfo> handler = new DeliveryRequestCommand();

        [TestMethod()]
        public void ProcessSuccessTest()
        {

            PrintData(data);
            IResult status = handler.Execute(data);
            PrintData(status);
            Assert.IsTrue(status.IsSuccess);
        }

        [TestMethod()]
        public void ProcessFailDimensionAndPostCodeTest()
        {
            PrintData(dataDimensionAndPostCodeError);
            IResult status = handler.Execute(dataDimensionAndPostCodeError);
            PrintData(status);
            Assert.IsFalse(status.IsSuccess);
        }


        [TestMethod()]
        public void ProcessFailWithExceptionMessageTest()
        {
            PrintData(dataWithException);
            IResult status = handler.Execute(dataWithException);
            PrintData(status);
            Assert.IsFalse(status.IsSuccess);
        }

        [TestMethod()]
        public void ProcessFailWithDeliveryTypeExceptionMessageTest()
        {
            PrintData(dataWithExceptionInDeliveryType);
            IResult status = handler.Execute(dataWithExceptionInDeliveryType);
            PrintData(status);
            Assert.IsFalse(status.IsSuccess);
        }

        [TestMethod()]
        public void ProcessFailWithPackageTypeExceptionMessageTest()
        {
            PrintData(dataWithExceptionInPackageType);
            IResult status = handler.Execute(dataWithExceptionInPackageType);
            PrintData(status);
            Assert.IsFalse(status.IsSuccess);
        }


        // Helper methods

        private void PrintData(DeliveryRequestInfo data)
        {
            Console.WriteLine("Type:" + data.Type);
            Console.WriteLine("Id:" + data.Id);
            Console.WriteLine("Origin: " + data.Origin.ToString());
            Console.WriteLine("Dest:" + data.Dest.ToString());
            Console.WriteLine("Ltype:" + data.LType);
            Console.WriteLine("Height:" + data.Height);
            Console.WriteLine("Width:" + data.Width);
            Console.WriteLine("Depth:" + data.Depth);
        }

        private void PrintData(IResult data)
        {
            Console.WriteLine("Processing.....");
            Console.WriteLine(" ");
            Console.WriteLine("Status:" + data.IsSuccess);
            Console.WriteLine("Message:" + data.Message);
        }
    }
}
