using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Account
    {
        public string login;
        public string password;

        public Account(string _login, string _password)
        {
            login = _login;
            password = _password;   
        }
    }
}
