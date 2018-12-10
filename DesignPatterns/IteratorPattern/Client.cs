using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPattern
{
    public class Client
    {
        public static void Main()
        {
            List<int> ints = Enumerable.Range(1, 100).ToList(); 

            foreach(int num in ints)
            {
                if (num % 3 == 0)
                {
                    Console.Write("Fizz");
                }

                if (num % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                if(num % 3 != 0 && num % 5 != 0)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
            }
        }
    }
}
