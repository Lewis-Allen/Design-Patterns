using System;
namespace FacadePattern
{
    class Account
    {
        public double Balance { get; internal set; }
        public Account(double startBalance)
        {
            this.Balance = startBalance;
        }

        public void PrintBalance()
        {
            Console.WriteLine(this.Balance);
        }
    }
}
