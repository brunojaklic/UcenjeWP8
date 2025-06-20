using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{
    public class Program
    {


        public Program()
        {
            Console.WriteLine("Nasljedivanje");

            var oso = new Osoba() { Ime = "Marija", Prezime = "Kaz" };

            Predavac pre = new() { Ime = "Karlo", Prezime = "Lot", IBAN = "HR525865845256" };
            Polaznik pol = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099 / 325-636" };
            Polaznik pol1 = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099 / 325-636" };

            // što će se ispisati, metode Equals, GetHashCode i ToString se izvode u 1. prolazu iz klase Object
            Console.WriteLine(pol.Equals(pol1)); // False
            Console.WriteLine(pol.GetHashCode()); // 43942917
            Console.WriteLine(pol1.GetHashCode()); // 59941933
            Console.WriteLine(pol.ToString()); // Ucenje.E15Nasljedivanje.Polaznik

            // 2. prolaz, nakon pisanja prepisanih metoda
            Console.WriteLine(pol); // ovo je jednako kao da sam pozvao pol.ToString(), Karla Sep 099 / 325-636
            Console.WriteLine(pre);

        }

    }
}
