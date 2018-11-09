using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class ShippingCostCommand : IGenericCommand<ShippingDetailInfo, ShippingDetailInfo>
    {
        // Convert Ounce to Pound. If less than 1, then return 1
        private double OunceToPound(double ounce)
        {
            double result = ounce * 0.0625;
            return (result < 1 ? 1 : result);
        }

        // Calculate Package Volume. If less than 1, then return 1
        private double GetPackageVolume(PackageInfo packageInfo)
        {
            double result=1;
            switch (packageInfo.PackageType)
            {
                case PackageTypeEnum.Box:
                    result = packageInfo.BoxInfo.Width * packageInfo.BoxInfo.Height * packageInfo.BoxInfo.Depth;
                    break;
                case PackageTypeEnum.Letter:
                    result = 1;
                    break;
            }
            return (result < 1 ? 1 : result);
        }

        public ShippingDetailInfo Execute(ShippingDetailInfo input)
        {

            IZoneDifferenceStrategy zoneDiffDecor = ZoneDifferenceStrategyFactory.GetInstance().GetZoneDifferenceDecoratorInstance(input.DeliveryMethod);
            int zoneDifference = zoneDiffDecor.Difference(input.OriginAddress.PostalCode, input.DestinationAddress.PostalCode);

            switch (input.DeliveryMethod)
            {
                case DeliveryMethodEnum.Air:
                    input.Cost = zoneDifference * OunceToPound(Convert.ToDouble(input.PackageInfo.Weight)) * GetPackageVolume(input.PackageInfo);
                    break;
                case DeliveryMethodEnum.Rail:
                case DeliveryMethodEnum.Ground:
                    input.Cost = zoneDifference * OunceToPound(Convert.ToDouble(input.PackageInfo.Weight));
                    break;
                default:
                    throw new InvalidOperationException();
            }

            // Insurance Calculation
            if (input.IsInsured)
            {
                input.Cost *= 1.02;
            }
            
            return input;
        }

    }
}
