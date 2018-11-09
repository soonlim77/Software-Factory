using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using JustInTimeShippingCore;
using JustInTimeShippingWeb.Models;

namespace JustInTimeShippingWeb.Helpers
{
    public class ViewModelHelper
    {
        public static ShippingConfirmation ConvertToShippingConfirmation(ShippingDetailInfo detail)
        {

            ShippingConfirmation result = new ShippingConfirmation();
            result.Id = detail.Id;
            result.DCity = detail.DestinationAddress.City;
            result.DName = detail.DestinationAddress.Name;
            result.DStreet = detail.DestinationAddress.Street;
            result.DPostalCode = detail.DestinationAddress.PostalCode;
            result.DState = detail.DestinationAddress.State;

            result.OName = detail.OriginAddress.Name;
            result.OStreet = detail.OriginAddress.Street;
            result.OCity = detail.OriginAddress.City;
            result.OState = detail.OriginAddress.State;
            result.OPostalCode = detail.OriginAddress.PostalCode;

            result.DeliveryTime = detail.DeliveryTime;
            result.DeliveryType = detail.DeliveryMethod.ToString();

            result.Width = detail.PackageInfo.BoxInfo.Width;
            result.Depth = detail.PackageInfo.BoxInfo.Depth;
            result.Height = detail.PackageInfo.BoxInfo.Height;

            result.IsInsured = detail.IsInsured;
            result.LetterType = detail.PackageInfo.LetterInfo.LetterProofType.ToString();
            result.PackageType = detail.PackageInfo.PackageType.ToString();
            result.PackageWeight = detail.PackageInfo.Weight;
            result.ShippingCost = detail.Cost;

            result.DeliveryStatus = "Unknown";

            return result;
        }

        public static ShippingDetailInfo ConvertToShippingDetail(CreateShippingRequestViewModel model)
        {
            ShippingDetailInfo result = new ShippingDetailInfo();
            result.OriginAddress = new AddressInfo(model.OName, model.OStreet,model.OCity,model.OStreet,model.OPostalCode);
            result.DestinationAddress=new AddressInfo(model.DName,model.DStreet,model.DCity, model.DState,model.DPostalCode);
            result.Id = model.Id;
            result.IsInsured = model.IsInsured;
            result.PackageInfo=new PackageInfo()    //  Car c=new Car() {type"sedan" , wheels=4, color="red"};
            {
                BoxInfo = new BoxInfo() 
                {
                   Height=  model.Height,
                   Width = model.Width,
                   Depth = model.Depth
                },
                LetterInfo = new LetterInfo(model.LetterType),
                PackageType = ConvertPackageType(model.PackageType)
            };

            result.DeliveryMethod= ConvertDeliveryType(model.DeliveryType);
           return result;
        }

        private static PackageTypeEnum ConvertPackageType(string p)
        {
            if (PackageTypeEnum.Box.ToString().StartsWith(p))
            {
                return PackageTypeEnum.Box;
            }
            if (PackageTypeEnum.Letter.ToString().StartsWith(p))
            {
                return PackageTypeEnum.Letter;
            }
            throw new Exception("Package Type: "+ p + " not recognised");
        }

        private static DeliveryMethodEnum ConvertDeliveryType(string p)
        {
            if (p.CompareTo(DeliveryMethodEnum.Rail.ToString()) == 0)
            {
                return DeliveryMethodEnum.Rail;
            }
            if (p.CompareTo(DeliveryMethodEnum.Air.ToString()) == 0)
            {
                return DeliveryMethodEnum.Air;
            }
            if (p.CompareTo(DeliveryMethodEnum.Ground.ToString()) == 0)
            {
                return DeliveryMethodEnum.Ground;
            }
            throw new Exception("Delivery Type: "+p + " not recognised");
        }

        public static ShippingDetailInfo ConvertToShippingDetail(ShippingConfirmation model)
        {
            return null;
        }
    }
}