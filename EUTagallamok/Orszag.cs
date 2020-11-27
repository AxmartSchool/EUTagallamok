using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUTagallamok
{
    class Orszag
    {
        public string Nev { get; set; }
        public DateTime CsatlakozasDatuma { get; set; }




        public static List<Orszag> Beolvasas()
        {
            var output = new List<Orszag>();

            var sr = new StreamReader(@"..\..\EUcsatlakozas.txt",Encoding.UTF8);
            string[] tempTomb;
            while (!sr.EndOfStream)
            {

                tempTomb = sr.ReadLine().Split(';');
                output.Add(new Orszag() { Nev = tempTomb[0], CsatlakozasDatuma = DateTime.Parse(tempTomb[1]) });

            }

            sr.Close();

            return output;


        }
    }
}
