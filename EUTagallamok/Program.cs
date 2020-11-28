using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUTagallamok
{
    class Program
    {

        static List<Orszag> Orszagok;

        static void Main(string[] args)
        {
            Orszagok = Orszag.Beolvasas();

            OrszagokSzama();



            Console.ReadKey();

        }

        private static void OrszagokSzama()
        {

            Console.WriteLine($"3. Feladat: EU tagallamainak szama: {Orszagok.Count}");


        }
    }
}
