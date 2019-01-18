using BuilderPattern.Builders;
using System;

namespace BuilderPattern
{
    public class Client
    {
        public static void Main()
        {
            ICarBuilder ferrariBuilder = new FerrariBuilder();
            SportsCarBuildDirector ferrariDirector = new SportsCarBuildDirector(ferrariBuilder);
            ferrariDirector.Construct();

            Car ferrari1 = ferrariBuilder.GetResult();
            Car ferrari2 = ferrariBuilder.GetResult();

            Console.WriteLine($"The cars brand is a {ferrari1.brand} and it's colour is {ferrari1.colour}");


            ICarBuilder lamborghiniBuilder = new LamborghiniBuilder();
            SportsCarBuildDirector lamborghiniDirector = new SportsCarBuildDirector(lamborghiniBuilder);
            lamborghiniDirector.Construct();

            Car lamborghini1 = lamborghiniBuilder.GetResult();
            Car lamborghini2 = lamborghiniBuilder.GetResult();

            Console.WriteLine($"The cars brand is a {lamborghini1.brand} and it's colour is {lamborghini1.colour}");
        }
    }
}
