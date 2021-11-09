using Hello_World.Model;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Data
{
    class PersonData
    {
        // bez get;set; je to "field"
        // KONSTANTA
        const string personDataFile = "ZapsaniLide.txt";

        // metoda pro ulozeni (pripojeni) jedne osoby do souboru
        public static void SavePerson( Person Osoba )
        {
            string RadekOsoby = $"{Osoba.KrestniJmeno};{Osoba.Prijmeni};{Osoba.DatumNarozeni};{Osoba.AdresaDomov.Mesto};{Osoba.AdresaDomov.Ulice}";
            RadekOsoby += Environment.NewLine;
            File.AppendAllText(personDataFile, RadekOsoby);
        }



        public static void CreateSavePerson(string sJmeno, string sPrijmeni, string sDatumNarozeni, string sUlice, string sMesto )
        {
            var o1 = new Person(sJmeno, sPrijmeni, sDatumNarozeni);
            o1.AdresaDomov.Ulice = sUlice;
            o1.AdresaDomov.Mesto = sMesto;
            SavePerson(o1);
        }


    }
}
