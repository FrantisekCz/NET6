using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Jak se jmenuješ?");
            // necháme si předat od uživatele jméno
            string sName = Console.ReadLine();

            // jméno vyskloňujeme
            string sOsloveni = "cizinče jménem " + sName;
            if (sName == "František")
            {
                sOsloveni = "Františku";
            }
            else if (sName == "Jarda")
            {
                sOsloveni = "Jarouši";
            }
            else if (sName == "Pavel")
            {
                sOsloveni = "Pavlíku";
            }
            else sOsloveni =sOsloveni + ", tvoje jméno neumím skloňovat :-(";
            // lze napsat i takto: sOsloveni += pridany_text
           
            // pěkně pozdravíme
            // string sPozdrav = "Ahoj, ty jsi " + sName;
            string sPozdravOsloveni = "Nazdárek " + sOsloveni;
            Console.WriteLine(sPozdravOsloveni);
        }
    }
}
