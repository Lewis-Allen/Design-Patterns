using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class PizzaComponent
    {
        public abstract string GetDescription();
        public abstract double Cost();
    }
}