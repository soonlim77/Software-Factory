using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Interface;
using Axceligent.BusinessCore;

namespace Axceligent.Core
{
    public class Humanoid
    {
        private  ISkill _skill { get; set; }
        public Humanoid(ISkill skill)
        {
            _skill = skill;
        }
        public Humanoid()
        {
            _skill = new NoSkill();

        }

        public string ShowSkill()
        {
            return _skill.PresentSkill();

        }
    }
}
