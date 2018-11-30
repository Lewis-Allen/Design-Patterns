using DecoratorPattern.ConcreteComponents;
using DecoratorPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Client
    {
        public static void Main()
        {
            PizzaComponent tunaPizza = new TunaPizza();
            Console.WriteLine(tunaPizza.GetDescription());
            Console.WriteLine("Cost: " + tunaPizza.Cost());

            Console.WriteLine();

            CheeseDecorator pizzaWithCheese = new CheeseDecorator(tunaPizza);
            Console.WriteLine(pizzaWithCheese.GetDescription());
            Console.WriteLine("Cost: " + pizzaWithCheese.Cost());

            pizzaWithCheese.MeltCheese();

            Console.WriteLine();

            PizzaComponent deliciousPizza = new PepperoniDecorator(new PineappleDecorator(pizzaWithCheese));
            Console.WriteLine(deliciousPizza.GetDescription());
            Console.WriteLine("Cost: " + deliciousPizza.Cost());
        }
    }
}
