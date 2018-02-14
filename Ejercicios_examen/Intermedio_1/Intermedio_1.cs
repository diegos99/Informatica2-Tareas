using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedio_1
{
    class Intermedio_1
    {
        static void Main(string[] args)
        {
            //Dados dos arreglos con numeros ordenados, juntarlos en un arreglo, 
            //tambien ordenados. Ej. [1,3,6,7,8] y [0,5] => [0,1,3,5,6,7,8]
            int[] array1 = new int[] { 1, 4, 8, 10, 14 };
            int[] array2 = new int[] { 0, 5 };

            int[] final_array = new int[array1.Length + array2.Length];

            bool siguiente = true;
            int array1_indi, array2_indi;
            array1_indi = 0;
            array2_indi = 0;
            int final_array_indi = 0;
            while (siguiente)
            {
                if (array1.Length == 0 || array2.Length == 0)
                {
                    agregar_array(array1, final_array, final_array_indi);
                    agregar_array(array2, final_array, final_array_indi);
                    break;
                }
                if (array1[array1_indi] < array2[array2_indi])
                {
                    final_array[final_array_indi] = array1[array1_indi];
                    array1 = array1.Where(val => val != array1[array1_indi]).ToArray();
                    final_array_indi++;
                }
                else
                {
                    final_array[final_array_indi] = array2[array2_indi];
                    array2 = array2.Where(val => val != array2[array2_indi]).ToArray();
                    final_array_indi++;
                }
            }
            for (int i = 0; i < final_array.Length; i++)
            {
                Console.WriteLine(final_array[i]);
            }
            Console.ReadKey();
        }

        public static void agregar_array(int[] array, int[] final_array, int Inicio)
        {
            for (int i = 0; i < array.Length; i++)
            {
                final_array[Inicio] = array[i];
                Inicio++;
            }
        }

    }
}
