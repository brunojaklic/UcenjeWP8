using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak2
    {
        public static void Izvedi()
        {

            decimal pb = Pomocno.UcitajDecimalniBroj("Unesi duzinu");
            decimal db = Pomocno.UcitajDecimalniBroj("Unesi sirinu");
            Console.WriteLine("{0} * {1} = {2}", pb, db, pb * db);

        }

    }
}
