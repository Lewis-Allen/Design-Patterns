namespace AbstractFactoryPattern
{
    class WhiteChocolateBar : IChocolateBar
    {
        private string description = "A delicious, white chocolate bar.";
        private string flavour = "White Chocolate";

        public string GetDescription()
        {
            return this.description;
        }

        public string GetFlavour()
        {
            return this.flavour;
        }
    }
}
