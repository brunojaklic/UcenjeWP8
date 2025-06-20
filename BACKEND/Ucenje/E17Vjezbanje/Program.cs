using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    
    public class Program
    {

        public Program()
        {
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("\n*************************");
            Console.WriteLine("******** Izbornik *******");
            Console.WriteLine("0. Izlaz");
            Console.WriteLine("1. Zbrajanje dvaju brojeva");
            Console.WriteLine("2. Racunanje povrsine");
            Console.WriteLine("3. Provjera je li broj pozitivan ili negativan");
            Console.WriteLine("*************************");
            Console.WriteLine("*************************");
            OcitajOdabir();
        }

        private void OcitajOdabir()
        {
            int odabir = Pomocno.UcitajCijeliBroj("Unesi redni broj programa");
            switch (odabir)
            {
                case 0:
                    Console.WriteLine("Dovidenja!");
                    break;
                case 1:
                    Zadatak1.Izvedi();
                    //Console.WriteLine("1. zadatak");
                    break;
                case 2:
                    Zadatak2.Izvedi();
                    break;
                case 3:
                    Zadatak3.Izvedi();
                    break;
                default:
                    Console.WriteLine("Ne postoji taj program");
                    break;
            }

            if (odabir != 0)
            {
                Izbornik();
            }

            /*
            switch(Pomocno.UcitajCijeliBroj("Unesi redni broj programa"))
            {
                case 0:
                    Console.WriteLine("Dovidenja!");
                    break;
                case 1:
                    // kreiranje instance klase Zadatak1
                    Console.WriteLine("1. zadatak");
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Ne postoji taj program");
                    Izbornik();
                    break;
            }*/
        }
    }
}
