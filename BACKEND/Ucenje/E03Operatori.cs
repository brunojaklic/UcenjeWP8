namespace Ucenje
{
    internal class E03Operatori
    {

        // u Program.cs dodati E03Operatori.Izvedi();
        public static void Izvedi()
        {
            // početak
            Console.WriteLine("E03Operatori");

            // = dodjelivanje vrijednosti s desne na lijevu sranu

            // + kao operator nadoljepljivanja (concate)

            string grad = "Osijek";
            string ime = "Edunova";


            Console.WriteLine(grad + " " + ime + " " + 5); // ovo nije najbolja praksa

            Console.WriteLine("{0} {1} {2}", grad, ime, 5); // odraduje isti posao kao gornja ali brze

            // operator modulo % -> parnost broja

            Console.WriteLine(8%2);

            int b = 9 % 2;

            Console.WriteLine(b);


            // uvećanje broja za 1

            int i = 0;

            //uvećaj za 1

            i = i + 1;
            
            i += 1;
            
            i++;

            ++i;

            // increment i decrement (+ii, i++, --i, i--);

            int k = 1, j = 0;

            k = ++k - j++; //2 - 0, j = 1

            Console.WriteLine(--k+j++); // što se ispisuje 1 + 1 = 2



            //kraj
        }
    }
}
