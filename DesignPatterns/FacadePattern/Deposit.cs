using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Deposit
    {
        public static void DepositAmount(Account account, double amount)
        {
            account.Balance += amount;
        }
    }
}
