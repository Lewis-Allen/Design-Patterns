namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(Branch branch);
        void Visit(Leaf leaf);
    }
}