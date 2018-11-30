using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadePattern
{
    public class Facade
    {
        Account account;
        FacadeForm form;
        public Facade(FacadeForm form)
        {
            account = new Account(300);
            this.form = form;
        }

        public void DepositAmount(double amount)
        {
            Deposit.DepositAmount(account, amount);
            PrintBalance();
        }

        public void WithdrawAmount(double amount)
        {
            Withdraw.WithdrawAmount(account, amount);
            PrintBalance();
        }

        private void PrintBalance()
        {
            form.textBox1.AppendText("Current balance is: " + account.Balance.ToString() + Environment.NewLine);
        }
    }
}
