
using ObjektumGyakSZg;
using System.Diagnostics;
using System.Linq;
using System.Net;

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
        //kockaDobas(args);
        //csokkenoVagyNovekvo(args);
        //rendelesek(args);
        //kerulet(args);
        //leghosszabbSzo(args);
        //szamologep(args);
        //szamologepBovitett(args);
        //jancsiEsJuliska(args);
        //dinnye(args);
        //haromszogek(args);
        reklam(args);
    }

    static void reklam(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Nem megfelelő számú argumentum");
            return;
        }
        for (int i = 0; i < Convert.ToInt32(args[2]); i++)
        {
            Console.Write(((i + 1) % 5) != 0 ? $"{args[0]}\n" : $"{args[1]}\n"); 
        }
    }

    static void haromszogek(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Nem megfelelő számú argumentum");
            return;
        }
        int n = Convert.ToInt32(args[0]), kerulet=0, legnagyobbKerulet=0, sorszam = 0, szamlalo =1;
        for (int i = 1; i < n * 3 + 1; i = i+3)
        {
            kerulet = Convert.ToInt32(args[i]) + Convert.ToInt32(args[i+1]) + Convert.ToInt32(args[i+2]);
            if (legnagyobbKerulet < kerulet)
            {
                legnagyobbKerulet = kerulet;
                sorszam = szamlalo;
            }
            szamlalo++;
        }
        Console.WriteLine("A legnagyobb kerületű háromszög sorszáma: " + sorszam);
    }

    static void dinnye(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Nem megfelelő számú argumentum");
            return;
        }
        int rohadtDinnye = args.Where(m => (Convert.ToInt32(m) % 3 == 0 && Convert.ToInt32(m) % 2 == 0)).Count();
        Console.WriteLine("A rohadt dinnyék száma: " + rohadtDinnye);
    }

    static void jancsiEsJuliska(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Nem megfelelő számú argumentum");
            return;
        }
        int n = Convert.ToInt32(args[0]);
        int[] tomb = new int[n];
        tomb[0] = 3;
        tomb[1] = 2;
        for (int i = 2; i < n; i++)
        {
            tomb[i] = tomb[i - 1] + tomb[i - 2];
        }
        Console.WriteLine("Az utolsó kereszteződésben lévő morzsák száma: " + tomb[n-1]);
    }

    static void szamologepBovitett(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Nem megfelelő számú argumentum");
            return;
        }
        int n = Convert.ToInt32(args[0]);
        int eredmeny = Convert.ToInt32(args[1]);
        int i = 0;
        while (i < n)
        {
            int szam = Convert.ToInt32(args[(3+i*2)]);
            switch (args[(2+i*2)])
            {
                case "+":
                    {
                        eredmeny += szam;
                        break;
                    }
                case "-":
                    {
                        eredmeny -= szam;
                        break;
                    }
                case "*":
                    {
                        eredmeny *= szam;
                        break;
                    }
                case "/":
                    {
                        eredmeny /= szam;
                        break;
                    }

            }
            i++;
        }
        Console.WriteLine($"A művelet eredménye: {eredmeny}");
    }
    static void szamologep(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Nem megfelelő számú argumentum");
            return;
        }
        double a = Convert.ToDouble(args[0]), b = Convert.ToDouble(args[2]),c=0;
        switch (args[1])
        {
            case "+":
                {
                    c = a + b;
                    break;
                }
            case "-":
                {
                    c = a - b;
                    break;
                }
            case "*":
                {
                    c = a * b;
                    break;
                }
            case "/":
                {
                    c = a / b;
                    break;
                }

        }
        Console.WriteLine($"{a} {args[1]} {b} = {c}");
    }

    static void leghosszabbSzo(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Nem megfelelő számú argumentum");
            return;
        }
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string leghosszabbSzo = args.OrderByDescending(s => s.Length).First();
        Console.WriteLine("A leghosszabb szó: " + leghosszabbSzo + " a lekérdezés ideje: " + stopwatch.ElapsedMilliseconds);
        stopwatch.Restart();
        int length = 0;
        string eredmeny = "";
        foreach (string str in args)
        {
            if (length < str.Length)
            {
                length = str.Length;
                eredmeny = str;
            }
        }
        Console.WriteLine("A leghosszabb szó: " + eredmeny + " a lekérdezés ideje: " + stopwatch.ElapsedMilliseconds);
    }

    static void kerulet(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Nem megfelelő számú argumentum!");
            return;
        }
        int n = Convert.ToInt32(args[0]), hossz = Convert.ToInt32(args[1]), kerulet = 0;
        for (int i = 0; i < n; i++)
        {
            kerulet += hossz;
        }
        Console.WriteLine("A sokszög kerülete: " + kerulet);
    }

    static void rendelesek(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Nincs megfelelő számú bemenet");
            return;
        }
        int rendelesOsszege = 0;
        int[] tomb = args.Select(elem => Convert.ToInt32(elem)).ToArray<int>();
        foreach (int item in tomb)
        {
            switch (item)
            {
                case 1:
                    {
                        rendelesOsszege += 1000;
                        break;
                    }
                case 2:
                    {
                        rendelesOsszege += 5000;
                        break;
                    }
                case 3:
                    {
                        rendelesOsszege += 7000;
                        break;
                    }
                case 4:
                    {
                        rendelesOsszege += 9000;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nem megfelelő sorszám!");
                        break;
                    }
            }
        }
        Console.WriteLine("A rendelés összege: " + rendelesOsszege);
    }

    static void csokkenoVagyNovekvo(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Az argumentumok száma kevés");
            return;
        }
        bool novekvo = true, csokkeno = true;
        int szam = Convert.ToInt32(args[0]);
        for (int i = 1; i < args.Length; i++)
        {
            if (szam < Convert.ToInt32(args[i]))
                csokkeno = false;
            else if (szam > Convert.ToInt32(args[i]))
                novekvo = false;
            else
            {
                csokkeno = false;
                novekvo = false;
                break;
            }
        }
        Console.WriteLine($"Az argumentumok {(novekvo ? "növekvő sorban vannak" : csokkeno ? "csökkenő sorban vannak" : "nincsenek sorban")}");
    }

    static void kockaDobas(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Nincs bemenet");
            return;
        }
        var tomb = new int[6];
        Random random = new Random();
        Stopwatch sw = new Stopwatch();
        int n = Convert.ToInt32(args[0]);
        sw.Start();
        for (int i = 0; i < n; i++)
        {
            int szam = random.Next(1, 7);
            tomb[szam - 1]++;
        }
        for (int i = 0; i < tomb.Length; i++)
        {
            Console.WriteLine($"A {i + 1} számot átlagosan {(tomb[i] / (double)n * 100):0.00}% alkalommal dobtuk");
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
        if (!(a < b + c && b < a + c && c < a + b))
        {
            Console.WriteLine("A megadott hosszakból nem lehet háromszöget készíteni");
            return;
        }
        double s, terulet;
        s = (a + b + c) / 2.0;
        terulet = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Console.WriteLine($"Az a:{a} b:{b} c:{c} oldalú háromszög területe: {terulet} kerülete: {a + b + c} {s} ");
    }

    static void szovegHossz(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Nem megfelelő az argumentumok száma!");
            return;
        }
        int i, maxHossz = 0;
        for (i = 0; i < args.Length; i++)
        {
            if (maxHossz < args[i].Length)
                maxHossz = args[i].Length;
        }
        int[] hosszak = new int[maxHossz + 1];

        for (i = 0; i < args.Length; i++)
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
