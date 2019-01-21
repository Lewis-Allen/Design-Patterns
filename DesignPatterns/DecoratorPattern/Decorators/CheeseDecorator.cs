namespace DecoratorPattern.Decorators
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(PizzaComponent pizzaComponent) : base(pizzaComponent) { }

        private bool cheeseMelted = false;

        public override double Cost()
        {
            return base.Cost() + 1.5;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", extra cheese" + (cheeseMelted ? " melted" : "");
        }

        public void MeltCheese()
        {
            cheeseMelted = true;
        }
    }
}
