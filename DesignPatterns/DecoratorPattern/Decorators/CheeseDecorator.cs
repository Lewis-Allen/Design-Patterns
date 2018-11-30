using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(PizzaComponent pizzaComponent) : base(pizzaComponent) { }

        private Boolean cheeseMelted = false;

        public override double Cost()
        {
            return base.Cost() + 1.5;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", extra cheese" + (cheeseMelted ? " melted" : "");
        }

        public void MeltCheese()
        {
            cheeseMelted = true;
        }
    }
}
