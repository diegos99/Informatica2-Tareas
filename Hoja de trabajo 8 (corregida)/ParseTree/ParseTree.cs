using System;
using System.Collections.Generic;
using System.Text;

namespace ParseTree
{
    public class ParseTree : BinaryTree<string>
    {
        public ParseTree(string val, IBinTree<string> der, IBinTree<string> izq) : base(val, der, izq)
        {

        }

        public ParseTree(string val) : base(val)
        {
            this.val = val;
        }

        public override void SumaGrande()
        {

            int UltimaSuma = val.LastIndexOf("+");

            if (UltimaSuma == -1)
                return;

            this.Izqui = new ParseTree(val.Substring(0, UltimaSuma));
            this.Dere = new ParseTree(val.Substring(UltimaSuma + 1, val.Length - UltimaSuma - 1));
            this.val = "+";
            this.Izqui.Agrandar();
            this.Dere.Agrandar();
        }

        public override void MultiplicGrande()
        {
            int UltimaSuma = val.LastIndexOf("*");
            if (UltimaSuma == -1)
                return;

            this.Izqui = new ParseTree(val.Substring(0, UltimaSuma));
            this.Dere = new ParseTree(val.Substring(UltimaSuma + 1, val.Length - UltimaSuma - 1));

            this.val = "*";

            this.Izqui.Agrandar();
            this.Dere.Agrandar();
        }

        public override void Agrandar()
        {
            SumaGrande();
            MultiplicGrande();
        }

        public override int Resultado()
        {
            switch (val)
            {
                case "+":
                    return Izqui.Resultado() + Dere.Resultado();
                case "*":
                    return Izqui.Resultado() * Dere.Resultado();
            }
            return Int32.Parse(val);
        }
    }
}