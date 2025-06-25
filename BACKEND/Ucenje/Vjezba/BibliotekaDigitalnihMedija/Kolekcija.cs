using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaDigitalnihMedija
{
    public class Kolekcija<T>
    {
        List<T> stavke = new List<T>();

        public void Dodaj(T stavka)
        {
            stavke.Add(stavka);
        }
        
        public void Obrisi(T stavka)
        {
            stavke.Remove(stavka);
        }

        public IEnumerable<T> DohvatiSve()
        {
            return stavke;
        }

        public void PrikaziSve()
        {
            foreach (var item in stavke)
            {
                if (item is DigitalniMedij medij)
                    medij.PrikaziDetalje();
                else
                    Console.WriteLine(item);
            }
        }


    }

}
