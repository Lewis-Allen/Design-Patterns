using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Pizza : IFood
    {
        public IIngredient ingredient;

        public Pizza(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }

        public void Eat()
        {
            Console.Write("You eat the pizza ");
            ingredient.OnEat();
        }

        public void Trash()
        {
            Console.Write("You thrash the pizza ");
            ingredient.OnTrash();
        }
    }
}
