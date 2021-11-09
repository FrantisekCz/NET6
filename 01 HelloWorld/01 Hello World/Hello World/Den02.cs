using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
