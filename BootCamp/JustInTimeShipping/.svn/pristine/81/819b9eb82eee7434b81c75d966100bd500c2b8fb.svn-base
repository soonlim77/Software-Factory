using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace JustInTimeShippingCore
{
    public class XmlPersistantCommand : IGenericCommand<IResult, ShippingDetailInfo>
    {

        public IResult Execute(ShippingDetailInfo input)
        {
          
            string path=String.Format("C:\\TEMP\\ShippingDetails-{0}.xml", input.Id);
            using (FileStream fs = File.Open(path, FileMode.Create,FileAccess.ReadWrite))
            {
                using (TextWriter WriteFileStream = new StreamWriter(fs))
                {
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ShippingDetailInfo));
                        serializer.Serialize(WriteFileStream, input);
                    }
                    catch (Exception e)
                    {

                        return ResultFactory.GetFailResultInstance(e.Message);
                    }
                                      
                }
            }

            return ResultFactory.GetSuccessWithMessageResultInstance(path); ;
        }
    }
}
