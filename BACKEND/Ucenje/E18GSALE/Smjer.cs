namespace Ucenje.E18GSALE
{
    // sučelja mogu biti generička IComparable<Smjer>
    public class Smjer : Entitet, IComparable<Smjer>, IObrada
    {
        public string Naziv { get; set; } = "";

        public int CompareTo(Smjer? other)
        {
           if(other == null)
            {
                return 1;
            }
           return Naziv.CompareTo(other.Naziv);
        }

        public string Metoda()
        {
            return "Ana";
        }

        public void OdradiPosao()
        {
            Console.WriteLine("Smjer");
        }

        public override string ToString()
        {
            return Naziv ?? ""; // Ako je naziv null vrati prazno ""
        }
    }
}
