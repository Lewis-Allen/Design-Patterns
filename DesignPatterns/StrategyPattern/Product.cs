namespace StrategyPattern
{
    class Product
    {
        private double price;
        private string name;

        public Product(double price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
