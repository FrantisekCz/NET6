using Hello_World.Data;
using Hello_World.Model;
using System;
using System.IO;

namespace Hello_World
{


    class Program
    {
        /// <summary>
        /// MAIN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
            var p1 = new Person("Martin", "Slonisko", "15.8.1983");
            p1.AdresaDomov.Mesto = "Hranice";
            p1.AdresaDomov.Ulice = "Horní 1235";
            PersonData.SavePerson(p1);
            */

            PersonData.CreateSavePerson("Alžběta", "První", "1.1.2001", "Horní 25", "Pardubice");
            PersonData.CreateSavePerson("Bartoloměj", "Soukal", "2.2.2002", "Dolní 25", "Brno");
            PersonData.CreateSavePerson("Cilka", "Hrubá", "3.4.2003", "Zadní 48", "Zlín");
            PersonData.CreateSavePerson("Dalibor", "Smutný", "5.7.2004", "Přední 54/1", "Choceň");
            PersonData.CreateSavePerson("Emil", "Zátopek", "15.9.2005", "Konečná 4074", "Hradec Králové");
            PersonData.CreateSavePerson("Filip", "Konečný", "1.11.2006", "Slepá 26", "Aš");
            PersonData.CreateSavePerson("Gustav", "Brom", "1.4.2007", "Hraniční 485", "Liberec");
            PersonData.CreateSavePerson("Hana", "Hýsková", "1.6.2008", "Ochozy 2415", "Třebíč");
            PersonData.CreateSavePerson("Iva", "Polední", "1.2.2009", "Křivá 252", "Holice");
            PersonData.CreateSavePerson("Jitka", "Pravá", "1.12.2010", "Rovná 12", "Mnichovice");
            



            /*
            // AUTO
            Auto a1 = new Auto("ABC 1234", "žlutá", 1234.5);
            Console.WriteLine(a1.ToString());
            */
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

    } // class

}
