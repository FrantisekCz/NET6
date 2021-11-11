using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Model
{
    public class Auto
    {
        public int Id { get; set; }
        public string RegistracniZnacka { set;  get; }
        public string Barva { set; get; }
        public double NajeteKilometry { set; get; }


        // konstruktory
        public Auto(string sRegistracniZnacka, string sBarva, double dbKilometry)
        {
            this.RegistracniZnacka = sRegistracniZnacka;
            this.Barva = sBarva;
            this.NajeteKilometry = dbKilometry;
        }
        public Auto()
        {
        }


        public override string ToString()
        {
            return $"RZ: {this.RegistracniZnacka}, barva {this.Barva}, najeto {this.NajeteKilometry} km";
        }


        public void PridejNajeteKilometry( double dbKM )
        {
            NajeteKilometry += dbKM;
        }
        public void VynulujNajeteKilometry()
        {
            NajeteKilometry = 0;
        }

    }
}
