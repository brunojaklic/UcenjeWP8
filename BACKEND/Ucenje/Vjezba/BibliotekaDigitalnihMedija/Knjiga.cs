using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaDigitalnihMedija
{
    public class Knjiga : DigitalniMedij
    {

        public string Autor { get; set; } = "";
        public int BrojStranica { get; set; }
        public string Zanr { get; set; } = "";

        public override void PrikaziDetalje()
        {
            Console.WriteLine("Naziv: {0}, Godina Izdanja: {1}, Autor: {2}, Broj Stranica: {3}, Zanr: {4} ", Naziv, GodinaIzdanja, Autor, BrojStranica, Zanr);
        }
    }
}
