namespace Ucenje
{
    internal class E11Z01
    {

        // Za učitani cijeli broj, program ispisuje da li je paran ili ne


        public static void Izvedi()
        {

            int b;
            string unosniNizZnakova;
            for (; ; )
            {
                Console.Write("Unesi broj: ");
                unosniNizZnakova = Console.ReadLine().Trim();

                if (unosniNizZnakova.Length > 9)
                {
                    Console.WriteLine("Unijeli ste predugačak niz znakova");
                    continue;
                }

                try
                {
                    b = int.Parse(unosniNizZnakova);
                    if (b > 10000)
                    {
                        Console.WriteLine("Uneseni broj je preveliki, unesite manji broj");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
            }

            if (b % 2 == 0)
            {
                Console.WriteLine("Broj je paran");
            }
            else
            {
                Console.WriteLine("Broj je neparan");
            }
        }

    }
}