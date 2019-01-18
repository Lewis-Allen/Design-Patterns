using System;

namespace TemplateMethodPattern
{
    public class Client
    {
        public static void Main()
        {
            Sandwich cheeseSandwich = new CheeseSandwich();
            cheeseSandwich.Make();
            cheeseSandwich.Eat();

            Console.WriteLine();

            Sandwich baconSandwich = new BaconSandwich();
            baconSandwich.Make();
            baconSandwich.Eat();
        }
    }
}
