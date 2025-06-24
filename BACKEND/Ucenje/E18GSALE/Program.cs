using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18GSALE
{
    public class Program
    {


        public Program()
        {

            Console.WriteLine("GSALE");

            var o = new Obrada<string>();

            o.PredmetObrade = "Osijek";
            //o.PredmetObrade = 67; // greska jer predmet obrade može biti samo string (<string>)
            o.Posao();

            var obrada = new Obrada<int>();
            obrada.PredmetObrade = 67;
            //obrada.PredmetObrade = "Osijek"; // greska jer predmet obrade moze biti samo int (<int>)
            obrada.Posao();

            var lista = new List<string>();
            // List<string> lista = new List<string>();

            lista.Add("Osijek");
            lista.Add("Zagreb");

            Console.WriteLine(lista[0]); // Osijek
            Console.WriteLine("*********************");

            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }

            var brojevi = new List<int>() { 2, 34, 4, 5, 6, 6, 4 };

            brojevi.Add(3);
            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(brojevi.Count);

            brojevi.RemoveAt(1);

            Console.WriteLine(brojevi.Count);

            Console.WriteLine(brojevi);

            Console.WriteLine("*********************");

            //var eo = new EdunovaObrada<string>(); Greska jer string ne nasljeduje Entitet
            var os = new Obrada<Smjer>(); // Smjer nasljeduje Object

            string ime = "sss";

            var eo = new EdunovaObrada<Smjer>();
            eo.Entitet = new Smjer() { Sifra = 1, Naziv = "WP" };
            eo.Posao();
            eo.OdradiPosao();

            var op = new EdunovaObrada<Polaznik>();
            op.Entitet = new Polaznik() { Sifra = 10, Ime = "Pero" };
            op.Posao();

            var lo = new Obrada<List<Smjer>>();








        }


    }
}
