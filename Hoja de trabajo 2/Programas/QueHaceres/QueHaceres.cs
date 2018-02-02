using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTrabajo2
{
    public class QueHaceres
    {
        public List<QueHacer> ListaTareas
        {
            get;
            set;
        }

        public QueHaceres()
        {
            ListaTareas = new List<QueHacer>();
        }
        public void AgregarTarea(QueHacer QueHacer)
        {
            ListaTareas.Add(QueHacer);
        }
        public void CompletarQueHacer()
        {
            for (int i = 0; i < ListaTareas.Count; i++)
            {
                if (ListaTareas[i].Estado == Estado.EnProgreso)
                {
                    ListaTareas[i].Completar();
                    break;
                }
            }
        }
        public bool EstaDisponible()
        {
            for (int i = 0; i < ListaTareas.Count; i++)
            {
                if (ListaTareas[i].Estado == Estado.EnProgreso)
                {
                    return false;
                }
            }
            return true;
        }
    }
}