﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Interface;


namespace Axceligent.Model
{
   public  class Person : IHuman
    {
        public string FirstName{ get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public GenderType Gender{ get; set; }
    }


}
