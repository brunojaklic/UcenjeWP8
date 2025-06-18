namespace LjubavniKalkulator
{
    internal class Zadatak02
    {
        public static void Izvedi()
        {
            string PrvaOsoba = UcitajString("Unesi ime prve osobe");
            string DrugaOsoba = UcitajString("Unesi ime druge osobe");

            char[] Imena = SpojiZnakove(PrvaOsoba, DrugaOsoba);
            int[] Brojac = IzracunajPonavljanja(Imena);
            string SpojeniString = PretvoriBrojeveUZnakove(Brojac);

            Console.WriteLine(SpojeniString);
        }

        public static string UcitajString(string Poruka)
        {
            string S;
            for (; ; )
            {
                Console.Write(Poruka + ": ");
                S = Console.ReadLine().Trim();
                if (S.Length > 0)
                {
                    return S;
                }
                Console.WriteLine("Obavezan unos!");
            }
        }

        public static char[] SpojiZnakove(string PrvaOsoba, string DrugaOsoba)
        {
            char[] Imena = new char[PrvaOsoba.Length + DrugaOsoba.Length];

            for (int i = 0; i < PrvaOsoba.Length; i++)
            {
                Imena[i] = PrvaOsoba[i];
            }

            for (int i = 0; i < DrugaOsoba.Length; i++)
            {
                Imena[PrvaOsoba.Length + i] = DrugaOsoba[i];
            }

            return Imena;
        }

        public static int[] IzracunajPonavljanja(char[] Imena)
        {
            int[] Brojac = new int[Imena.Length];

            for (int i = 0; i < Imena.Length; i++)
            {
                int LokalniBrojac = 0;
                for (int j = 0; j < Imena.Length; j++)
                {
                    if (Imena[j] == Imena[i])
                    {
                        LokalniBrojac++;
                    }
                }
                Brojac[i] = LokalniBrojac;
            }

            return Brojac;
        }

        public static string PretvoriBrojeveUZnakove(int[] Brojac)
        {
            string Rezultat = "";

            for (int i = 0; i < Brojac.Length; i++)
            {
                Rezultat += Brojac[i].ToString();
            }

            return Rezultat;
        }
    }
}
