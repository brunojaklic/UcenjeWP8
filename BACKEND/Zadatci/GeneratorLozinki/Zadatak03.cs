using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLozinki
{
    public class Zadatak03
    {

        public static void Izvedi()
        {
            int duzina = DuzinaLozinke();
            bool velikaSlova = UcitajBool("Zelite li da lozinka sadrzi velika slova?");
            bool malaSlova = UcitajBool("Zelite li da lozinka sadrzi mala slova?");
            bool brojevi = UcitajBool("Zelite li da lozinka sadrzi brojeve?");
            bool interpunkcija = UcitajBool("Zelite li da lozinka sadrzi interpunkcijske znakove?");
            bool pocinjeBrojem = UcitajBool("Zelite li da lozinka pocinje s brojem?");
            bool pocinjeInterpunkcijskimZnakom = UcitajBool("Zelite li da lozinka pocinje s interpunkcijskim znakom?");
            bool zavrsavaBrojem = UcitajBool("Zelite li da lozinka zavrsava s brojem?");
            bool zavrsavaInterpunkcijskimZnakom = UcitajBool("Zelite li da lozinka zavrsava s interpunkcijskim znakom?");
            bool ponavljajuciZnakovi = UcitajBool("Zelite li da lozinka ima ponavljajuce znakove?");
            int brojLozinki = BrojLozinki();

        }


        public static int DuzinaLozinke()
        {
            while (true)
            {
                int duzina = Pomocno.UcitajCijeliBroj("Unesite duzinu lozinke: ");
                if (duzina >= 4 && duzina <= 20)
                    return duzina;
                else
                    Console.WriteLine("Duzina lozinke mora biti izmedu 4 i 20.");
            }
        }
        public static int BrojLozinki()
        {
            while (true)
            {
                int broj = Pomocno.UcitajCijeliBroj("Unesite broj lozinki: ");
                if (broj <= 10)
                    return broj;
                else
                    Console.WriteLine("Najveci broj lozinki je 10.");
            }
        }

        public static bool UcitajBool(string poruka)
        {
            while (true)
            {
                string odgovor = Pomocno.UcitajString(poruka + " (da/ne): ").ToLower();
                if (odgovor == "da") return true;
                if (odgovor == "ne") return false;
                Console.WriteLine("Nepravilan unos. Molimo odgovorite s 'da' ili 'ne'.");
            }
        }

    }
}
