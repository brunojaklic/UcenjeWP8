using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WhilePetlja
    {



        public static void Izvedi()
        {
            Console.WriteLine("E08WhilePetlja");

            // while radi s bool tipom podatka

            // beskonacka petlja


            while (true)
            {
                Console.WriteLine("Ispis iz beskonacke petlje nakon čega je break");
                break;
            }

            Console.WriteLine("******************************");

            // u while se mora ući

            int i = 10;
            while (i < 10)
            {
                Console.WriteLine(i++);
            }

            Console.WriteLine("******************************");

            i = 0; // resetiram jedno te istu varijablu
            while (i < 10)
            {
                Console.WriteLine(++i);
            }

            Console.WriteLine("******************************");

            i = 0;
            int j = 1;
            while(i < 10 && j == 1) // može ići i || te !
            {
                Console.WriteLine(i);
            }

            // continue i break rade isto kao i u for
            // gnježđenje je isto kao u for, može se kombinirati for i while


            Console.WriteLine("******************************");

            while (i > 10)
            {
                while (j == 1)
                {
                    // kako prekinuti petlju while (i > 10)?
                    goto labela;
                }
            }

        labela:
            Console.WriteLine("Gotov");

        }



    }
}
