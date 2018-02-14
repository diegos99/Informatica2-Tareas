using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facil_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dado un entero, escribir un programa que lo factorize a sus numeros primos: 80 -> [2,2,2,2,5]
            Console.WriteLine("Ingrese el No. que desea factorizar: ");
            string num = Console.ReadLine();

            while (!String.IsNullOrEmpty(num))
            {
                int valor;
                List<int> resultado;

                if (int.TryParse(num, out valor) && valor > 0)
                {
                    resultado = fact_prim(int.Parse(num));
                    Console.WriteLine(String.Join(",", resultado));
                }
                else
                    Console.WriteLine("Error...ingrese un No. entero y mayor que 0: ");

                num = Console.ReadLine();
            }

        }
        private static List<int> fact_prim(int prim)
        {
            List<int> resultado = new List<int>();
            if (prim == 1)
                resultado.Add(prim);
            else
            {
                while (prim > 1)
                {
                    int div = 2;
                    while (prim % div != 0)
                        div++;
                    prim = prim / div;
                    resultado.Add(div);
                }
            }
            return resultado;
        }
    }
}
