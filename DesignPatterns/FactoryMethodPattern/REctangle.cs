using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Rectangle : IShape
    {
        public string getDescription()
        {
            return "A basic rectangle shape.";
        }
    }
}
