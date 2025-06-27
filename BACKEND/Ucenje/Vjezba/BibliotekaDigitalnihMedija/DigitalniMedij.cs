using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaDigitalnihMedija
{
    public abstract class DigitalniMedij
    {
        public string Naziv { get; set; } = "";
        public DateTime GodinaIzdanja { get; set; }

        public abstract void PrikaziDetalje();

    }


}
