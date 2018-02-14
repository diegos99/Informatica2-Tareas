using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facil_4
{
    class Facil_4
    {
        //Dado dos strings, determinar si son palindromes (tienen las mismas letras pero en diferente orden)
        const int palind = 1;
        const int nopalind = 0;

        static void Main(string[] args)
        {
            char[] carateres;
            Console.WriteLine("Ingrese la palabra que desea analizar: ");

            string letr = Console.ReadLine();

            carateres = new char[letr.Length];
            carateres = letr.ToCharArray(0, letr.Length);
            Console.Write("El resultado del analisis fue ***************");
            if (analizar(0, carateres, letr.Length) == palind)
                Console.WriteLine("Es palindrome.");
            else
                Console.WriteLine("No es palindrome.");

            Console.ReadKey();
        }

        static int analizar(int posi, char[] palabra, int longi)
        {
            if (palabra[posi] == palabra[longi - posi - 1])
            {
                if (posi < longi - posi)
                    return (analizar(++posi, palabra, longi));
                else
                    return (palind);
            }
            return (nopalind);
        }
    }
}
