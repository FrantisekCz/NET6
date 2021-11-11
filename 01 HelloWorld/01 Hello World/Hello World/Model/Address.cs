using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Model
{
    public class Address
    {
        public Address(string sMesto, string sUlice)
        {
            this.Ulice = sUlice.Trim();
            this.Mesto = sMesto.Trim();
        }
        public Address()
        {
        }

        public override string ToString()
        {
            return $"{this.Ulice}, {this.Mesto}";
        }
        public int Id { get; set; }

        public string Ulice { get; set; }
        public string Mesto { get; set; }
    }
}
