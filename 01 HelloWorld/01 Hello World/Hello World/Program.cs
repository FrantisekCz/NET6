﻿using System;

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
            Console.WriteLine("Zadej mi nějaké celé číslo:");
            int iVstup = int.Parse( Console.ReadLine() );
            Console.WriteLine( "Výsledek příkladu (" + iVstup + " x 2 + 10) je " + Vypocet(iVstup));


//            Console.WriteLine(PrevodFtoC(100));

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
