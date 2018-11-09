using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAM;

namespace JustInTimeShippingCore
{
    public class SamWeightAdapter : IWeightAdapter
    {
        //constructor not returning anything. only initialize the properties of object
        public SamWeightAdapter()
        { 
        
        }
        public double GetWeight()
        {
            ScaleFactory factory = new ScaleFactory();
            ScaleProperties prop = new ScaleProperties();

            Scale scale = factory.CreateScale();
            scale.Tare();
            scale.UpdateWeight();            
            Decimal Weight = Math.Ceiling( scale.GetWeight());
            return (double)Weight;
        }
    }
}
