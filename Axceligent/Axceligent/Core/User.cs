using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Axceligent.Core
{

    public class User
    {

        public  static List<string> _userlist=new List<string>();

        public User()
        {
           //_userlist = new List<string>();

        }

        public void Add(string u)
        {
            _userlist.Add(u);

        }

        public String GetUsersCount()
        {
            var uTotal = 0;

            if (_userlist.Count() != 0)
            {
                uTotal = _userlist.Count();
            }

            return uTotal.ToString();


        }
    }
}
