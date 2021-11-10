using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Data
{
    class Point2D
    {
        public int iBodX { get; }
        public int iBodY { get; }

        public Point2D( int bodX, int bodY)
        {
            this.iBodX = bodX;
            this.iBodY = bodY;
        }

       
        int VratPlochu()
        {
            return (Math.Abs(iBodX) * Math.Abs(iBodY));
        }


        public override string ToString()
        {
            return $"Body [{this.iBodX},{this.iBodY}], obsah je {this.VratPlochu()}.";
        }


        public static Point2D VratPointSoucetBodu( Point2D Bod1, Point2D Bod2)
        {
            int OsaX = Bod1.iBodX + Bod2.iBodX;
            int OsaY = Bod1.iBodY + Bod2.iBodY;
            return new Point2D(OsaX, OsaY);
        }

    }
}
