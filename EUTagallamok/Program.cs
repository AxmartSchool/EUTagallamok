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
            CsatlakozottOrszagokSzama();


            Console.ReadKey();

        }

        private static void CsatlakozottOrszagokSzama()
        {
            int orszagokSzama = 0;

            foreach (var o in Orszagok)
            {
                if (o.CsatlakozasDatuma.Year == 2007)
                {
                    orszagokSzama++;
                }
            }

            //LINQ
            //orszagokSzama = Orszagok.Where(x => x.CsatlakozasDatuma.Year == 2007).Count();

            Console.WriteLine($"4. Feladat: 2007-ben {orszagokSzama} orszag csatlakozott.");


            
            
        }

        private static void OrszagokSzama()
        {

            Console.WriteLine($"3. Feladat: EU tagallamainak szama: {Orszagok.Count}");


        }
    }
}
