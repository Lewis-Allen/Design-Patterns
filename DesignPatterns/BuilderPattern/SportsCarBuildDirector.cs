using BuilderPattern.Builders;

namespace BuilderPattern
{
    public class SportsCarBuildDirector
    {
        private ICarBuilder builder;
        public SportsCarBuildDirector(ICarBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.Colour = "Blue";
            builder.NumberOfDoors = 2;
        }
    }
}
