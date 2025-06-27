using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaDigitalnihMedija
{
    public class Glazba : DigitalniMedij
    {

        public string Izvodac { get; set; } = "";
        public string Album { get; set; } = "";
        public int BrojPjesama { get; set; }

        public override void PrikaziDetalje()
        {
            Console.WriteLine("Naziv: {0}, Godina Izdanja: {1}, Izvodac: {2}, Album: {3}, BrojPjesama: {4} ", Naziv, GodinaIzdanja, Izvodac, Album, BrojPjesama);
        }


    }
}
