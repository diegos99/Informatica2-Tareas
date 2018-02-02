using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTrabajo2
{       
    public enum Estado
    {
        EnProgreso, Terminado
    }
    public class QueHacer
    {
        //se declaran las propiedades
        public DateTime Dia {get; set;}
        public string Hacer {get; set;}
        public string Herramientas {get; set;}
        public Estado Estado {get; private set;}

        //se crea un metodo constructor del objeto QueHacer
        public QueHacer(DateTime dia, string hacer, string herramientas)
        {
            this.Dia = dia;
            this.Hacer = hacer;
            this.Herramientas = herramientas;
            this.Estado = new Estado();
            this.Estado = Estado.EnProgreso;
        }
        //Se crea una operacion
        public void Completar()
        {
            this.Estado = Estado.Terminado;
        }
    }
    
}