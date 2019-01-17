using System;

namespace PrototypePattern
{
    public class Client
    {
        public static void Main()
        {
            Prototype m = new Monster(10, 3, 2, 9, 9, 0.7);

            Prototype clone = m.Clone();
            Console.WriteLine(clone.ToString());
        }
    }
}
