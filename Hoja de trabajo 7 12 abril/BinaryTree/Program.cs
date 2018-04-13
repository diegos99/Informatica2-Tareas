using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IBinTree bin_Tree = new BinaryTree(
                5,
                new BinaryTree(4),
                new BinaryTree(
                    9,
                    new BinaryTree(8),
                    null
                )
            );
            Console.WriteLine(bin_Tree);
            Console.WriteLine(bin_Tree.Sumar());
        }
    }
}