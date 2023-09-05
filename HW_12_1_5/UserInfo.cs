using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_1_5
{
    internal class UserInfo
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public UserInfo(string login, string name, bool prem) 
        {
            Login = login;
            Name = name;    
            IsPremium = prem;
        }
    }
}
