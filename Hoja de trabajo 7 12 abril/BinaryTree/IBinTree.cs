public interface IBinTree{
    int Valor {get; set;}

    IBinTree Derecho {get; set;}

    IBinTree Izquierdo {get; set;}

    int Sumar();
    int[] ToArray();
    void Insert(int value);
}