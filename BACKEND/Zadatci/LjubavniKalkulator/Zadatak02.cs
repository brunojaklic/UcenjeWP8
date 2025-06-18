namespace LjubavniKalkulator
{
    internal class Zadatak02
    {
        public static void Izvedi()
        {
            string PrvaOsobaOriginal = UcitajString("Unesi ime prve osobe");
            string DrugaOsobaOriginal = UcitajString("Unesi ime druge osobe");

            string PrvaOsoba = PrvaOsobaOriginal.ToLower();
            string DrugaOsoba = DrugaOsobaOriginal.ToLower();

            char[] Imena = SpojiZnakove(PrvaOsoba, DrugaOsoba);
            int[] Brojac = IzracunajPonavljanja(Imena);
            char[] SpojeniChar = PretvoriBrojeveUZnakove(Brojac);

            Console.WriteLine("{0}\t{1}", PrvaOsobaOriginal, DrugaOsobaOriginal);

            for (int i = 0; i < (PrvaOsoba.Length + DrugaOsoba.Length); i++)
            {
                if (i == (PrvaOsoba.Length))
                {
                    Console.Write("\t");
                }
                Console.Write("{0}", SpojeniChar[i]);
            }
            Console.WriteLine();

            char[] FinalniChar = LjubavniKalkulator(SpojeniChar);

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
            string Spojeni = string.Join("", brojevi);
            return Spojeni.ToCharArray();
        }

        public static char[] LjubavniKalkulator(char[] SpojeniChar)
        {
            if (SpojeniChar.Length <= 2)
            {
                return SpojeniChar;
            }

            char[] NoviNiz = new char[SpojeniChar.Length * 2];
            int index = 0;

            int i = 0;
            int j = SpojeniChar.Length - 1;

            while (i < j)
            {
                int Zbroj = (SpojeniChar[i] - '0') + (SpojeniChar[j] - '0');

                if (Zbroj >= 10)
                {
                    NoviNiz[index++] = (char)((Zbroj / 10) + '0');
                    NoviNiz[index++] = (char)((Zbroj % 10) + '0');
                }
                else
                {
                    NoviNiz[index++] = (char)(Zbroj + '0');
                }

                i++;
                j--;
            }

            if (i == j)
            {
                NoviNiz[index++] = SpojeniChar[i];
            }

            char[] KonacniNiz = new char[index];

            for (int k = 0; k < index; k++)
            {
                KonacniNiz[k] = NoviNiz[k];
            }

            for (int k = 0; k < KonacniNiz.Length; k++)
            {
                Console.Write(KonacniNiz[k]);
            }
            Console.WriteLine();
            return LjubavniKalkulator(KonacniNiz);
        }
    }
}