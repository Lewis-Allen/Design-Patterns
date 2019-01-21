namespace VisitorPattern
{
    public abstract class BinaryTree : IVisitable
    {
        public int Value { get; protected set; }
        public abstract void Accept(IVisitor visitor);
    }
}