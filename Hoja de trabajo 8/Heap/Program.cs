using System;

namespace Heap
{
    public class Program
    {
        public static int Heap;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        
        public static void ShiftDown(int[] Alfa, int i)
		{
			int izquierdo = Izqui(i);
			int derecho = Dere(i);
			int indice = 0;

			if (izquierdo <= Heap && Alfa[izquierdo] > Alfa[i])
			{
				indice = izquierdo;
			}
			else
			{
				indice = i;
			}
			if (derecho <= Heap && Alfa[derecho] > Alfa[indice])
			{
				indice = derecho;
			}

			if (indice != i)
			{
				int temporal = Alfa[indice];
				Alfa[indice] = Alfa[i];
				Alfa[i] = temporal;
				ShiftDown(Alfa, indice);
			}
		}

        
        public static void Heapify(int[] Alfa){
			Heap = Alfa.Length - 1;

			for (int i = floop(Alfa.Length); i >= 0; i--)
			{
				ShiftDown(Alfa, i);
			}
		}

        private static int floop(int IndiceActual){
			return (IndiceActual - 1)/ 2;
		}
		private static int Izqui(int IndiceActual){
			return IndiceActual * 2 + 2;
		}
		private static int Dere(int IndiceActual){
			return IndiceActual * 2 + 1;
		}
    }
}
