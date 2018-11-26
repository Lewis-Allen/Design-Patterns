using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
