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

            var p1 = new Point2D( 2, 4);
            Console.WriteLine(p1.ToString());
            
            var p2 = new Point2D( 3, 7);
            Console.WriteLine(p2.ToString());

            var pSoucet = Point2D.VratPointSoucetBodu(p1, p2);
            Console.WriteLine(pSoucet.ToString());

        }





    } // class

}
