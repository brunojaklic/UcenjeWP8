using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10ForEach
    {

        public static void Izvedi()
        {
            Console.WriteLine("E10ForEach");

            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();

            // ispiši svako slovo grada jedno ispod drugog

            for(int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }

            Console.WriteLine("******************************");

            // u slučajevima kada idemo od početka do kraja (većina puta)
            foreach(char z in grad)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("******************************");

            int[] brojevi = { 1, 23, 3, 2, 2, 4, 5, 12, 31, 23, 14, 215, 15, 15, 1, 23, 123, 213, 123, 123, 21312 };

            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }

        }



    }
}
