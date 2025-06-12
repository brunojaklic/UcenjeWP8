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
            Console.Write("Unesite broj redova: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Unesite broj stupaca: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrica = new int[m, n];

            int broj = 1;
            int x = 0;


            while (broj <= m * n)
            {
                for (int j = n - 1 - x; j >= (0 + x); j--)
                {
                    matrica[m - 1 - x, j] = broj++;
                }

                if(broj > m * n)
                {
                    break;
                }

                for (int i = m - 2 - x; i >= (0 + x); i--)
                {
                    matrica[i, x] = broj++;
                }

                if (broj > m * n)
                {
                    break;
                }

                for (int j = 1 + x; j <= (n - 1 - x); j++)
                {
                    matrica[x, j] = broj++;
                }

                if (broj > m * n)
                {
                    break;
                }

                for (int i = 1 + x; i <= (m - 2 - x); i++)
                {
                    matrica[i, n - 1 - x] = broj++;
                }

                if (broj > m * n)
                {
                    break;
                }

                x++;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t{0}", matrica[i, j]);
                }
                Console.Write("\n");
            }



        }
    }
}
