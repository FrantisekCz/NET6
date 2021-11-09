using Hello_World.Model;
using System;
using System.IO;

namespace Hello_World
{


    class Program
    {
        static void Main(string[] args)
        {

            Auto a1 = new Auto("ABC 1234", "žlutá", 1234.5);
            Console.WriteLine(a1.ToString());

        }


        static void EvidenceAut()
        {
            Auto a1 = new Auto();
            a1.RegistracniZnacka = "ACC 5640";
            a1.Barva = "zelená";
            a1.NajeteKilometry = 123456;
        }


        static void Fakturace()
        {
            Invoice f1 = new Invoice();
            f1.Zakaznik = "Pekárna Šáteček";
            f1.Predmet = "houstičky řádně vypečené";
            f1.Castka = 123.40;
        }


        static void Osoby()
        {
            Person osoba1 = new Person();
            osoba1.KrestniJmeno = "Jana";
            osoba1.Prijmeni = "Nováková";
            osoba1.DatumNarozeni = new DateTime(2008, 12, 13);
            int iVekOsoba1 = osoba1.VratVek();

            Person osoba2 = new Person();
            osoba2.KrestniJmeno = "Ervín";
            osoba2.Prijmeni = "Kopýtko";
            osoba2.DatumNarozeni = new DateTime(2002, 3, 28);
            int iVekOsoba2 = osoba2.VratVek();

            Person osoba3 = new Person("Soňa", "Hvězdná");
            osoba3.DatumNarozeni = new DateTime(1995, 2, 17);

            Person osoba4 = new Person("Petr", "Vomáčka", "2011-08-16");


            // výpis starší osoby
            //- 1)
            Console.WriteLine($"Starší je {((osoba1.VratVek() > osoba2.VratVek()) ? osoba1.KrestniJmeno : osoba2.KrestniJmeno)}.");
            //- 2)
            Person Nejstarsi = (osoba1.VratVek() > osoba2.VratVek()) ? osoba1 : osoba2;
            Console.WriteLine($"Starší je {Nejstarsi.KrestniJmeno} {Nejstarsi.Prijmeni}");

        }

    }

}
