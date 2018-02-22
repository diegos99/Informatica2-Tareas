abstract class Lista<T> : IList<T>
{
    public T elemento{get; private set;}

    public abstract int Length { get; }

    public abstract bool Get(int indice);

    public abstract void Push(T elemento);

    
    public abstract bool Set(int indice, T elemento);
}