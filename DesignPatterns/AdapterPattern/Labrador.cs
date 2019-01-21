using System;

namespace AdapterPattern
{
    class Labrador : IDog
    {
        public void Bark()
        {
            Console.WriteLine("Woof Woof");
        }

        public void Run()
        {
            Console.WriteLine("The dog runs away!");
        }
    }
}
