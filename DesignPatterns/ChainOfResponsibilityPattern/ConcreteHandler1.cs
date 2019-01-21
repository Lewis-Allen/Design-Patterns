using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
