using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class ConcreteHandler2 : Handler
    {
        public ConcreteHandler2(Handler successor) : base(successor)
        {}

        public override void HandleRequest(IRequest request)
        {
            if(request is ConcreteRequest2)
            {
                Console.WriteLine("Concrete Handler 2 handles this request");
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
