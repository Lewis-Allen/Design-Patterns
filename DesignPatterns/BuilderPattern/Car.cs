namespace BuilderPattern
{
    public class Car
    {
        private readonly string Colour;
        private readonly int Wheels;
        private readonly string Name;

        private Car(CarBuilder from)
        {
            this.Colour = from.Colour;
            this.Wheels = from.Wheels;
            this.Name = from.Name;
        }

        public override string ToString()
        {
            return $"This {this.Colour} car has {this.Wheels} wheel(s) and is called {this.Name}.\n";
        }

        public static CarBuilder Builder()
        {
            return new CarBuilder();
        }


        public class CarBuilder
        {
            internal string Colour;
            internal int Wheels;
            internal string Name;

            public CarBuilder WithName(string name)
            {
                this.Name = name;
                return this;
            }

            public CarBuilder WithWheels(int wheels)
            {
                this.Wheels = wheels;
                return this;
            }

            public CarBuilder WithColour(string colour)
            {
                this.Colour = colour;
                return this;
            }

            public Car Build()
            {
                return new Car(this);
            }
        }
    }
}