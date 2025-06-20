using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak3
    {

        public static void Izvedi()
        {
            decimal broj = Pomocno.UcitajDecimalniBroj("Unesite broj");
            if(broj == 0)
            {
                Console.WriteLine("Unijeli ste 0");
            }
            else if (broj > 0)
            {
                Console.WriteLine("Broj {0} je pozitivan", broj);
            }
            else
            {
                Console.WriteLine("Broj {0} je negativan", broj);
            }


        }

    }
}
