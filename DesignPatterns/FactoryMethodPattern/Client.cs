using System;

namespace FactoryMethodPattern
{
    public class Client
    {
        public static void Main()
        {
            ShapeFactory factory = new ShapeFactory();

            IShape rectangle = factory.GetShape(Shape.Rectangle);
            Console.WriteLine(rectangle.GetDescription());

            IShape circle = factory.GetShape(Shape.Circle);
            Console.WriteLine(circle.GetDescription());

            IShape square = factory.GetShape(Shape.Square);
            Console.WriteLine(square.GetDescription());
        }
    }
}
