namespace DecoratorPattern
{
    public abstract class PizzaDecorator : PizzaComponent
    {
        private PizzaComponent pizzaComponent;

        public PizzaDecorator(PizzaComponent pizzaComponent)
        {
            this.pizzaComponent = pizzaComponent;
        }

        public override string GetDescription()
        {
            return pizzaComponent.GetDescription();
        }

        public override double Cost()
        {
            return pizzaComponent.Cost();
        }
    }
}
