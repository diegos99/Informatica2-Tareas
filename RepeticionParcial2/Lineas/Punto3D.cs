using System;

namespace Lineas
{
    public class Punto3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public Punto3D (double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}