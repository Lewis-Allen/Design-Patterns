namespace AbstractFactoryPattern
{
    class DarkChocolateBar : IChocolateBar
    {
        private string description = "A scrumptious, dark chocolate bar.";
        private string flavour = "Dark Chocolate";

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
