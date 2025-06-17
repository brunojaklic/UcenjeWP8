using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    internal class Vjezbac
    {
        public int Sifra { get; set; }
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string? Email { get; set; }
        public Kategorija Kategorija { get; set; } = new Kategorija();
        public Program Program { get; set; } = new Program();



    }
}
