using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTrabajo2
{
    public class Persona
    {
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public QueHaceres Tareas {get; set;}

        public Persona()
        {
            this.Tareas = new QueHaceres();
        }

        public bool EstaDisponible()
        {
            if (Tareas.EstaDisponible())
            {
                return true;
            }
            return false;
        }

        public void AgregarQueHacer(QueHacer QueHacer)
        {
            Tareas.AgregarTarea(QueHacer);
        }
        public void CompletarQueHacer()
        {
            Tareas.CompletarQueHacer();
        }
    }


}