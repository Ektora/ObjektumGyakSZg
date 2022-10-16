
using ObjektumGyakSZg;
using System.Numerics;

public class ObjektumGyak{

    public static void Main(string[] args)
    {
        if(args.Length < 2)
        {
            Console.WriteLine("Nincs elég bemenet megadva");
        }
        else
        {
            int min = int.MaxValue;
            for(int i = 0; i< args.Length; i++)
            {
                if(min > int.Parse(args[i]))
                    min = int.Parse(args[i]);
            }
            Console.WriteLine($"A legkisebb szám: {min}");

        }

        /*
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
        
        Szamitogep szg1 = new Szamitogep();
        Szamitogep szg2 = new Szamitogep(2000, false);
        szg1.Kapcsol();
        Console.WriteLine($"A számítógépre a másolás sikeres: {(szg1.Masol(400) ? "igen" : "nem")}");
        Console.WriteLine($"A számítógépre a másolás sikeres: {(szg1.Masol(800) ? "igen" : "nem")}");
        Console.WriteLine($"A számítógépre a másolás sikeres: {(szg2.Masol(1) ? "igen" : "nem")}");
        Console.WriteLine(szg1);
        Console.WriteLine(szg2);

        */
    }

}
