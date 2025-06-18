
namespace Zadatci
{
    public class Knjiga
    {

        public int sifra { get; set; }
        public string naziv { get; set; }
        public string autor { get; set; }
        public int godinaIzdanja { get; set; }
        public bool JeLiNaStanju { get; set; }

        public Knjiga()
        {
        }
        public Knjiga(int sifra, string naziv, string autor, int godinaIzdanja, bool JeLiNaStanju)
        {

            this.sifra = sifra;
            this.naziv = naziv;
            this.autor = autor;
            this.godinaIzdanja = godinaIzdanja;
            this.JeLiNaStanju = JeLiNaStanju;

        }

        public void IspisiDetalje()
        {

            Console.WriteLine("Sifra: {0}", sifra);
            Console.WriteLine("Naziv: {0}", naziv);
            Console.WriteLine("Autor: {0}", autor);
            Console.WriteLine("Godina izdanja: {0}", godinaIzdanja);
            Console.WriteLine("Dostupnost: {0}", JeLiNaStanju);

        }

        
    }


}
