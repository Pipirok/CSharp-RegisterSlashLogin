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
        public int age;
        public double weight;
        public int height;

        public Account(string _login, string _password, int _age, double _weight, int _height)
        {
            login = _login;
            password = _password;   
            age = _age; 
            weight = _weight;
            height = _height;
        }
    }
}
