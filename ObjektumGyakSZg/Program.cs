
using ObjektumGyakSZg;
using System.Diagnostics;
using System.Linq;
public class ObjektumGyak
{

    public static void Main(string[] args)
    {
        //vegrehajtArgFeladatok1(args);
        //vegrehajtArgFeladatok2(args);
        //vegrehajtArgFeladatok3(args);
        //vegrehajtArgFeladatok4(args);
        //szamtaniSorozat(args);
        //mertaniSorozat(args);
        //fibonacciSorozat(args);
        //szovegHossz(args);
        //haromszogVizsgalat(args);
        kockaDobas(args);

    }

    static void kockaDobas(string[] args)
    {
        if(args.Length == 0) { 
            Console.WriteLine("Nincs bemenet");
            return;
        }
        var tomb = new int[6];
        Random random = new Random();
        Stopwatch sw = new Stopwatch();
        int n = Convert.ToInt32(args[0]);
        sw.Start();
        for (int i = 0; i<n; i++)
        {
            int szam = random.Next(1, 7);
            tomb[szam - 1]++;
        }
        for (int i = 0; i < tomb.Length; i++)
        {
            Console.WriteLine($"A {i+1} számot átlagosan {(tomb[i]/(double)n*100):0.00}% alkalommal dobtuk");
        }
        Console.WriteLine($"A futási ideje a fornak {sw.ElapsedMilliseconds} ms-ben");
    }

    #region 1-15 feladat
    static void haromszogVizsgalat(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Nem megfelelő az argumentumok száma!");
            return;
        }
        int a = int.Parse(args[0]), b = int.Parse(args[1]), c = int.Parse(args[2]);
        if(!(a < b + c && b < a + c && c < a + b))
        {
            Console.WriteLine("A megadott hosszakból nem lehet háromszöget készíteni");
            return;
        }
        double s, terulet;
        s = (a + b + c)/2.0;
        terulet = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Console.WriteLine($"Az a:{a} b:{b} c:{c} oldalú háromszög területe: {terulet} kerülete: {a+b+c} {s} ");
    }

    static void szovegHossz(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Nem megfelelő az argumentumok száma!");
            return;
        }
        int i,maxHossz = 0;
        for(i = 0; i< args.Length; i++)
        {
            if(maxHossz < args[i].Length)
                maxHossz = args[i].Length;
        }
        int[] hosszak = new int[maxHossz+1];

        for(i= 0; i< args.Length; i++)
        {
            hosszak[args[i].Length]++;
        }
        foreach (int item in hosszak)
        {
            Console.Write($"{item} ");
        }

    }

    static void fibonacciSorozat(string[] args)
    {
        Console.WriteLine("A Fibonacci sorozat:");
        if (args.Length != 1)
        {
            Console.WriteLine("Nem megfelelő az argumentumok száma!");
            return;
        }
        int[] tomb = new int[int.Parse(args[0])];
        int i;
        tomb[0] = 1;
        tomb[1] = 1;
        for (i = 2; i < tomb.Length; i++)
        {
            tomb[i] = tomb[i - 2] + tomb[i - 1];
        }
        Console.WriteLine("A sorozat n.-ik tagjának értéke: " + tomb[tomb.Length - 1]);
    }

    static void szamtaniSorozat(string[] args)
    {
        Console.WriteLine("A számtani sorozat:");
        if (args.Length != 3)
        {
            Console.WriteLine("Nem megfelelő az argumentumok száma!");
            return;
        }
        int elsoElem = int.Parse(args[0]), differencial = int.Parse(args[1]), i;
        int[] tomb = new int[int.Parse(args[2])];
        tomb[0] = elsoElem;
        for (i = 1; i < tomb.Length; i++)
        {
            tomb[i] = tomb[i - 1] + differencial;
        }
        for (i = 0; i < tomb.Length; i++)
        {
            Console.Write(tomb[i] + " ");
        }
    }

    static void mertaniSorozat(string[] args)
    {
        Console.WriteLine("A mértani sorozat:");
        if (args.Length != 3)
        {
            Console.WriteLine("Nem megfelelő az argumentumok száma!");
            return;
        }
        int elsoElem = int.Parse(args[0]), hanyados = int.Parse(args[1]), i;
        int[] tomb = new int[int.Parse(args[2])];
        tomb[0] = elsoElem;
        for (i = 1; i < tomb.Length; i++)
        {
            tomb[i] = tomb[i - 1] * hanyados;
        }
        for (i = 0; i < tomb.Length; i++)
        {
            Console.Write(tomb[i] + " ");
        }
    }
    static void vegrehajtArgFeladatok4(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Két argumentumnak kell lennie");
            return;
        }
        int x, y;
        if (!int.TryParse(args[0], out x) || !int.TryParse(args[1], out y))
        {
            Console.WriteLine("Az első vagy második argumentum nem megfelelő típusú");
            return;
        }
        for (int i = x; i < y; i++)
            Console.Write(i + " ");
    }

    static void vegrehajtArgFeladatok3(string[] args)
    {
        int paratlanSzamokOsszege = 0, parosSzamokOsszege = 0;
        for (int i = 0; i < args.Length; i++)
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
        int szam, osszesPozitiv = 0, osszesNegativ = 0, osszesNulla = 0;
        if (args.Length == 0)
            Console.WriteLine("Nincs bemeneti argumentum");
        else
        {
            for (int i = 0; i < args.Length; i++)
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
    #endregion

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
