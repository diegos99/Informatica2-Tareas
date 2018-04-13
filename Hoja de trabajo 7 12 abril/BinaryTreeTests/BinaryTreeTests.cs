using System;
using Xunit;

namespace BinaryTreeTests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void TestSuma()
        {
            IBinTree s = new BinaryTree(
                5,
                new BinaryTree(4),
                new BinaryTree(
                    9,
                    new BinaryTree(8),
                    null
                )
            );
            Assert.Equal(26, s.Sumar());
        }

        [Fact]
        public void TestInsert()
        {
            IBinTree s = new BinaryTree(8);
            s.Insert(10);
            s.Insert(15);
            s.Insert(26);
            s.Insert(3);
            s.Insert(11);
            s.Insert(99);
            s.Insert(7);
            int[] answ = s.ToArray();
            Assert.Equal(new int[] { 3, 7, 8, 10, 11, 15, 26, 99 }, answ);
        }
    }
}
