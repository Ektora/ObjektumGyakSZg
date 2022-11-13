namespace ObjektumGyakSZG4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Macskak();
            Szamitogepek();
        }

        static void Szamitogepek()
        {
            Szamitogep sz1 = new Szamitogep();
            Szamitogep sz2 = new Szamitogep(2500, false);
            sz1.Kapcsol();
            Console.WriteLine($"A másolás eredménye {(sz1.ProgramMasol(800) ? "sikeres" : "sikertelen")}");
            Console.WriteLine($"A másolás eredménye {(sz1.ProgramMasol(400) ? "sikeres" : "sikertelen")}");
            Console.WriteLine($"A másolás eredménye {(sz2.ProgramMasol(1) ? "sikeres" : "sikertelen")}");
            Console.WriteLine(sz1);
            Console.WriteLine(sz2);
        }

        static void Macskak()
        {
            Macska m1 = new Macska(" Kormi ", 4.0, false);
            Macska m2 = new Macska(" Cirmi ", 3.5);

            if (m1.Eszik(0.2))
            {
                Console.WriteLine($"{m1.Nev} evett, a súlya: {m1.Suly}");
            }
            else
            {
                Console.WriteLine($"{m1.Nev} nem evett");
            }

            if (m2.Eszik(0.2))
            {
                Console.WriteLine($"{m2.Nev} evett, a súlya: {m2.Suly}");
            }
            else
            {
                Console.WriteLine($"{m2.Nev} nem evett");
            }

            m1.Futkos();
            m2.Futkos();
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }
    }
}