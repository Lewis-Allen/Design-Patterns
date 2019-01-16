namespace AbstractFactoryPattern
{
    class DarkEasterEgg : IEasterEgg
    {
        private string description = "A scrumptious, dark easter egg";
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
