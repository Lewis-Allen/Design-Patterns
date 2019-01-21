using System;

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
