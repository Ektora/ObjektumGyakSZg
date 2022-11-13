namespace ObjektumGyakSZG4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Macskak();
            //Szamitogepek();
            //Hallgatok();
            //Tortak();
            //Emberek();
            Harcosok();
        }

        static void Harcosok()
        {
            Harcos h1 = new Harcos("Ektora",50,12);
            Harcos h2 = new Harcos("Feri", 34, 10);
            while (!h1.Harcol(h2));
            Console.WriteLine(h1);
            Console.WriteLine(h2);
        }

        static void Emberek()
        {
            Ember e = new Ember("Gipsz", "Jakab", 1958);
            Console.WriteLine(e.HogyHivjak());
        }

        static void Tortak()
        {

            Torta t1 = new Torta(4,true);
            Torta t2 = new Torta();
            Console.WriteLine($"A tortát {(t2.KremmelMegken()? "sikerült" : "nem sikerült")} megkenni");
            Console.WriteLine($"A tortát {(t2.KremmelMegken() ? "sikerült" : "nem sikerült")} megkenni");
            t1.UjEmelet();
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }

        static void Hallgatok()
        {

            Hallgato h1 = new Hallgato("MBVS7Z",2,24);
            Hallgato h2 = new Hallgato("BTF3PF");
            h1.TargyFelvesz(5);
            Console.WriteLine($"A hallgató {(h1.Vizsgazik() ? "sikeres" : "sikertelen")} vizsgát tett");
            Console.WriteLine(h1);
            Console.WriteLine(h2);
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