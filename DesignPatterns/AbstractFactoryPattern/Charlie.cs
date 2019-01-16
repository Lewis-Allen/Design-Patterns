using System;

namespace AbstractFactoryPattern
{
    public class Charlie
    {
        public static void Main()
        {
            // Create a new Dark Chocolate Factory.
            IChocolateFactory factory = new DarkChocolateFactory();

            // Use the factory to create a bar.
            IChocolateBar chocolate = factory.CreateBar();

            // Print flavour and description of bar.
            Console.WriteLine(chocolate.GetFlavour());
            Console.WriteLine(chocolate.GetDescription());

            factory = new WhiteChocolateFactory();

            IEasterEgg easterEgg = factory.CreateEasterEgg();

            Console.WriteLine(easterEgg.GetFlavour());
            Console.WriteLine(easterEgg.GetDescription());
        }
    }
}
