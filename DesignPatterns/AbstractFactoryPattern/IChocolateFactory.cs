namespace AbstractFactoryPattern
{
    interface IChocolateFactory
    {
        IEasterEgg CreateEasterEgg();
        IChocolateBar CreateBar();
    }
}
