using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello_World.Model;
using Hello_World.Data;

namespace Hello_World
{
    class Den02
    {

        static void Den02Main(string[] args)
        {
            // vypocet veku dle data narozeni
            /*
            Console.WriteLine("Zadejte datum narození:");
            DateTime dtDatumNarozeni = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Váš věk je: {VratVek(dtDatumNarozeni)}.");
            */



            // ziskani dvou cisel a vypis toho vetsiho
            //            Console.WriteLine("Zadejte dvě celá čísla:");



            // vypis nejstarsiho
            VypisNejstarsihoZeSouboruJmena();
            /*
            var p1 = new Person("Martin", "Slonisko", "15.8.1983");
            p1.AdresaDomov.Mesto = "Hranice";
            p1.AdresaDomov.Ulice = "Horní 1235";
            PersonData.SavePerson(p1);
            */

            /*
            // ZAPSAT 10 LIDI
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
            */


            var seznamLidi = PersonData.LoadPeople();
            Console.WriteLine($"Počet načtených lidí: {seznamLidi.Count}");


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
        static int VratVek(DateTime dtDatumNarozeni)
        {
            TimeSpan dRozdil = DateTime.Now - dtDatumNarozeni;
            return (int)(dRozdil.TotalDays / 365.25);
        }



        static int VratVetsiCislo(int iPrvniCislo, int iDruheCislo)
        {
            // pomoci metody Math.Max()
            //            return Math.Max(iPrvniCislo, iDruheCislo);

            // ternarni operator
            return (iPrvniCislo > iDruheCislo) ? iPrvniCislo : iDruheCislo;
        }



        // verze 1 - case sensitive
        static bool VratJestliOva(string sPrijmeni)
        {
            return (sPrijmeni.EndsWith("ová"));
        }

        // verze 2 - case insensitive
        static bool VratJestliOva(string sPrijmeni, bool bIgnoreCase)
        {
            return (sPrijmeni.EndsWith("ová", StringComparison.OrdinalIgnoreCase));
        }



        static void VypisNejstarsihoZeSouboruJmena()
        {

            string sJmeno;
            string sVek;
            int iVek;
            int iNejvyssiVek = 0;
            string sNejvyssiJmeno = "";

            foreach (var sRadek in File.ReadLines("jmena.txt"))
            {
                // rozsekneme radek do jednotlivych hodnot
                string[] psCastiRadku = sRadek.Split(';');
                sJmeno = psCastiRadku[0];
                sVek = psCastiRadku[1];
                // prevedeme si vek na cislo
                iVek = int.Parse(sVek);
                // porovname s ulozenou hodnotou, pripadne ulozim
                if (iVek > iNejvyssiVek)
                {
                    iNejvyssiVek = iVek;
                    sNejvyssiJmeno = sJmeno;
                }
            }

            Console.WriteLine($"Mejstarší je {sNejvyssiJmeno}, věk je {iNejvyssiVek}.");
        }

    }
}
