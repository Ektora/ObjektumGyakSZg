using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestObjektumGyakSZg2")]
namespace ObjektumGyakSZg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArgumentumFeldolgozas(args);
        }

        static void ArgumentumFeldolgozas(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nem megfelelő számú argumentum");
                return;
            }
            int[] tomb = args.Select(elem => Convert.ToInt32(elem)).ToArray();
            foreach (int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("A tömbben található elemek összege: " + ElemekOsszege(tomb));
            Console.WriteLine("A tömbben található elemek átlaga: {0:0.00}",ElemekAtlaga(tomb));
            Console.WriteLine($"A tömbben található legkisebb érték: {LegkisebbElem(tomb)} és a legnagyobb érték: {LegnagyobbElem(tomb)} - a két szám {(LegnagyobbOszthatoLegkisebbel(tomb) ? "" : "nem")} osztható egymással");
            Console.WriteLine($"A tömbben található {ParosSzamok(tomb)} db páros és {ParatlanSzamok(tomb)} db páratlan szám");
            Console.WriteLine($"A tömbben található {ParosVagyParatlanSzamok(tomb,true)} db páros és {ParosVagyParatlanSzamok(tomb, false)} db páratlan szám - {(ParosVagyParatlanSzamok(tomb, true) > ParosVagyParatlanSzamok(tomb, false) ? "páros" : "páratlan")} számból van több");
        }

        public static int ElemekOsszege(int[] tomb)
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            return osszeg;
        }

        public static double ElemekAtlaga(int[] tomb)
        {
            double atlag = tomb.Average();
            return atlag;
        }

        public static int LegkisebbElem(int[] tomb)
        {
            int min = tomb.Min();
            return min;
        }

        public static int LegnagyobbElem(int[] tomb)
        {
            int max = tomb.Max();
            return max;
        }

        public static bool LegnagyobbOszthatoLegkisebbel(int[] tomb)
        {
            return LegnagyobbElem(tomb) % LegkisebbElem(tomb) == 0;
        }

        public static int ParosSzamok(int[] tomb)
        {

            return tomb.Where(elem => elem % 2 == 0).Count();
        }

        public static int ParatlanSzamok(int[] tomb)
        {

            return tomb.Where(elem => elem % 2 != 0).Count();
        }

        
        public static int ParosVagyParatlanSzamok(int[] tomb, bool paros)
        {
            if (paros)
                return ParosSzamok(tomb);
            return ParatlanSzamok(tomb);
        }

    }
}
