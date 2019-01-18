using System;

namespace BuilderPattern
{
    public class Client
    {
        public static void Main()
        {
            var car1 = Car.Builder()
                .WithWheels(4)
                .WithColour("Red")
                .WithName("Carla")
                .Build();

            var car2 = Car.Builder()
                .WithColour("Blue")
                .WithWheels(3)
                .WithName("Ford")
                .Build();
            
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
        }
    }
}
