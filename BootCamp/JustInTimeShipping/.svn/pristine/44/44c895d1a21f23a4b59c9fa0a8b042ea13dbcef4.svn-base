using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    // Ensure weight
    public class PackageInfoValidator : IValidator<PackageInfo>
    {

        #region IValidator<PackageInfo> Members
        public PackageInfoValidator()
        {

        }

        public IResult Validate(PackageInfo input)
        {
            if (input.PackageType == PackageTypeEnum.Box && input.Weight > 0)
            {
                if ((input.BoxInfo.Height <= 0) &&
                    (input.BoxInfo.Width <= 0) &&
                    (input.BoxInfo.Depth <= 0))
                {
                    return ResultFactory.GetFailResultInstance("All dimension of boxes must be greater than 0");
                }
            }


            if (input.Weight <= 0)
            {
                return ResultFactory.GetFailResultInstance("Please weight your package");
            }
           
            return ResultFactory.GetSuccessResultInstance();

        }





        #endregion
    }
}
