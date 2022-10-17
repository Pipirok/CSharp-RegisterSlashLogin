using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class AccountManager
    {
        private static Account[] registeredAccounts = {new Account("johnDoe", "APass33$")};


        private static Account FindAccountByLogin(string login)
        {
            foreach (Account account in registeredAccounts)
            {
                if (account.login == login)
                {
                    return account;
                }
            }

            return null;
        }

        public static bool DoesAccountExist(string login)
        {
            foreach (Account account in registeredAccounts)
            {
                if (account.login == login)
                {
                    return true;
                }
            }

            return false;
        }
        public static Account Login(string login, string password)
        {
            Account account = FindAccountByLogin(login);
            if (!(account == null) && account.password == password)
            {
                return account;
            }
            return null;
        }

        public static Account Register(string login, string password)
        {
            if (DoesAccountExist(login))
            {
                return null;
            }

            Account newAcc = new Account(login, password);
            registeredAccounts = registeredAccounts.Append(newAcc).ToArray();
            return newAcc;
        }
    }
}
