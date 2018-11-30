using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class PizzaDecorator : PizzaComponent
    {
        private PizzaComponent pizzaComponent;

        public PizzaDecorator(PizzaComponent pizzaComponent)
        {
            this.pizzaComponent = pizzaComponent;
        }

        public override string GetDescription()
        {
            return pizzaComponent.GetDescription();
        }

        public override double Cost()
        {
            return pizzaComponent.Cost();
        }
    }
}
