using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumGyakSZG4
{
    internal class Ember
    {
        string VezetekNev { get; set; }
        string KeresztNev { get; set; }
        int SzuletesiEv { get; set; }

        public Ember(string vezetekNev, string keresztNev, int szuletesiEv)
        {
            VezetekNev = vezetekNev;
            KeresztNev = keresztNev;
            SzuletesiEv = szuletesiEv;
        }

        public string HogyHivjak()
        {
            return VezetekNev + " " + KeresztNev;
        }

        //• A main metódusban hozz létre egy ember objektumot, és írd ki a nevét.
    }
}
