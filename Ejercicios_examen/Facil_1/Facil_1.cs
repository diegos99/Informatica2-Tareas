using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facil_1
{
    class Facil_1
    {
        static void Main(string[] args)
        {
            //Dado un string, escribir un programa que invierta el orden de sus letras.
            //"Hola mundo" se vuleve "odnum aloH".
            string P1 = "";
            string P2 = "";

            Console.WriteLine("Ingrese lo que desea invertir: ");
            P1 = Console.ReadLine();

            for (int i = P1.Length - 1; i >= 0; i--)
            {
                P2 += P1[i];
            }
            Console.WriteLine("Sus letras invertidas son: " + P2);
            Console.ReadKey();
        }
    }
}
