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
            if(branch.Left != null)
            {
                branch.Left.Accept(this);
            }

            if(branch.Right != null)
            {
                branch.Right.Accept(this);
            }
        }

        public void Visit(Leaf leaf)
        {
            Console.WriteLine($"Adding Leaf {leaf.Value}...");
            Sum += leaf.Value;
        }
    }
}