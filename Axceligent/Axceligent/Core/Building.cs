using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.BusinessCore;
using Axceligent.Interface;

namespace Axceligent.Core
{
    public class Building
    {
       

        private List<string> complist;


        List<string> hc;

        public Building()
        {
             complist = new List<string>();
            hc = new List<string>();

        }
        public Building AddKitchen()
        {
            complist.Add("kitchen");
            return this;


        }

        public Building AddBedRoom(string rn)
        {
            complist.Add(rn + " room" );
            return this;

        }
        public Building AddBalcony()
        {
            complist.Add("Balcony");
            return this;

        }


        public void Build()
        {
          
            foreach (var i in complist)
            {

                hc.Add(i); 

            }

            complist.Clear();

        }

        public string Describe()
        {
            string sb = null;


            foreach (var r in hc)
            {
                sb += r + " , " ;
            }
            return sb;
        }
    }
}
