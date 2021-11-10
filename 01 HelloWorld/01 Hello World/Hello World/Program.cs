﻿using Hello_World.Data;
using Hello_World.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hello_World
{


    class Program
    {
        static void Main(string[] args)
        {

            int[] aCisla = { 1, 2, -30, 4, 20, 256, -45, 99 };

            // where - filtruje v kolekci a vytváří novou kolekci
            //- AND pomocí &&
            // var eVycet = aCisla.Where(iCislo => ( (iCislo >= 0) && (iCislo <= 100)));
            //- AND více podmínek, následný filtr; následné opakované volání
            /*
            var eVycet = aCisla
                            .Where(iCislo => (iCislo >= 0))
                            .Where(iCislo => (iCislo <= 100));
            */

            // ŘAZENÍ
            //             var eVycet = aCisla.OrderBy( i => i );   // radit podle cisla


            // take - vezmi prvních X
            //            var eVycet = aCisla.Take(5);

            // skip - přeskoč prvních X a pak pokračuj
            //            var eVycet = aCisla.Skip(5);

            // skipwhile - přeskakuj, dokud není splněna podmínka
            //            var eVycet = aCisla.SkipWhile( i => i > 0 );  // vrací od -30 dál

            // takewhile - pouzij, dokud je splněna podmínka
            //            var eVycet = aCisla.TakeWhile(i => i > 0);  // vrací vše před -30
            /*
                        foreach (var hodnota in eVycet)
                        {
                            Console.WriteLine(hodnota);
                        }
            */


            // AGREGACE; max, min, sum, average
            var iSuma = aCisla.Sum();
            Console.WriteLine($"Suma: {iSuma}");

            var iMax = aCisla.Max();
            Console.WriteLine($"Max: {iMax}");

            var dPrumer = aCisla.Average();
            Console.WriteLine($"Avg: {dPrumer}");



            // JEDEN PRVEK Z KOLEKCE
            var iPrvni = aCisla.First();
            Console.WriteLine($"První: {iPrvni}");
            var iPosledni = aCisla.Last();
            Console.WriteLine($"Poslední: {iPosledni}");



        }



        public static void Day03() {
            /*
            var p1 = new Point2D( 2, 4);
            Console.WriteLine($"Definice bodu A: {p1}"); ; ;

            var p2 = new Point2D( 3, 7);
            Console.WriteLine($"Definice bodu B: {p2}"); ; ;

            var pSoucetStaticky = PointMath.VratPointSoucetBodu(p1, p2);
            Console.WriteLine($"Statický součet bodů: {pSoucetStaticky}");

            var pSoucetInstancni = p1.VratNovyBodPrictenim(p2);
            Console.WriteLine($"instanční součet bodů: {pSoucetInstancni}");

            var pSoucetMulti = p1.VratNovyBodPrictenim(p1).VratNovyBodPrictenim(p2);
            Console.WriteLine($"Multi součet bodů (A-A-B): {pSoucetMulti}");

            p1.PrictiBod(p2);
            Console.WriteLine($"Modifikace prvního bodu: {p1}");
            */


            Console.WriteLine(DateOperations.VratNazevDneDleCislaSwitch(3));
            Console.WriteLine(DateOperations.VratNazevDneDleCislaIfElse(3));
            Console.WriteLine(DateOperations.VratNazevDneDleCislaArray(3));
            Console.WriteLine(DateOperations.VratNazevDneDleCislaList(3));

            Console.WriteLine(DateOperations.VratCisloDneDleNazvuSwitch("ČtvrtEk"));

            Console.WriteLine( $"Pomocí List: {DateOperations.VratCisloDneDleNazvuList("ČtvrtEk")}");


            }



} // class

}
