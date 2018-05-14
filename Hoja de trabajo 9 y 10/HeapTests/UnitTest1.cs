using System;
using Xunit;
using Heap;

namespace HeapTests
{
    public class UnitTest1
    {
        [Fact]
        public void HeapfyTest()
        {
            int[] array = { 3, 6, 7, 5, 21, 13 };
            Program.Heapify(array);
            Assert.Equal(21, array[0]);
        }

        [Fact] 
        public void HeapSortTest()
        {
            int[] array = { 3, 6, 7, 5, 21, 81, 2, 102, 13 };
            Program.HeapSort(array);
            Assert.Equal(new int[] { 2, 3, 5, 6, 7, 13, 21, 81, 102 }, array);
        }
    }
}
