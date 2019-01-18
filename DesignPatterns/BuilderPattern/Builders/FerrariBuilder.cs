using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builders
{
    public class FerrariBuilder : ICarBuilder
    {
        public string Colour { get; set; }
        public int NumberOfDoors { get; set; }

        public Car GetResult()
        {
            return new Car("Ferrari", NumberOfDoors, Colour);
        }
    }
}
