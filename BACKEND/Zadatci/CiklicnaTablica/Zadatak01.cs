using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklicnaTablica
{
    internal class Zadatak01
    {

        public static void Izvedi()
        {


            

            int m = UcitajCijeliBroj("Unesite broj redova");
            int n = UcitajCijeliBroj("Unesite broj stupaca");

            


            int[,] Matrica = new int[m, n];

            CiklicnaTablica(Matrica, m, n);

            IspisMatrice(Matrica, m, n);


        }

        public static int UcitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokusajte ponovo");
                }
            }
        }

        public static void CiklicnaTablica(int[,] Matrica, int BrojRedova, int BrojStupaca)
        {

            int Broj = 1;
            int x = 0;


            while (Broj <= BrojRedova * BrojStupaca)
            {
                for (int j = BrojStupaca - 1 - x; j >= x; j--)
                {
                    Matrica[BrojRedova - 1 - x, j] = Broj++;
                }

                if (Broj > BrojRedova * BrojStupaca)
                {
                    break;
                }

                for (int i = BrojRedova - 2 - x; i >= x; i--)
                {
                    Matrica[i, x] = Broj++;
                }

                if (Broj > BrojRedova * BrojStupaca)
                {
                    break;
                }

                for (int j = 1 + x; j <= (BrojStupaca - 1 - x); j++)
                {
                    Matrica[x, j] = Broj++;
                }

                if (Broj > BrojRedova * BrojStupaca)
                {
                    break;
                }

                for (int i = 1 + x; i <= (BrojRedova - 2 - x); i++)
                {
                    Matrica[i, BrojStupaca - 1 - x] = Broj++;
                }

                if (Broj > BrojRedova * BrojStupaca)
                {
                    break;
                }

                x++;
            }


        }

        public static void IspisMatrice(int[,] Matrica, int BrojRedova, int BrojStupaca)
        {

            for (int i = 0; i < BrojRedova; i++)
            {
                for (int j = 0; j < BrojStupaca; j++)
                {
                    Console.Write("\t{0}", Matrica[i, j]);
                }
                Console.Write("\n");
            }

        }
    }
}
