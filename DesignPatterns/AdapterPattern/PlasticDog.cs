using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class PlasticDog : IToyDog
    {
        public void FakeBark()
        {
            Console.WriteLine("Bark Bark");
        }
    }
}
