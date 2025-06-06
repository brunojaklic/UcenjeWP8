using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E05UvjetoGrananjeSwitch
    {
        public static void Izvedi()
        {
            Console.WriteLine("E05UvjetoGrananjeSwitch");

            // switch radi s tipovima podataka: int, string, char i svi ostali
            Console.WriteLine("Unesi ocjenu brojem: ");
            int broj = int.Parse(Console.ReadLine());


            switch (broj)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odlican");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Pa i tobi mogle biti ocjene ali nisu");
                    break;
                default:
                    Console.WriteLine("Nije ocjena");
                    break;
            }
        }
    }
}
