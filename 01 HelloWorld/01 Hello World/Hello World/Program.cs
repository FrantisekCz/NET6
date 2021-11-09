using Hello_World.Model;
using System;
using System.IO;

namespace Hello_World
{


    class Program
    {
        static void Main(string[] args)
        {
            // StarsiOsoba();



        }


        static void EvidenceAut()
        {
            Auto a1 = new Auto();
            a1.RegistracniZnacka = "ACC 5640";
            a1.Barva = "zelená";
            a1.NajeteKilometry = 123456;
        }


        static void StarsiOsoba()
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

            // výpis starší osoby
            //- 1)
            Console.WriteLine($"Starší je {((osoba1.VratVek() > osoba2.VratVek()) ? osoba1.KrestniJmeno : osoba2.KrestniJmeno)}.");
            //- 2)
            Person Nejstarsi = (osoba1.VratVek() > osoba2.VratVek()) ? osoba1 : osoba2;
            Console.WriteLine($"Starší je {Nejstarsi.KrestniJmeno} {Nejstarsi.Prijmeni}");

        }

    }

}
