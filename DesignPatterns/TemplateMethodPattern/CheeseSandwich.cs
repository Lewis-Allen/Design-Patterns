using System;

namespace TemplateMethodPattern
{
    class CheeseSandwich : Sandwich
    {
        public override void AddSpread()
        {
            Console.WriteLine("You add some rich mayonnaise to the sandwich.");
        }

        public override void AddCheese()
        {
            Console.WriteLine("You grate some mature cheddar into the sandwich.");
        }

        public override void AddSalad()
        {
            Console.WriteLine("You place some lettuce into the sandwich.");
        }

        public override void Eat()
        {
            Console.WriteLine("You heartily consume the cheese sandwich.");
        }
    }
}
