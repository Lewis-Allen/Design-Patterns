using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class ShoppingList
    {
        private List<Product> shoppingList = new List<Product>();
        private IPaymentStrategy paymentStrategy;

        public void Add(Product product)
        {
            shoppingList.Add(product);
            Console.WriteLine($"Added {product.GetName()} to shopping list.");
        }

        public void Clear()
        {
            Console.WriteLine($"Cleared shopping list of {shoppingList.Count} items.");
            shoppingList = new List<Product>();
        }

        public void MakePayment()
        {
            if (paymentStrategy == null)
            {
                Console.WriteLine("Please set a payment strategy before making payment.");
            }
            else
            {
                double total = 0;
                Console.WriteLine("Shopping List:");
                foreach (Product p in shoppingList) {
                    Console.WriteLine($"  {p.GetName()} £{p.GetPrice()}");
                    total += p.GetPrice();
                }

                paymentStrategy.MakePayment(total);
            }
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }
    }
}
