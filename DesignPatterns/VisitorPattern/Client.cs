using System;

namespace VisitorPattern
{
    public class Client
    {
        public static void Main()
        {
            BinaryTree ints = new Branch(5, new Branch(4, new Leaf(2), new Leaf(3)), new Leaf(6));

            SumVisitor sumVisitor = new SumVisitor();
            ints.Accept(sumVisitor);

            Console.WriteLine($"The sum of the binary tree is {sumVisitor.Sum}");
        }
    }
}