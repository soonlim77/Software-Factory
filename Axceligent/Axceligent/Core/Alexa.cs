using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axceligent.Core
{
    public class Alexa
    {
         
        public  string ownername { get; set; }
        public  string greetingmessage { get; set; }

        public Alexa()
        {
            if (ownername == null)
            {
                ownername = "Alexa";
                greetingmessage = "hello";
            }


        }

        // action takes input and return void
        public void Configure(Action<Alexa> act)
        {
            act(this);
        }
     
        public string Talk()
        {
          
            return greetingmessage + "," + ownername;
            
        }
       

    }
}
