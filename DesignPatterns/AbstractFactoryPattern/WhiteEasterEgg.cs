namespace AbstractFactoryPattern
{
    class WhiteEasterEgg : IEasterEgg
    {
        private string description = "A delicious white easter egg.";
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
