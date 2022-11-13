using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumGyakSZG4
{
    internal class Torta
    {

        public int EmeletekSzama { get; set; }
        public bool KremesE { get; set; }

        public Torta(int emeletekSzama, bool kremes)
        {
            EmeletekSzama = emeletekSzama;
            KremesE = kremes;
        }
        public Torta() : this(1, false)
        {

        }

        public void UjEmelet()
        {
            EmeletekSzama++;
        }

        public bool KremmelMegken()
        {
            if (!KremesE)
            {
                KremesE=true;
                return true;
            }
            return false;
        }

        public int MennyiKaloria()
        {
            int kaloria = EmeletekSzama * 1000;
            if (KremesE) kaloria *= 2;
            return kaloria;
        }

        public override string ToString()
        {
            return $"A torta {(KremesE ? "krémes" : "krém nélküli")} és {EmeletekSzama} emelet magas és {MennyiKaloria()} kalóriát tartalmaz";
        }
        
    }
}
