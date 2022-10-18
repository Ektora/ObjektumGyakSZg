namespace ObjektumGyakSZg
{
    internal class Szamitogep
    {
        public double szabadMB;
        public bool beKapcsolt;

        public Szamitogep(double szabadMB, bool beKapcsolt)
        {
            this.szabadMB = szabadMB;
            this.beKapcsolt = beKapcsolt;
        }

        public Szamitogep() : this(1024, false)
        {

        }

        public void Kapcsol()
        {
            beKapcsolt = !beKapcsolt;
        }

        public bool Masol(double memoria)
        {
            if (beKapcsolt)
            {
                if (szabadMB >= memoria)
                {
                    this.szabadMB -= memoria;
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"A számítógép {(beKapcsolt ? "bekapcsolt" : "kikapcsolt")} állapotú {szabadMB} MB memóriával";
        }
    }
}
