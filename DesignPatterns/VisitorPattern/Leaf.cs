namespace VisitorPattern
{
    public class Leaf : BinaryTree
    {
        public Leaf(int value)
        {
            Value = value;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}