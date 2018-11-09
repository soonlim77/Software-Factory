using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    [Serializable]
    public class PackageInfo
    {
        /*
         This part is to initialize object (all its attribute) based on passed parameter 
         and return object with complete info in its factory class         
         */
         
        public BoxInfo BoxInfo { get;  set; }
        public LetterInfo LetterInfo { get;  set; }
        public double Weight{get; set;}
        public PackageTypeEnum PackageType { get; set; }

        public PackageInfo() { }

        public PackageInfo(int h, int w, int d)
        {

            this.PackageType = PackageTypeEnum.Box;
            this.BoxInfo = new BoxInfo(h, w, d);
            this.LetterInfo = null;

        }

        public PackageInfo(String proofType)
        {

            this.PackageType = PackageTypeEnum.Letter;
            this.LetterInfo = new LetterInfo(proofType);

            this.BoxInfo = null;

        }

       
    }

    public enum PackageTypeEnum
    {
        Box, Letter
    }

    public enum PackageProofTypeEnum
    {

        Plain,
        Weather_Proof,
        Fire_Proof
    }
}


