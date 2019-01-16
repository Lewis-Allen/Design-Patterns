namespace AbstractFactoryPattern
{
    class WhiteChocolateFactory : IChocolateFactory
    {
        public IChocolateBar CreateBar()
        {
            return new WhiteChocolateBar();
        }

        public IEasterEgg CreateEasterEgg()
        {
            return new WhiteEasterEgg();
        }
    }
}
