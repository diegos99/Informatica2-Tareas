using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
        }
        private void Extra()
        {            
            object[] line = new Linea3D[10];
            line[0] = new Linea2D(new Punto2D[] { });
        }
    }
}
