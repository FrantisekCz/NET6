using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Model
{
    class Person
    {
        // definice vlastností
        public string KrestniJmeno { get; set; }
        public string Prijmeni { get; set; }

        public DateTime DatumNarozeni { get; set; }


        public int VratVek()
        {
            TimeSpan dRozdil = DateTime.Now - DatumNarozeni;
            return (int)(dRozdil.TotalDays / 365.25);
        }


    }
}
