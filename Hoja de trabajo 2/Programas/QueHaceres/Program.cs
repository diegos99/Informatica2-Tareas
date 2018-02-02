using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTrabajo2
{
    class Program
    {
        static void Main(string[] args)
        {
            QueHacer QueHacer1 = new QueHacer(new DateTime(), "Lavar el carro", "Manguera con agua");
            QueHacer QueHacer2 = new QueHacer(new DateTime(), "Tareas de programacion", "Computadora y programas");
            QueHacer QueHacer3 = new QueHacer(new DateTime(), "Cortar la grama", "Tijeras");
            QueHacer QueHacer4 = new QueHacer(new DateTime(), "Lavar la ropa", "Agua y jabon");
            QueHacer QueHacer5 = new QueHacer(new DateTime(), "Barrer el piso" , "Escoba y pala");
            QueHacer QueHacer6 = new QueHacer(new DateTime(), "Sacar la basura", "Bolsas");

            Persona Persona1 = new Persona();            
            Persona1.AgregarQueHacer(QueHacer1);
            Persona1.AgregarQueHacer(QueHacer3);
            Persona1.AgregarQueHacer(QueHacer4);
            Persona Persona2 = new Persona();
            Persona2.AgregarQueHacer(QueHacer2);
            Persona2.AgregarQueHacer(QueHacer5);
            Persona2.AgregarQueHacer(QueHacer6);

            Persona1.CompletarQueHacer();
            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();

            Console.WriteLine("¿Persona No.1 se encuentra disponible? {0}", Persona1.EstaDisponible());
            Console.WriteLine("¿Persona No.2 se encuentra disponible? {0}", Persona2.EstaDisponible());
            Console.ReadLine();
        }
    }
}
