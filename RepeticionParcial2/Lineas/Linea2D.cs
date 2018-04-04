using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas
{
    public class Linea2D : LineaAbstracta<Punto2D>{

        public override Punto2D[] Puntos {get;}
        public Linea2D(Punto2D[] puntos){
            Puntos = puntos;
        }
        public override double Distancia(Punto2D P1, Punto2D P2){
            double X2 = Math.Pow(P2.X - P1.X, 2);
            double Y2 = Math.Pow(P2.Y - P1.Y, 2);
            double distancia = Math.Sqrt(X2 + Y2);

            return distancia;
        }
    }
}