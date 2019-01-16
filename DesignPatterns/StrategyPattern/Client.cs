using System;

namespace StrategyPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            ShoppingList shoppingList = new ShoppingList();

            shoppingList.Add(new Product(1.13, "Cake"));
            shoppingList.Add(new Product(0.67, "Chocolate Bar"));
            shoppingList.Add(new Product(8.71, "Scales"));

            shoppingList.SetPaymentStrategy(new CashPayment());

            shoppingList.MakePayment();

            shoppingList.Clear();

            shoppingList.Add(new Product(1.99, "Orange Juice"));
            shoppingList.Add(new Product(2.00, "Baked Beans (4 pck)"));
            shoppingList.Add(new Product(1.25, "Potato Smiles"));

            shoppingList.SetPaymentStrategy(new CardPayment("1234-5678-9012-3456"));
            shoppingList.MakePayment();

            Console.ReadKey();
        }
    }
}
