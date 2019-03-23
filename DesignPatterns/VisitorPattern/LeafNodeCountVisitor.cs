using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class LeafNodeCountVisitor : IVisitor
    {
        public int count { get; private set; } = 0;

        public void Visit(Leaf leaf)
        {
            count++;
        }

        public void Visit(Branch branch)
        {
            if (branch.Left != null)
            {
                branch.Left.Accept(this);
            }

            if (branch.Right != null)
            {
                branch.Right.Accept(this);
            }
        }
    }
}
