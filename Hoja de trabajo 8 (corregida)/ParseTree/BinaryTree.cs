using System;
using System.Linq;

public abstract class BinaryTree<U> : IBinTree<U>{
    public U val {get; set;}

    public IBinTree<U> Dere { get; set; }

    public IBinTree<U> Izqui { get; set; }
   
    public BinaryTree(U val, IBinTree<U> der, IBinTree<U> izq){
        this.val = val;
        this.Dere = der;
        this.Izqui = izq;
    }

    public BinaryTree(U val){
        this.val = val;
    }

    public override string ToString(){
        string der = this.Dere == null ? string.Empty : this.Dere.ToString();
        string izq = this.Izqui == null ? string.Empty : this.Izqui.ToString();
        return $"{this.val} \n\t {der} \n\t {izq}";
    }
    public T Reduce<T>(T inicial, Func<T, T, U, T> fn)
    {
        T izq = inicial;
        T der = inicial;
        return fn(izq, der, this.val);
    }

    public U[] ToArray()
    {
        return this.Reduce<U[]>(new U[]{}, (izq, der, val) => {
            return izq.Concat(new U[]{val}).Concat(der).ToArray();
        });
    }

    public static int[] Concatenar(int[] a, int[] b)
    {
        int[] resultado = new int[a.Length + b.Length];
        int final = 0;

        for(int i = 0; i < a.Length; i++)
        {
            resultado[i] = a[i];
            final = i;
        }
        for(int j = 0; j < b.Length; j++)
        {
            resultado[a.Length - 1 + j] = b[j];
        }
        return resultado;
    }

    public abstract void SumaGrande();
    public abstract void MultiplicGrande();
    public abstract void Agrandar();
    public abstract int Resultado();
}