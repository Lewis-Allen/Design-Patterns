namespace DecoratorPattern.ConcreteComponents
{
    public class TunaPizza : PizzaComponent
    {
        public override double Cost()
        {
            return 12.5;
        }

        public override string GetDescription()
        {
            return "Plain pizza with tuna";
        }
    }
}
