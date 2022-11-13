using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumGyakSZG4
{
    internal class Hallgato
    {

        public string Azonosito { get; set; }
        public int Evfolyam { get; set; }
        public int KreditSzam { get; set; }

    public Hallgato(string azonosito, int evfolyam, int kreditSzam)
        {
            Azonosito = azonosito;
            Evfolyam = evfolyam;
            KreditSzam = kreditSzam;
        }
    public Hallgato(string azonosito) : this(azonosito,1,0)
        {

        }

    public void TargyFelvesz(int kredit)
        {
            KreditSzam += kredit;
        }

    public bool Vizsgazik()
        {
            if(KreditSzam > 0)
            {
                Evfolyam++;
                KreditSzam = 0;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"A {Azonosito} számú hallgató a {Evfolyam} évfolyamba jár és {KreditSzam} kredite van";
        }
        

    }
}
