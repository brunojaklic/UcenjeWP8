﻿
using System.Security.Cryptography.X509Certificates;

namespace Ucenje.E14KlasaObjekt
{
    internal class Program
    {



        // 5. vrsta metode je konstruktor
        // naziv mora biti jednak nazivu klase
        public Program()
        {
            Console.WriteLine("Klasa/objekt");
            // objekt je pojavnost (instanca) klase -> ovo naučiti napamet


            // Osoba (primjetiti veliko slovo O) je klasa
            // osoba (primjetiti malo slovo o) je objekt, (instanca, varijabla)
            Osoba osoba = new Osoba(); // pozvali smo konstruktor od klase Osoba (new)

            // postavljanje vrijednosti za svojstva objekta
            osoba.Sifra = 1; // pozvao se setter (učahurivanje)
            //osoba.Ime = "Pero"; namjerno ime ostavljamo null jer ono može biti null (? smo stavili)
            osoba.Prezime = "Perić";
            osoba.DatumRodenja = new DateTime(1980, 12, 7);

            // ponoviti ću s uzimanjem vrijednosti od naših korisnika
            //osoba.Sifra = Pomocno.UcitajCijeliBroj("Unesi šifru osobe"); // usporediti s linijom 20
            //osoba.Prezime = Pomocno.UcitajString("Unesi prezime osobe");
            //osoba.DatumRodenja = new DateTime(
            //    Pomocno.UcitajCijeliBroj("Unesi godinu rođenja"),
            //    Pomocno.UcitajCijeliBroj("Unesi mjesec rođenja"),
            //    Pomocno.UcitajCijeliBroj("Unesi dan rođenja")
            //    );

            // korištenje vrijednosti svojstava
            Console.WriteLine(osoba.Prezime); // pozvao si getter (učahurivanje)

            Console.WriteLine(osoba.Ime); // ispiše ""
            Console.WriteLine(osoba.Ime ?? "nije postavljeno"); // ime može biti null, stoga upitnik znači što će biti ako je null. Konkretno, ako je ime null ispiši nije postavljeno. 

            // ne statična metoda se zove s objekta
            osoba.IspisiImeIPrezime();

            //osoba.Primjer(); // ne možeš pozvati statičnu metodu s objekta

            Osoba.Primjer(); // statičnu metodu pozivamo s klase

            //Osoba.IspisiImeIPrezime(); // na klasi se ne može pozvati ne statična metoda

            Osoba[] osobe = new Osoba[3];

            // skraćeni oblk postavljanja vrijednosti svojstava
            osobe[0] = new Osoba()
            { 
                Ime = "Marija", 
                Prezime = "Kat", 
                Sifra = 2, 
                DatumRodenja = new DateTime(1982, 1, 2) 
            };

            osobe[1] = new() { Ime = "Ante" };

            osobe[2] = osoba;

            foreach(Osoba o in osobe){
                Console.WriteLine(o.Ime);
            }

            // ovdje je mjesto na osobi null
            Console.WriteLine(osoba.Mjesto?.Naziv?? "Nije postavljeno");

            // ovdje na osoba dodjeljujem Mjesto na novu instancu klase mjesto s vrijednošću naziva Osijek
            osoba.Mjesto = new() { 
                Naziv = "Osijek", 
                Zupanija = new Zupanija() { 
                    Naziv = "OBŽ", 
                    Zupan = new() { 
                        Ime = "Nataša" 
                    } 
                } 
            };

            // Ovdje Mjesto nije null i naziv je postavljem
            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");

            osoba.Ime = "Pero";

            osoba.Mjesto.Zupanija = new Zupanija() { Naziv = "OBŽ", Zupan = new() { Ime = "Nataša" } };

            // Koji je smisao OOP-a
            Console.WriteLine(osoba.Mjesto?.Zupanija.Zupan.Ime);

            // ispisati Pero s objekta osoba
            Console.WriteLine(osoba.Ime);

            // ispisati OBŽ s objekta osoba
            Console.WriteLine(osoba.Mjesto?.Zupanija.Naziv);

            // ispisati Osijek

            Console.WriteLine(osoba.Mjesto?.Naziv);

        }

        public static void AutomobilZadatak()
        {

            Automobil automobil = new Automobil();
            automobil.Sifra = 1;
            automobil.Marka = "Mercedes";
            automobil.Automatik = false;
            automobil.DatumProizvodnje = new DateTime(1991, 11, 1);
            automobil.Cijena = 14525.80M;

            Console.WriteLine(automobil.DatumProizvodnje);





        }





}
}
