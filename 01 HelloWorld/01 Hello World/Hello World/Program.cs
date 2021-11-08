using System;
using System.IO;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("Jak se jmenuješ?");
            // necháme si předat od uživatele jméno
            string sJmeno = Console.ReadLine();
            Pozdravit(sJmeno);
            */

            // kalkulacka
            /*
            Console.WriteLine("Zadej mi nějaké celé číslo:");
            int iVstup = int.Parse(Console.ReadLine());
            Console.WriteLine("Výsledek příkladu (" + iVstup + " x 2 + 10) je " + Vypocet(iVstup) + ".\n");
            */

            // prevod teplot
            //PrevedTiskniFtoC();


            // CYKLUS WHILE
            /*
            int iCounter = 0;
            while( iCounter < 10)
            {
                Console.WriteLine(iCounter++);
//                iCounter++;
            }
            */

            
            string sVstup = "";
            while(sVstup != "x")
            {
                sVstup = PrevadejFtoCVyjimky();
            }

        }





        static string PrevadejFtoCVyjimky()
        {
            double dbTeplotaF = 0;
            Console.WriteLine("Zadejte teplotu v °F nebo zadejte \"x\" pro ukončení:");
            string sHodnota = Console.ReadLine();

            try
            {
                dbTeplotaF = double.Parse(sHodnota);
                Console.WriteLine($"Teplota {dbTeplotaF}°F odpovídá {PrevodFtoC(dbTeplotaF)}°C.\n");
            }
            catch(Exception exVyjimka)
            {
                //NewLine zajistuje, ze to bude na vsech systemech spravne
                File.AppendAllText( "errorlog.txt", exVyjimka.Message + Environment.NewLine);
            }

            return sHodnota;

        }




        static string PrevadejFtoCneboSkonci()
        {
            double dbTeplotaF = 0;
            Console.WriteLine("Zadejte teplotu v °F nebo zadejte \"x\" pro ukončení:");
            string sHodnota = Console.ReadLine();

            // pokud je x, pak vraci hodnotu a vypadne
            if (sHodnota == "x")
            {
                return sHodnota;
            }
            else
            {
                // toto probehne jen pokud neni "x"
                dbTeplotaF = double.Parse(sHodnota);
                Console.WriteLine($"Teplota {dbTeplotaF}°F odpovídá {PrevodFtoC(dbTeplotaF)}°C.\n");
                return sHodnota;
            }
        }


        /// <summary>
        /// Vypočte a vypíše teplotu v °C z teploty v °F
        /// </summary>
        static void PrevedTiskniFtoC()
        {
            Console.WriteLine("Zadej teplotu ve F°:");
            double dbTeplotaF = double.Parse(Console.ReadLine());
            Console.WriteLine($"Teplota {dbTeplotaF}°F odpovídá {PrevodFtoC(dbTeplotaF)}°C.\n");
        }

        static int Vypocet( int iCisloVstup )
        {
            return (iCisloVstup * 2) + 10;
        }



        static double PrevodFtoC( double dbTeplotaF )
        {
            return (dbTeplotaF - 32) / 1.8;
        }


        static void Pozdravit(string sJmeno)
        {

            // jméno vyskloňujeme
            string sOsloveni = "cizinče jménem " + sJmeno;
            if (sJmeno == "František")
            {
                sOsloveni = "Františku";
            }
            else if (sJmeno == "Jarda")
            {
                sOsloveni = "Jarouši";
            }
            else if (sJmeno == "Pavel")
            {
                sOsloveni = "Pavlíku";
            }
            else sOsloveni = sOsloveni + ", tvoje jméno neumím skloňovat :-(";
            // lze napsat i takto: sOsloveni += pridany_text


            

            // pěkně pozdravíme
            // string sPozdrav = "Ahoj, ty jsi " + sName;
            string sPozdravOsloveni = "Nazdárek " + sOsloveni;
            Console.WriteLine(sPozdravOsloveni);
        }
    }
}
