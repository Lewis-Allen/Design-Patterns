using System;

namespace FactoryMethodPattern
{
    public enum Shape { Square, Circle, Rectangle };

    class ShapeFactory
    { 
        public IShape GetShape(Shape shape)
        {
            IShape returnShape;
            switch (shape)
            {
                case Shape.Square:
                    returnShape = new Square();
                    break;

                case Shape.Rectangle:
                    returnShape = new Rectangle();
                    break;

                case Shape.Circle:
                    returnShape = new Circle();
                    break;

                default:
                    throw new ApplicationException("Supplied Shape not implemented.");
            }

            return returnShape;
        }

    }
}
