using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas
{
    public abstract class LineaAbstracta<T> : ILineas<T>
    {

        public abstract T[] Puntos { get; }

        public double Longitud()
        {
            if (Puntos.Length == 0)
                return 0;

            double long = 0;
            for (int i = 0; i < Puntos.Length - 1; i++)
            {
                long += Distancia(Puntos[i], Puntos[i + 1]);
            }
            return long;
        }

        public T PuntoMasCercano(T punto)
        {
            T cerca = Puntos[0];

            for (int i = 0; i < Puntos.Length; i++)
            {
                if (Distancia(punto, Puntos[i]) < Distancia(punto, cerca))
                    cerca = Puntos[i];
            }
            return cerca;
        }

        public abstract double Distancia(T P1, T P2);
        
        
    }
}