namespace DecoratorPattern.Decorators
{
    public class PepperoniDecorator : PizzaDecorator
    {
        public PepperoniDecorator(PizzaComponent pizzaComponent) : base(pizzaComponent) { }

        public override double Cost()
        {
            return base.Cost() + 3.5;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", extra pepperoni";
        }
    }
    
}
