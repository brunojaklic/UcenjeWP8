using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsni
{
    public class Grupa
    {


        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public Program Programi { get; set; } = new Program();
        public string Trener { get; set; } = "";



    }
}
