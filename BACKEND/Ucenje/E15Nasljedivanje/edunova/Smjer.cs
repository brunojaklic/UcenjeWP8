

namespace Ucenje.E15Nasljedivanje.edunova
{
    public class Smjer : Entitet
    {

        public string Naziv { get; set; } = "";
        public decimal? Cijena { get; set; }
        public DateTime? DatumPokretanja { get; set; }
        public bool Aktivan { get; set; }

    }
}
