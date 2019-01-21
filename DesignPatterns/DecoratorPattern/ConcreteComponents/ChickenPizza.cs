namespace DecoratorPattern.ConcreteComponents
{
    public class ChickenPizza : PizzaComponent
    {
        public override double Cost()
        {
            return 14;
        }

        public override string GetDescription()
        {
            return "Plain pizza with chicken";
        }
    }
}
