
namespace BridgePattern
{
    public class Client
    {
        public static void Main()
        {
            IFood pizza = new Pizza(new Pineapple());
            pizza.Eat();

            IFood falafel = new Falafel(new Tuna());
            falafel.Trash();

            IFood pizzaWithTuna = new Pizza(new Tuna());
            pizza.Eat();
        }
    }
}
