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
            MagyarorszagCsatlakozasa();
            MajusiCsatlakozas();
            UtoljaraCsatlakozott();



            Console.ReadKey();

        }

        private static void UtoljaraCsatlakozott()
        {

            //LINQ
            var utoljaraCsatlakozott = Orszagok.OrderByDescending(x => x.CsatlakozasDatuma).ToList()[0];

            Console.WriteLine($"7. feladat: Legutoljara csatlakozott orszag: {utoljaraCsatlakozott.Nev}");
        }

        private static void MajusiCsatlakozas()
        {
            //LINQ
            Console.WriteLine($"6. feladat: Majusban {(Orszagok.Any(x => x.CsatlakozasDatuma.Month == 5) ? "volt" : "nem volt")} csatlakozas!");

            
             

        }

        private static void MagyarorszagCsatlakozasa()
        {


            //LINQ
            var datum = Orszagok.Find(x => x.Nev.Contains("Magyar")).CsatlakozasDatuma.ToShortDateString();

            Console.WriteLine($"5. feladat: Magyarorszag csatlakozasanak datuma: {datum}");


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
