using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumGyakSZG4
{
    internal class Harcos
    {

        private string nev;
        private int eletero;
        private int harciero;
    public string Nev { get => nev; set => nev = value; }
    public int Eletero { get => eletero; set => eletero = value; }
    public int Harciero { get => harciero; set => harciero = value; }

    public Harcos(string nev, int eletero, int harciero)
        {
            Nev = nev;
            Eletero = eletero;
            Harciero = harciero;
        }

    public bool Harcol(Harcos h)
        {
            Eletero -= h.Harciero;
            h.Eletero -= Harciero;
            if(h.Eletero <=0 || Eletero <=0)
                return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Nev} nevű harcos {Eletero} életerővel és {Harciero} harcierővel rendelkezik";
        }
    }
}
