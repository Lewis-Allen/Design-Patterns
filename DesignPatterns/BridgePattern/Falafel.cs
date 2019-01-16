using System;

namespace BridgePattern
{
    public class Falafel : IFood
    {
        private IIngredient ingredient;

        public Falafel(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }

        public void Eat()
        {
            Console.Write("You eat the falafel ");
            ingredient.OnEat();
        }

        public void Trash()
        {
            Console.Write("You trash the falafel ");
            ingredient.OnTrash();
        }
    }
}
