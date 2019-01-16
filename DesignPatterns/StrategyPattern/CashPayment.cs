using System;

namespace StrategyPattern
{
    class CashPayment : IPaymentStrategy
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Made a payment of £{amount} in cash.");
        }
    }
}
