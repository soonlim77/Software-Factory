using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class WeightAdapterFactory
    {
        private IWeightAdapter SAMWeightAdapterInstance = null;
        private static WeightAdapterFactory instance = null; 

        private WeightAdapterFactory() 
        {
        
        }

        // Singleton implementation to get instance of the WeightAdatperInstance.
        public static WeightAdapterFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new WeightAdapterFactory();
            }
            return instance;
        }

        public IWeightAdapter GetWeightAdapterInstance(WeightAdapterEnum input)
        {
            IWeightAdapter result=null;
            switch (input)
            {
                case WeightAdapterEnum.SAM:
                    if (SAMWeightAdapterInstance == null)
                    {
                        SAMWeightAdapterInstance = new SamWeightAdapter();
                    }
                    result =  SAMWeightAdapterInstance;
                    break;
                default:
                    break;
            }

            return result;
        }
    }

    public enum WeightAdapterEnum { SAM };
}
