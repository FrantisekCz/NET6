using Hello_World.Data;
using Hello_World.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Hello_World
{


    class Program
    {
        static void Main(string[] args)
        {

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
