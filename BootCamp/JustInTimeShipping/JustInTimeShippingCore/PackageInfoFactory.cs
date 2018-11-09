using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class PackageInfoFactory
    {

        // this factory class mainly for return the packageinfo object ( letter or box) depending on paramter passed

        public static PackageInfo GetLetterPackageInstance(string letterProofType)
        {
            return new PackageInfo(letterProofType);
        }


        public static PackageInfo GetBoxPackageInstance(int h, int w, int d)
        {
            return new PackageInfo(h, w, d);
        }
    }
}
