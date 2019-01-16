using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Tuna : IIngredient
    {
        public void OnEat()
        {
            Console.WriteLine("and you like it because it has Tuna.");
        }

        public void OnTrash()
        {
            Console.WriteLine("because it has Tuna on it and you hate Tuna.");
        }
    }
}
