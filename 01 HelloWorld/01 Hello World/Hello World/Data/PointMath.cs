using Hello_World.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Data
{
    class PointMath
    {
        public static Point2D VratPointSoucetBodu(Point2D Bod1, Point2D Bod2)
        {
            int OsaX = Bod1.iBodX + Bod2.iBodX;
            int OsaY = Bod1.iBodY + Bod2.iBodY;
            return new Point2D(OsaX, OsaY);
        }
    }
}
