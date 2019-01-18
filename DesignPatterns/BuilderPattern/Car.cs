namespace BuilderPattern
{
    public class Car
    {
        private readonly string _colour;
        private readonly int _wheels;
        private readonly string _name;

        private Car(CarBuilder from)
        {
            this._colour = from.Colour;
            this._wheels = from.Wheels;
            this._name = from.Name;
        }

        public override string ToString()
        {
            return $"This {this._colour} car has {this._wheels} wheel(s) and is called {this._name}.\n";
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