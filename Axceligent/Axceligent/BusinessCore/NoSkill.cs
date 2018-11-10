using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Interface;

namespace Axceligent.BusinessCore
{
    public class NoSkill : ISkill
    {
        public NoSkill()
        {

        }
        public string PresentSkill()
        {
            return "No SKill Defined";
        }
    }
}
