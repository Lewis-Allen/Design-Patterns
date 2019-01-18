namespace BuilderPattern.Builders
{
    public interface ICarBuilder
    {
        string Colour { get; set; }
        int NumberOfDoors { get; set; }
        Car GetResult();
    }
}
