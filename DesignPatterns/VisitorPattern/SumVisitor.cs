using System;

namespace VisitorPattern
{
    class SumVisitor : IVisitor
    {
        public int Sum { get; private set; } = 0;

        public void Visit(Branch branch)
        {
            Console.WriteLine($"Adding Branch {branch.Value}...");
            Sum += branch.Value;
            branch.Left.Accept(this);
            branch.Right.Accept(this);
        }

        public void Visit(Leaf leaf)
        {
            Console.WriteLine($"Adding Leaf {leaf.Value}...");
            Sum += leaf.Value;
        }
    }
}