using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Square : IShape
    {
        public string getDescription()
        {
            return "A basic square shape.";
        }
    }
}
