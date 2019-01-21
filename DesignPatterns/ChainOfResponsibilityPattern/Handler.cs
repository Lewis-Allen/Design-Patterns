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
