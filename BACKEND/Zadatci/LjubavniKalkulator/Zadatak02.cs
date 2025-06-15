
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

            char[] imena = new char[prvaOsoba.Length + drugaOsoba.Length];

            for(int i = 0; i < prvaOsoba.Length; i++)
            {
                imena[i] = prvaOsoba[i];
            }

            for(int i = 0; i < drugaOsoba.Length; i++)
            {
                imena[prvaOsoba.Length + i] = drugaOsoba[i];
            }

            int[] brojac = new int[imena.Length];

            for(int i = 0; i < imena.Length; i++)
            {
                int lokalniBrojac = 0;
                for (int j = 0; j < imena.Length; j++)
                {
                    if (imena[j] == imena[i])
                    {
                        lokalniBrojac++;
                    }
                }
                brojac[i] = lokalniBrojac;
            }

            string spojeniString = "";

            for (int i = 0; i < brojac.Length; i++)
            {
                spojeniString = spojeniString + brojac[i].ToString();
            }

            Console.WriteLine(spojeniString);

        }
    }
}
