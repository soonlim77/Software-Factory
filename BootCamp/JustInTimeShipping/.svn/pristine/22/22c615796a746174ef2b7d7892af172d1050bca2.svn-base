using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class DeliveryRequestCommand : IGenericCommand<IResult, DeliveryRequestInfo>
    {
        public IResult Execute(DeliveryRequestInfo input)
        {
            ShippingDetailInfo data = new ShippingDetailInfo();
            IResult status = null;

            try
            {
                // Translate
                data.DestinationAddress = input.Dest;
                data.OriginAddress = input.Origin;
                data.Id = Convert.ToInt64(input.Id);

                // Translate Package Type
                switch (input.Type[0])
                {
                    case 'L':
                        data.PackageInfo = PackageInfoFactory.GetLetterPackageInstance(input.LType);
                        break;
                    case 'B':
                        data.PackageInfo = PackageInfoFactory.GetBoxPackageInstance(Convert.ToInt32(input.Height), Convert.ToInt32(input.Width), Convert.ToInt32(input.Depth));
                        break;
                    default:
                        throw new FormatException("The Type must start with 'L' or 'B' only.");
                }


                // Translate Delivery Type
                switch (input.Type[1])
                {
                    case 'A':
                        data.DeliveryMethod = DeliveryMethodEnum.Air;
                        break;
                    case 'G':
                        data.DeliveryMethod = DeliveryMethodEnum.Ground;
                        break;
                    default:
                        throw new FormatException("The second character in Type must be 'A' or 'G' only.");

                }
            }
            catch (Exception e)
            {
                status = ResultFactory.GetFailResultInstance(e.Message);
            }


            if (status == null) 
            {
                JustInTimeShippingFacade controller = JustInTimeShippingFacade.GetInstance();
                status = controller.Execute(data);
            }

            return status;
        }
    }
}
