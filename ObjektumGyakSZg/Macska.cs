using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumGyakSZg
{
    internal class Macska
    {
        /*


        • Az osztálynak legyen egy void futkos metódusa, ami nem vár paramétert. A macska
súlya csökkenjen 0.1-el, és ha nem volt éhes,
        */
        public String nev;
        public double suly;
        public bool ehese;

        public Macska(string nev, double suly, bool ehese)
        {
            this.nev = nev;
            this.suly = suly;
            this.ehese = ehese;
        }

        public Macska(string name, double suly) : this(name, suly, true)
        {

        }

        public void Futkos()
        {
            this.suly -= 0.10;
            if (!this.ehese)
                this.ehese = true;
        }

        public bool Eszik(double etelSuly)
        {
            if (!ehese)
            {
                return false;
            }
            this.suly += etelSuly;
            this.ehese = !this.ehese;
            return true;
        }

        public override string ToString()
        {
            return $"A macska súlya {Math.Round(this.suly,2)} kg és{(this.ehese ? "" : " nem")} éhes.";
        }

    }
}
