using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInference
{
    class Account
    {

    }
    class AccountFactory
    {
        public static Account CreateSavingsAccount()
        {
            return new Account();
        }
    }
}
