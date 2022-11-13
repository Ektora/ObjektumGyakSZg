using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumGyakSZG4
{
    internal class Macska
    {
        public string Nev { get; set; }
        public bool Ehese { get; set; }
        public double Suly { get; set; }

        public Macska(string nev, double suly, bool ehese)
        {
            Nev = nev;
            Ehese = ehese;
            Suly = suly;
        }

        public Macska(string nev, double suly) : this(nev, suly, true)
        {
        }

        public bool Eszik(double etel)
        {
            if (Ehese)
            {
                Suly += etel;
                Ehese = false;
                return true;
            }
            return false;
        }

        public void Futkos()
        {
            Suly -= 0.1;
            Ehese = true;
        }

        //• Készíts toString metódust az osztályhoz

        public override string ToString()
        {
            return $"{Nev} súlya {Suly} kg és jelenleg {(Ehese ? "éhes" : "nem éhes")}";
        }
    }
}
