
using ObjektumGyakSZg;
using System.Numerics;

public class ObjektumGyak{

    public static void Main(string[] args)
    {
        //vegrehajtArgFeladatok1(args);
        //vegrehajtArgFeladatok2(args);
        //vegrehajtArgFeladatok3(args);
        vegrehajtArgFeladatok4(args);
    }

    static void vegrehajtArgFeladatok4(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Két argumentumnak kell lennie");
            return;
        }
        int x, y;
        if (!int.TryParse(args[0], out x) || !int.TryParse(args[1],out y))
        {
            Console.WriteLine("Az első vagy második argumentum nem megfelelő típusú");
            return ;
        }
        for (int i = x; i < y; i++)
            Console.Write(i + " ");
    }

    static void vegrehajtArgFeladatok3(string[] args)
    {
        int paratlanSzamokOsszege = 0, parosSzamokOsszege = 0;
        for(int i = 0; i < args.Length; i++)
        {
            int szam = int.Parse(args[i]);
            if (szam % 2 == 0)
                parosSzamokOsszege += szam;
            else
                paratlanSzamokOsszege += szam;
        }
        Console.WriteLine($"A {(parosSzamokOsszege > paratlanSzamokOsszege ? "páros" : "páratlan")} számok összege a nagyobb");
    }

    static void vegrehajtArgFeladatok2(string[] args)
    {
        int szam, osszesPozitiv=0, osszesNegativ = 0, osszesNulla = 0;
        if (args.Length == 0)
            Console.WriteLine("Nincs bemeneti argumentum");
        else
        {
            for(int i = 0; i < args.Length; i++)
            {
                szam = int.Parse(args[i]);
                if (szam > 0)
                    osszesPozitiv++;
                else if (szam < 0)
                    osszesNegativ++;
                else
                    osszesNulla++;
            }
            Console.WriteLine($"Az összes pozítiv szám: {osszesPozitiv}");
            Console.WriteLine($"Az összes negatív szám: {osszesNegativ}");
            Console.WriteLine($"Az összes nulla: {osszesNulla}");
        }
    }
    static void vegrehajtArgFeladatok1(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Nincs elég bemenet megadva");
        }
        else
        {
            int min = int.MaxValue, pozitivMin = int.MaxValue, negativMax = int.MinValue;
            int max = int.MinValue;
            int szam, ossz = 0;
            for (int i = 0; i < args.Length; i++)
            {
                szam = int.Parse(args[i]);
                if (min > szam)
                    min = szam;
                if (pozitivMin > szam && szam >= 0)
                    pozitivMin = szam;
                if (max < szam)
                    max = szam;
                if (negativMax < szam && szam < 0)
                    negativMax = szam;

                ossz += szam;
            }
            Console.WriteLine($"A legkisebb szám: {min}");
            Console.WriteLine($"A legnagyobb szám: {max}");
            Console.WriteLine($"A számok összege: {ossz}");
            Console.WriteLine($"A számok átlaga: {ossz / args.Length}");
            Console.WriteLine($"A legkisebb pozitiv szám: {pozitivMin}");
            Console.WriteLine($"A legnagyobb negatív szám: {negativMax}");
        }
    }

    static void vegrehajtMacska()
    {
        Macska m1 = new Macska("Cirmi", 2.3, false);
        Macska m2 = new Macska("Kormos", 1.4);
        m1.Eszik(0.2);
        Console.WriteLine(m1);
        m1.Futkos();
        Console.WriteLine(m1);
        m2.Futkos();
        m2.Futkos();
        m2.Eszik(0.3);
        m2.Futkos();
        Console.WriteLine(m2);
    }

    static void vegrehajtSzamitogep()
    {
        Szamitogep szg1 = new Szamitogep();
        Szamitogep szg2 = new Szamitogep(2000, false);
        szg1.Kapcsol();
        Console.WriteLine($"A számítógépre a másolás sikeres: {(szg1.Masol(400) ? "igen" : "nem")}");
        Console.WriteLine($"A számítógépre a másolás sikeres: {(szg1.Masol(800) ? "igen" : "nem")}");
        Console.WriteLine($"A számítógépre a másolás sikeres: {(szg2.Masol(1) ? "igen" : "nem")}");
        Console.WriteLine(szg1);
        Console.WriteLine(szg2);
    }
}
