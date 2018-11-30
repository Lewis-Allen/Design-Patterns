using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public class PineappleDecorator : PizzaDecorator
    {
        public PineappleDecorator(PizzaComponent pizzaComponent) : base(pizzaComponent) { }

        public override double Cost()
        {
            return base.Cost() + 0.5;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", extra pineapple (really?)";
        }
    }
    
}
