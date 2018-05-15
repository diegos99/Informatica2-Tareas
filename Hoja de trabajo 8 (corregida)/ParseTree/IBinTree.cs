using System;

public interface IBinTree<T>{
    T val {get;}
    IBinTree<T> Dere {get;}
    IBinTree<T> Izqui {get;}
    U Reduce<U>(U inicial, Func<U, U, T, U> fn);
    T[] ToArray();


    void SumaGrande();
    void MultiplicGrande();
    void Agrandar();
    int Resultado();
}

public interface IBinIntTree : IBinTree<int>
{
    int Menor();
    int Sumar();
}

public interface IParseTree
{

}