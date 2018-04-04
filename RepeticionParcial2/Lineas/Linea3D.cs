using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas
{
    class Linea3D : LineaAbstracta<Punto3D>{
        
        public override Punto3D[] Puntos { get; }
        public Linea3D(Punto3D[] puntos){
            Puntos = puntos;
        }
        public override double Distancia(Punto3D P1, Punto3D P2){
            double X2 = Math.Pow(P2.X - P1.X, 2);
            double Y2 = Math.Pow(P2.Y - P1.Y, 2);
            double Z2 = Math.Pow(P2.Z - P1.Z, 2);
            double distancia = Math.Sqrt(X2 + Y2 + Z2);

            return distancia;
        }
    }
}