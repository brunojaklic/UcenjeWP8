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
            char[] SpojeniChar = PretvoriBrojeveUZnakove(Brojac);

            string PrazanString = "";

            char[] FinalniChar = LjubavniKalkulator(SpojeniChar);


            Console.WriteLine("{0}\t{1}", PrvaOsoba, DrugaOsoba);
            for (int i = 0; i < (PrvaOsoba.Length + DrugaOsoba.Length); i++)
            {
                if (i == (PrvaOsoba.Length))
                {
                    Console.Write("\t");
                }
                Console.Write("{0}", SpojeniChar[i]);

            }
            Console.WriteLine((int)FinalniChar[0]);


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

        public static char[] PretvoriBrojeveUZnakove(int[] brojevi)
        {
            string spojeni = string.Join("", brojevi);
            return spojeni.ToCharArray();
        }



        public static char[] LjubavniKalkulator(char[] SpojeniChar)
        {

            int Brojac = 0;

            if (SpojeniChar[0] <= 100)
            {
                return SpojeniChar;
            }

            for(int i = 0; i < SpojeniChar.Length; i++)
            {
                SpojeniChar[i] = (char)(SpojeniChar[0 + i] + SpojeniChar[SpojeniChar.Length - 1 - i]);
                Brojac++;
            }

            for(int i = Brojac; i < SpojeniChar.Length; i++)
            {
                SpojeniChar[i] = '0';
            }

            return LjubavniKalkulator(SpojeniChar);
        }

    }
}
