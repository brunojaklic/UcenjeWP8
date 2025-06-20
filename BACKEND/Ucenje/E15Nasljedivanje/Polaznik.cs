using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{

    // Klasa polaznik nasljeđuje sva javna i zaštićena svojstva klase Osoba i svih drugih klasa koje Osoba nasljeđuje
    public class Polaznik : Osoba
    {
        public string Telefon { get; set; } = "";

        // prepisivanje metoda
        // method override
        public override string ToString()
        {
            return base.ToString() + " " + Telefon;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            var p = (Polaznik)obj; // var p = obj as Polaznik

            if (p.Ime.Equals(this.Ime) && p.Prezime.Equals(Prezime) && p.Telefon.Equals(Telefon)) return true;

            return false;
        }


    }
}
