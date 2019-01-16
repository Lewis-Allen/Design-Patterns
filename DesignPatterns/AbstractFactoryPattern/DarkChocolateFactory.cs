namespace AbstractFactoryPattern
{
    class DarkChocolateFactory : IChocolateFactory
    {
        public IChocolateBar CreateBar()
        {
            return new DarkChocolateBar();
        }

        public IEasterEgg CreateEasterEgg()
        {
            return new DarkEasterEgg();
        }
    }
}
