namespace VisitorPattern
{
    public class Branch : BinaryTree
    {
        public BinaryTree Left { get; private set; }
        public BinaryTree Right { get; private set; }

        public Branch(int value, BinaryTree left, BinaryTree right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}