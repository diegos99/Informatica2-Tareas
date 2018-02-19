using System;

public interface IList<T>
{    
    bool Get (int indice);
    bool Set (int indice, T elemento);
    void Push (T elemento);
    int Length { get; }
}
