using System;

namespace BridgePattern
{
    class Pineapple : IIngredient
    {
        public void OnEat()
        {
            Console.WriteLine("and you like it because it has Pineapple.");
        }

        public void OnTrash()
        {
            Console.WriteLine("because it has Pineapple on it and you hate Pineapple.");
        }
    }
}
