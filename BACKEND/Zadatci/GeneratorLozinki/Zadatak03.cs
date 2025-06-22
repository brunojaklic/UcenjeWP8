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

            bool ukljuciVelikaSlova = UcitajBool("Zelite li da lozinka sadrzi velika slova?");
            bool ukljuciMalaSlova = UcitajBool("Zelite li da lozinka sadrzi mala slova?");
            bool ukljuciBrojeve = UcitajBool("Zelite li da lozinka sadrzi brojeve?");
            bool ukljuciInterpunkciju = UcitajBool("Zelite li da lozinka sadrzi interpunkcijske znakove?");

            bool pocinjeBrojem = false;
            bool pocinjeInterpunkcijom = false;

            if (UcitajBool("Zelite li da lozinka pocinje posebnim znakom (broj ili interpunkcija)?"))
            {
                pocinjeBrojem = UcitajBool("Zelite li da lozinka pocinje brojem?");
                if (!pocinjeBrojem)
                {
                    pocinjeInterpunkcijom = UcitajBool("Zelite li da lozinka pocinje interpunkcijskim znakom?");
                }
            }

            bool zavrsavaBrojem = false;
            bool zavrsavaInterpunkcijom = false;

            if (UcitajBool("Zelite li da lozinka zavrsava posebnim znakom (broj ili interpunkcija)?"))
            {
                zavrsavaBrojem = UcitajBool("Zelite li da lozinka zavrsava brojem?");
                if (!zavrsavaBrojem)
                {
                    zavrsavaInterpunkcijom = UcitajBool("Zelite li da lozinka zavrsava interpunkcijskim znakom?");
                }
            }

            bool ponavljajuciZnakovi = UcitajBool("Zelite li da lozinka ima ponavljajuce znakove?");
            int brojLozinki = BrojLozinki();

            for (int i = 0; i < brojLozinki; i++)
            {
                StringBuilder lozinka = GenerirajLozinku(
                    duzina,
                    ukljuciVelikaSlova,
                    ukljuciMalaSlova,
                    ukljuciBrojeve,
                    ukljuciInterpunkciju,
                    pocinjeBrojem,
                    pocinjeInterpunkcijom,
                    zavrsavaBrojem,
                    zavrsavaInterpunkcijom,
                    ponavljajuciZnakovi
                );

                Console.WriteLine($"Lozinka {i + 1}: {lozinka}");
            }

        }



        public static int DuzinaLozinke()
        {
            while (true)
            {
                int duzina = Pomocno.UcitajCijeliBroj("Unesite duzinu lozinke");
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
                int broj = Pomocno.UcitajCijeliBroj("Unesite broj lozinki");
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
                string odgovor = Pomocno.UcitajString(poruka + " (da/ne)").ToLower();
                if (odgovor == "da") return true;
                if (odgovor == "ne") return false;
                Console.WriteLine("Nepravilan unos. Molimo odgovorite s 'da' ili 'ne'.");
            }
        }

        static bool ProvjeriPonavljanje(char[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                for (int j = i + 1; j < niz.Length; j++)
                {
                    if (niz[i] == niz[j])
                    {
                        return true;
                    }
                }
            }

            return false; 
}

        public static StringBuilder GenerirajLozinku(
            int DuzinaLozinke,
            bool velikaSlova,
            bool malaSlova,
            bool brojevi,
            bool interpunkcija,
            bool pocinjeBrojem,
            bool pocinjeInterpunkcijom,
            bool zavrsavaBrojem,
            bool zavrsavaInterpunkcijom,
            bool ponavljajuciZnakovi)
        {
            StringBuilder nizVelikihSlova = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            StringBuilder nizMalihSlova = new StringBuilder("abcdefghijklmnopqrstuvwxyz");
            StringBuilder nizBrojeva = new StringBuilder("0123456789");
            StringBuilder nizInterpunkcijskihZnakova = new StringBuilder("!@#$%^&*()_-+=<>?");
            StringBuilder dozvoljeniZnakovi = new StringBuilder();

            if (velikaSlova) dozvoljeniZnakovi.Append(nizVelikihSlova);
            if (malaSlova) dozvoljeniZnakovi.Append(nizMalihSlova);
            if (brojevi) dozvoljeniZnakovi.Append(nizBrojeva);
            if (interpunkcija) dozvoljeniZnakovi.Append(nizInterpunkcijskihZnakova);

            if (dozvoljeniZnakovi.Length == 0)
            {
                throw new ArgumentException("Morate odabrati barem jedan skup znakova za lozinku");
            }

            char[] lozinka = new char[DuzinaLozinke];
            var random = new Random();

            int brojPokusaja = 0;
            int maksimalanBrojPokusaja = 1000;

            while (brojPokusaja < maksimalanBrojPokusaja)
            {
                brojPokusaja++;

                if (pocinjeBrojem && brojevi)
                {
                    lozinka[0] = nizBrojeva[random.Next(nizBrojeva.Length)];
                }
                else if (pocinjeInterpunkcijom && interpunkcija)
                {
                    lozinka[0] = nizInterpunkcijskihZnakova[random.Next(nizInterpunkcijskihZnakova.Length)];
                }
                else
                {
                    lozinka[0] = dozvoljeniZnakovi[random.Next(dozvoljeniZnakovi.Length)];
                }

                if (zavrsavaBrojem && brojevi)
                {
                    lozinka[DuzinaLozinke - 1] = nizBrojeva[random.Next(nizBrojeva.Length)];
                }
                else if (zavrsavaInterpunkcijom && interpunkcija)
                {
                    lozinka[DuzinaLozinke - 1] = nizInterpunkcijskihZnakova[random.Next(nizInterpunkcijskihZnakova.Length)];
                }
                else
                {
                    lozinka[DuzinaLozinke - 1] = dozvoljeniZnakovi[random.Next(dozvoljeniZnakovi.Length)];
                }

                for (int i = 1; i < DuzinaLozinke - 1; i++)
                {
                    lozinka[i] = dozvoljeniZnakovi[random.Next(dozvoljeniZnakovi.Length)];
                }

                if (ponavljajuciZnakovi || !ProvjeriPonavljanje(lozinka))
                {
                    return new StringBuilder(new string(lozinka));
                }
            }

            throw new Exception("Nije moguce generirati lozinku sa zadanim uvjetima");
        }


    }
}
