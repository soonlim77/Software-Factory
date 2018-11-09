using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustInTimeShippingCore
{
    public class ZoneDifferenceStrategyFactory
    {
        private IZoneDifferenceStrategy timeZoneDifferenceDecorator = null;
        private IZoneDifferenceStrategy orientationZoneDifferenceDecorator = null;
        private static ZoneDifferenceStrategyFactory instance = null; 

        private ZoneDifferenceStrategyFactory() { }

        // Singleton implementation to get instance of the WeightAdatperInstance.
        public static ZoneDifferenceStrategyFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new ZoneDifferenceStrategyFactory();
            }
            return instance;
        }

        public IZoneDifferenceStrategy GetZoneDifferenceDecoratorInstance(DeliveryMethodEnum input)
        {
            IZoneDifferenceStrategy result = null;
            switch (input)
            {
                case DeliveryMethodEnum.Air:
                case DeliveryMethodEnum.Ground:
                    if (timeZoneDifferenceDecorator == null)
                    {
                        timeZoneDifferenceDecorator = new TimeZoneDifferenceStrategy();
                    }
                    result = timeZoneDifferenceDecorator;
                    break;
                case DeliveryMethodEnum.Rail:
                    if (orientationZoneDifferenceDecorator == null)
                    {
                        orientationZoneDifferenceDecorator = new OrientationZoneDifferenceStrategy();
                    }
                    result = orientationZoneDifferenceDecorator;
                    break;
                default:
                    break;
            }

            return result;
        }
    
    }

    public enum ZoneDifferenceDecoratorEnum
    {
        TimeZone,
        Orientation
    };
}
