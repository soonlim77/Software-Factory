using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Interface;
using Axceligent.Core;

namespace Axceligent.BusinessCore
{
    public class Balcony : RoomBase
    {
        public string name { get; set; }

        public Balcony()
        {
            this.name = "Balcony";
        }

       
    }
}
