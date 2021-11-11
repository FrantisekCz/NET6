using Hello_World.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    class DataAccess
    {
        // objekt, do ktereho si vlozim data a budu je tam udrzovat
        // Pouzivam ObservableCollection, protoze se s tim pak lepe pracuje ve WPF
        public static ObservableCollection<Person> people = new ObservableCollection<Person>();

        public static void LoadPeopleFromDb()
        {
            // pripojeni k DB
            using (var db = new PeopleContext())
            {
                // nelze nacit primo do ObservableCollection, musim to prohnat pres list
                var peoplelist = db.People
                                        .Include(x => x.AdresaDomov)  // zahrne take tuto tabulku
                                        .Include(x => x.OsobniAuta)   // zahrne take tuto tabulku
                                        .ToList();
                // z listu do Obs.Coll.
                people = new ObservableCollection<Person>(peoplelist);
            }
        }


        public static void SavePerson(Person personToSave)
        {
            using (var db = new PeopleContext())
            {
                // nejdriv si nacteme spravny zaznam v DB, resp. v contextu
                var dbperson = db.People.Find(personToSave.Id);

                // nastavim zmenene hodnoty do db contextu
                dbperson.KrestniJmeno = personToSave.KrestniJmeno;
                dbperson.Prijmeni = personToSave.Prijmeni;
                dbperson.DatumNarozeni = personToSave.DatumNarozeni;

                // ulozim zmenu
                db.SaveChanges();


            }
        }


        public static void AddPerson(Person personToSave)
        {
            using (var db = new PeopleContext())
            {
                // nejdriv si nacteme spravny zaznam v DB, resp. v contextu
                var dbperson = db.People.Add(personToSave);

                // ulozim zmenu
                db.SaveChanges();


            }
        }

    }
}
