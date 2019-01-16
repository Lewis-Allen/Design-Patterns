using System;

namespace StrategyPattern
{
    class CardPayment : IPaymentStrategy
    {
        private string cardNo;

        public CardPayment(string cardNo)
        {
            this.cardNo = cardNo;
        }

        public void MakePayment(double amount)
        {
            Console.WriteLine($"Made a payment of £{amount} using credit card no: {cardNo}");
        }
    }
}
