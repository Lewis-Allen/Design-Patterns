using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Withdraw
    {
        public static void WithdrawAmount(Account account, double amount)
        {
            account.Balance -= amount;
        }
    }
}
