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



        // nacteni seznamu osob - KOLEKCE
        public static List<Person> LoadPeople()
        {
            // seznam lidi; seznam polozek typu Person
            var seznamLidi = new List<Person>();
            // data ze souboru; pole stringu
            var radkySouboru = File.ReadAllLines(personDataFile);
            // prochazim pole s nactenymi texty
            foreach( var jedenRadek in radkySouboru )
            {
                // rozparsuji si radek do pole
                var dataRadku = jedenRadek.Split(';');
                // pripravim si objekt Person
                var osoba = new Person();
                osoba.KrestniJmeno      = dataRadku[0];
                osoba.Prijmeni          = dataRadku[1];
                osoba.DatumNarozeni     = DateTime.Parse( dataRadku[2] );
                osoba.AdresaDomov.Mesto = dataRadku[3];
                osoba.AdresaDomov.Ulice = dataRadku[4];
                // ulozim osobu do seznamu; Add je vestavena metoda
                seznamLidi.Add(osoba);
            }

            return seznamLidi;
        }
        


    }
}
