using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Interface;
using Axceligent.Core;

namespace Axceligent.BusinessCore
{
    public class Kitchen:RoomBase
    {
        public Kitchen()
        {
            this.name = "Kitchen";
        }

        public string name { set; get; }


       

        //public Bedroom AddBedroom(string rName)
        //{
        //    var br = new Bedroom(rName);
        //    HouseComponent.HouseComponentList.Add(br);
        //    return br;

        //}
    }
}
