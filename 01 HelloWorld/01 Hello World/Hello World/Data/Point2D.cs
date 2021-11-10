using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Data
{
    class Point2D
    {
        int iBodX;
        int iBodY;

        public Point2D( int bodX, int bodY)
        {
            this.iBodX = bodX;
            this.iBodY = bodY;
        }


        

        public override string ToString()
        {
            return $"Obsah čtyřúhelníku je { (Math.Abs(iBodX) * Math.Abs(iBodY))}.";
        }

    }
}
