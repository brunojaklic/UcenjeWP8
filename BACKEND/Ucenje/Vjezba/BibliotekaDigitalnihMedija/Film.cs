using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaDigitalnihMedija
{
    public class Film : DigitalniMedij
    {

        public string Redatelj { get; set; } = "";
        public string ZemljaPorijekla { get; set; } = "";
        public string Jezik { get; set; } = "";

        public override void PrikaziDetalje()
        {
            Console.WriteLine("Naziv: {0}, Godina Izdanja: {1}, Redatelj: {2}, Zemlja Porijekla: {3}, Jezik: {4} ", Naziv, GodinaIzdanja, Redatelj, ZemljaPorijekla, Jezik);
        }
    }
}
