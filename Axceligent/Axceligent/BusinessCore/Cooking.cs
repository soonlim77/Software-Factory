using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Interface;

namespace Axceligent.BusinessCore
{
    public class Cooking : ISkill
    {
        public Cooking()
        {

        }
        public string PresentSkill()
        {
            return "Cooking";
        }
    }
}
