using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponents
{
    public class MargheritaPizza : PizzaComponent
    {
        public override double Cost()
        {
            return 10;
        }

        public override string GetDescription()
        {
            return "Plain pizza with cheese";
        }
    }
}
