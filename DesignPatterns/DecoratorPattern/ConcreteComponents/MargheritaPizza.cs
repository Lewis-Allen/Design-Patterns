namespace DecoratorPattern.ConcreteComponents
{
    public class MargheritaPizza : PizzaComponent
    {
        public override double Cost()
        {
            return 10;
        }

        public override string GetDescription()
        {
            return "Plain pizza with cheese";
        }
    }
}
