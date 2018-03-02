using System;
using Xunit;
using Reduce;
namespace ReduceTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestReduce()
        {
            int[] valores = new int[] { 2, 6, 8, 10 };
            Assert.AreEqual(Program.ReduceInt(valores, 0, (acumulador, val) => acumulador + val), 26);
        }

        [Fact]
        public void TestReduceGen()
        {
            string[] valores = new string[] { "Hola", "mundo", "progra" };
            Assert.AreEqual(Program.Reduce<string, int>(valores, 0, (acumulador, valor) => acumulador + valor.Length), 15);
        }
    }
}
