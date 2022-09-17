
using ObjektumGyakSZg;

public class ObjektumGyak{

    public static void Main(string[] args)
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

}
