using System;

namespace ChainOfResponsibilityPattern
{
    class ConcreteHandler1 : Handler
    {
        public ConcreteHandler1(Handler successor) : base(successor)
        {}

        public override void HandleRequest(IRequest request)
        {
            if(request is ConcreteRequest1)
            {
                Console.WriteLine("Concrete Handler 1 handles this request");
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
