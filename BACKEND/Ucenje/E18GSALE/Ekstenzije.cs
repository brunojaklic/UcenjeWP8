using System.Runtime.CompilerServices;

namespace Ucenje.E18GSALE
{
    // Ekstenzije su metode koje možemo nakačitina bilo koji tip podatka za koji je ekstenzija napisana
    public static class Ekstenzije
    {

        public static void EdunovaProvjera(this string s)
        {
            Console.WriteLine(s.Substring(2,4));
        }

        public static int Broj(this IObrada obrada)
        {
            string s = obrada.Metoda();
            return s.Length;
        }

    }
}
