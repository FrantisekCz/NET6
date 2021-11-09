using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Model
{
    class Person
    {
        // konstruktory
        public Person(string sJmeno, string sPrijmeni, string sDatumNarozeni)
        {
            this.KrestniJmeno = sJmeno.Trim();
            this.Prijmeni = sPrijmeni.Trim();
            this.DatumNarozeni = DateTime.Parse(sDatumNarozeni);
            this.AdresaDomov = new Address();
        }

        public Person( string sJmeno, string sPrijmeni)
        {
            this.KrestniJmeno = sJmeno;
            this.Prijmeni = sPrijmeni;
            this.AdresaDomov = new Address();
        }

        public Person()
        {
            this.AdresaDomov = new Address();
        }


        // přetížení standardní metody
        public override string ToString()
        {
            return $"{this.KrestniJmeno} {this.Prijmeni}";
        }


        // definice vlastností
        public string KrestniJmeno { get; set; }
        public string Prijmeni { get; set; }

        public DateTime DatumNarozeni { get; set; }

        public Address AdresaDomov { get; set; } = new Address();
        public List<Auto> OsobniAuta { get; set; } = new List<Auto>();



        // METODY
        public int VratVek()
        {
            TimeSpan dRozdil = DateTime.Now - DatumNarozeni;
            return (int)(dRozdil.TotalDays / 365.25);
        }

    }
}
