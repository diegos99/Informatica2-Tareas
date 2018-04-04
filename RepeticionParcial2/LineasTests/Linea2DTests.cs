using System;
using Xunit;
using Lineas;

namespace LineasTest
{
    [TestClass]
    public class Linea2DTests
    {
        [TestMethod]
        public void TestLong()
        {
            Punto2D[] puntos = new Punto2D[] { new Punto2D(0, 0), new Punto2D(0, 3), new Punto2D(0, 6) };
            Linea2D linea2D = new Linea2D(puntos);
            Assert.AreEqual(6, linea2D.Longitud());
        }

        [TestMethod]
        public void TestPtoMasCerca()
        {
            Punto2D[] puntos = new Punto2D[] { new Punto2D(0, 0), new Punto2D(0, 3), new Punto2D(0, 6) };
            Linea2D linea2D = new Linea2D(puntos);
            Assert.AreEqual(puntos[0], linea2D.PuntoMasCercano(new Punto2D(0, 1)));
        }
    }
}
