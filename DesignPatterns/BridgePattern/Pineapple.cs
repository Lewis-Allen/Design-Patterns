using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
