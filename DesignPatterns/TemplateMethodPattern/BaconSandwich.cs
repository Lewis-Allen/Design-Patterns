using System;

namespace TemplateMethodPattern
{
    class BaconSandwich : Sandwich
    {
        public override void AddSpread()
        {
            Console.WriteLine("You add some butter to the sarnie.");
        }

        public override void AddMeat()
        {
            Console.WriteLine("You fry some bacon and add it to the sandwich.");
        }


        public override void Eat()
        {
            Console.WriteLine("You consume the delicious bacon sandwich.");
        }
    }
}
