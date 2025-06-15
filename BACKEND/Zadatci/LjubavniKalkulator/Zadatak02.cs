
namespace LjubavniKalkulator
{
    internal class Zadatak02
    {



        public static void Izvedi()
        {

            string prvaOsoba;
            string drugaOsoba;


            Console.Write("Unesi ime prve osobe: ");
            prvaOsoba = Console.ReadLine();

            Console.Write("Unesi ime druge osobe: ");
            drugaOsoba = Console.ReadLine();

            char[] imena = new char[prvaOsoba.Length + drugaOsoba.Length + 1];

            for(int i = 0; i < prvaOsoba.Length; i++)
            {
                imena[i] = prvaOsoba[i];
            }

            imena[prvaOsoba.Length] ='/';

            for(int i = prvaOsoba.Length + 1; i < imena.Length; i++)
            {
                imena[i] = drugaOsoba[i - prvaOsoba.Length];
            }


            

            Console.WriteLine(imena);











        }
    }
}
