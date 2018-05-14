using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Program
    {
        public static int Heap;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void HeapSort(int[] espacios)
        {
            Heapify(espacios);

            int comodin;
            for (int i = espacios.Length - 1; i > 0; i--)
            {
                comodin = espacios[i];
                espacios[i] = espacios[0];
                espacios[0] = comodin;
                ShiftDown(espacios, 0, i);
            }
        }

        public static void Heapify(int[] inicio)
		{
			Heap = inicio.Length - 1;

			for (int i = floop(inicio.Length); i >= 0; i--)
			{
				ShiftDown(inicio, i, inicio.Length - 1);
			}
		}

        public static void ShiftDown(int[] inicio, int i, int maximo)
		{
            
			int izquierdo = izqui(i);
			int derecha = derech(i);
			int indice = 0;	

			if (izquierdo <= Heap && inicio[izquierdo] > inicio[i] && izquierdo < maximo)
			{
				indice = izquierdo;
			}
			else
			{
				indice = i;
			}
			if (derecha <= Heap && inicio[derecha] > inicio[indice] && derecha < maximo)
			{
				indice = derecha;
			}

			if (indice != i)
			{
				int comodin = inicio[indice];
				inicio[indice] = inicio[i];
				inicio[i] = comodin;
				ShiftDown(inicio, indice, maximo);
			}

		}

		private static int floop(int currentIndex)
		{
			return (currentIndex - 1)/ 2;
		}

		private static int izqui(int currentIndex)
		{
			return currentIndex * 2 + 2;
		}

		private static int derech(int currentIndex)
		{
			return currentIndex * 2 + 1;
		}
    }
}
