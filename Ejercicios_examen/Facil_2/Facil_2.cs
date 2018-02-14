using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facil_2
{
    class Facil_2
    {
        static void Main(string[] args)
        {
            //Dado un string, escribir un programa que determina si es un anagrama 
            //(se escribe igual en ambas direcciones, como toto)
            while (true)
            {
                string p1, p2;
                Console.Write("Ingrese una palabra: ");
                p1 = Console.ReadLine();
                if (p1.Length == 0)
                    break;
                else
                {
                    Console.Write("Ingrese otra palabra: ");
                    p2 = Console.ReadLine();
                    if (anagramichi(p1, p2) == false)
                        Console.Write("No son anagramas.");
                    else
                        Console.Write("Son anagramas.");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        public static bool anagramichi(string P1, string P2)
        {
            int cont1, cont2;
            if (P1.Length == P2.Length)
            {
                for (int i = 0; i < P1.Length; i++)
                {
                    cont1 = 0;
                    cont2 = 0;
                    for (int j = 0; j < P2.Length; j++)
                    {
                        if (P1[i] == P2[j])
                            cont1++;
                        if (P1[i] == P2[j])
                            cont2++;
                    }
                    if (cont1 != cont2)
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
