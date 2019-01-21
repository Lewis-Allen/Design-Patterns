namespace ChainOfResponsibilityPattern
{
    public class Client
    {
        public static void Main()
        {
            Handler handlerChain = new ConcreteHandler1(new ConcreteHandler2(null));

            IRequest request1 = new ConcreteRequest1();
            handlerChain.HandleRequest(request1);

            IRequest request2 = new ConcreteRequest2();
            handlerChain.HandleRequest(request2);
        }
    }
}
