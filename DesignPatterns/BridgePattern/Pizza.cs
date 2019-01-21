using System;

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
            Console.Write("You trash the pizza ");
            ingredient.OnTrash();
        }
    }
}
