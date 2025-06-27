namespace BibliotekaDigitalnihMedija
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kolekcija<DigitalniMedij> mojaKolekcija = new Kolekcija<DigitalniMedij>();
            
            Knjiga knjiga1 = new Knjiga
            {
                Naziv = "Programiranje u C#",
                Autor = "Ivan Horvat",
                Zanr = "Fansastika"
            };

            Film film1 = new Film
            {
                Naziv = "Matrix",
                Redatelj = "Wachowski",
                Jezik = "Hrvatski"
            };

            Glazba glazba1 = new Glazba
            {
                Naziv = "Bohemian Rhapsody",
                Izvodac = "Queen",
                Album = "A Night at the Opera"
            };

            mojaKolekcija.Dodaj(knjiga1);
            mojaKolekcija.Dodaj(film1);
            mojaKolekcija.Dodaj(glazba1);

            mojaKolekcija.PrikaziSve();
            Console.WriteLine(mojaKolekcija.BrojMedija());




        }
    }
}
