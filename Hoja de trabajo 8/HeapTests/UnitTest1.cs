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
            int[] lista = { 3, 6, 7, 2, 18, 15 };
			Program.Heapify(lista);
			Assert.Equal(new int[] { 18, 15, 7, 6, 3, 2 }, lista);
        }
    }
}
