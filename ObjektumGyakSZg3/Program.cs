namespace ObjektumGyakSZg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            argumentumFeldolgozas(args);
        }

        static void argumentumFeldolgozas(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Nem megfelelő számú argumentum!");
                return;
            }
            szamKiirasNovekvo(Convert.ToInt32(args[0]));
            Console.WriteLine();
            szamKiirasCsokkeno(Convert.ToInt32(args[0]));
            Console.WriteLine();
            Console.WriteLine(osszeadas(Convert.ToInt32(args[0])));
        }

        static int osszeadas(int n)
        {
            if (n > 0) { 
            int osszeg = n + osszeadas(n - 1);
                return osszeg;
            }
            return 0;
        }

        static void szamKiirasNovekvo(int n)
        {
            if(n > 1)
            {
                szamKiirasNovekvo(n - 1);
                Console.Write($"{n} ");
            }
            else
            {
                Console.Write(n + " ");
            }
        }

        static void szamKiirasCsokkeno(int n)
        {
            if (n > 1)
            {
                Console.Write($"{n} ");
                szamKiirasCsokkeno(n - 1);
            }
            else
            {
                Console.Write(n);
            }
        }
    }

    
}