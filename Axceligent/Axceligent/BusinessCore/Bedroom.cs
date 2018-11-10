using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Interface;
using Axceligent.Core;

namespace Axceligent.BusinessCore
{
    public class Bedroom : RoomBase
    {
        public string name { set; get; }

        public Bedroom(string name)
        {
            this.name = name;
            
        }

        protected Bedroom()
        {
        }

        //public IRoom AddBedroom( string brname)
        //{
        //    Bedroom br = new Bedroom(brname);
            
        //    HouseComponent.HouseComponentList.Add(br);
        //    return br;
        //}
        //public Balcony AddBalcony()
        //{
        //    var bl = new Balcony();
        //    HouseComponent.HouseComponentList.Add(bl);
        //    return bl;


        //}
    }
}
