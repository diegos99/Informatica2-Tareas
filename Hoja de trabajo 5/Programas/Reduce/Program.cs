using System;

namespace Reduce
{
    class Program
    {
         public static int ReduceInt(int [] val, int acumulador, Func<int,int,int> reduccion){
            for (int i = 0; i < val.Length; i++){
                acumulador = reduccion(acumulador, val[i]);
            }
            return acumulador;
        }

        public static A Reduce<T, A>(T[] val, A accumulador, Func<A, T, A> reduccion){
            for (int i = 0; i < val.Length; i++){
                accumulador = reduccion(accumulador, val[i]);
            }
            return accumulador;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
