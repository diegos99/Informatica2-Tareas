
public class BinaryTree : IBinTree{
    public int Valor {get; set;}
    public IBinTree Derecho {get; set;}
    public IBinTree Izquierdo {get; set;}

    public BinaryTree(int valor, IBinTree derecho, IBinTree izquierdo){
        this.Valor = valor;
        this.Derecho = derecho;
        this.Izquierdo = izquierdo;
    }

    public BinaryTree(int valor){
        this.Valor = valor;
    }

    public override string ToString(){
        string derecho = this.Derecho == null ? string.Empty : this.Derecho.ToString();
        string izquierdo = this.Izquierdo == null ? string.Empty : this.Izquierdo.ToString();

        return $"{this.Valor} \n\t {derecho} \n\t {izquierdo}";
    }

    public int Sumar(){
        int sumaIzq = this.Izquierdo == null ? 0 : this.Izquierdo.Sumar();
        int sumaDer = this.Derecho == null ? 0 : this.Derecho.Sumar();

        return sumaDer + sumaIzq + this.Valor;
    }

    public int[] ToArray(){
        int[] answ = new int[0];
        var temporal = new int[0];
        if (this.Izquierdo != null){
            var izqui = Izquierdo.ToArray();
            answ = izqui;
        }

        temporal = new int[answ.Length + 1];
        answ.CopyTo(temporal, 0);
        var valu = new int[] { this.Valor };
        valu.CopyTo(temporal, answ.Length);
        answ = temporal;

        if (this.Derecho != null){
            var dere = Derecho.ToArray();
            temporal = new int[answ.Length + dere.Length];
            answ.CopyTo(temporal, 0);
            dere.CopyTo(temporal, answ.Length);
        }
        answ = temporal;
        return answ;
    }

public void Insert(int val){
        if (val <= this.Valor){
            if (Izquierdo == null){
                this.Izquierdo = new BinaryTree(val);
            } else{
                Izquierdo.Insert(val);
            }
        } else{
            if (Derecho == null){
                this.Derecho = new BinaryTree(val);
                }else
                Derecho.Insert(val);
        }
    }
}