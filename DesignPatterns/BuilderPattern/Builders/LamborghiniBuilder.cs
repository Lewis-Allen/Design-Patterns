namespace BuilderPattern.Builders
{
    public class LamborghiniBuilder : ICarBuilder
    {
        public string Colour { get; set; }
        public int NumberOfDoors { get; set; }

        public Car GetResult()
        {
            return new Car("Lamborghini", NumberOfDoors, Colour);
        }
    }
}
