namespace Genericos{
    public class Genericos{

            public Genericos(){}

            public T Head<T>(T[] datos){
                return datos[0];
            }


            public T[] Tail<T>(T[] datos){
                T[] nuevosdatos = new T[datos.Length - 1];
                int excepcion = 0;
                for (int i = 1; i < datos.Length; i++)
                {
                    nuevosdatos[excepcion] = datos[i];
                    excepcion += 1;
                }
                return nuevosdatos;
            }
            

    public class Tupla<T1, T2>
    {
        public T1 Primero { get; }
        public T2 Segundo { get; }
        public Tupla(T1 primero, T2 segundo)
        {
            this.Primero = primero;
            this.Segundo = segundo;
        }
    }


            public Tupla<T1,T2>[] Zip<T1, T2>(T1[] dato_1, T2[] dato_2){
            Tupla<T1, T2>[] array = new Tupla<T1, T2>[Tamaño<T1,T2>(dato_1, dato_2)];            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Tupla<T1,T2>(dato_1[i], dato_2[i]);
            }
            return array;            
            }
            

            private int Tamaño<T1, T2>(T1[] valorA, T2[] valorB)
            {
            int Tamaño = 0;
            if (valorA.Length == valorB.Length)
            {
                Tamaño = valorA.Length;
            }
            else if (valorA.Length > valorB.Length)
            {
                Tamaño = valorB.Length;
            }
            else if (valorA.Length < valorB.Length)
            {
                Tamaño = valorA.Length;
            }
            return Tamaño;
            }   
    }
}