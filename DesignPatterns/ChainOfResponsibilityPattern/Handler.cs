using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        protected Handler Successor { get; }

        protected Handler(Handler successor)
        {
            this.Successor = successor;
        }

        public abstract void HandleRequest(IRequest request);
    }
}
