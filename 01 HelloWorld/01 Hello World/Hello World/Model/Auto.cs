using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Model
{
    class Auto
    {
        public string RegistracniZnacka { set;  get; }
        public string Barva { set; get; }
        public double NajeteKilometry { set; get; }

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
