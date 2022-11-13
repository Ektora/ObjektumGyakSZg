using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektumGyakSZG4
{
    internal class Szamitogep
    {
        public double MB { get; set; }
        public bool Bekapcsolva { get; set; }

        public Szamitogep(double mb, bool bekapcsolva)
        {
            MB = mb;
            Bekapcsolva = bekapcsolva;
        }
        public Szamitogep() : this(1024, false)
        { }

        public void Kapcsol()
        {
            Bekapcsolva = !Bekapcsolva;
        }
        public bool ProgramMasol(double meret)
        {
            if(Bekapcsolva && meret < MB)
            {
                MB -= meret;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"A számítógépen lévő szabad hely mérete {MB} MB és {(Bekapcsolva ? "bekapcsolt" : "kikapcsolt")} állapotban van";
        }
        
    }
}
