using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaDigitalnihMedija
{
    public static class KolekcijaExtensions
    {

        public static int BrojMedija<T>(this Kolekcija<T> kolekcija)
        {
            return kolekcija.DohvatiSve().Count();
        }


    }
}
