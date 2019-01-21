namespace DecoratorPattern.Decorators
{
    public class PineappleDecorator : PizzaDecorator
    {
        public PineappleDecorator(PizzaComponent pizzaComponent) : base(pizzaComponent) { }

        public override double Cost()
        {
            return base.Cost() + 0.5;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", extra pineapple (really?)";
        }
    }
    
}
