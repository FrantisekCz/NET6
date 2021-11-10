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
        public static Point2D VratPointSoucetBodu(Point2D bod1, Point2D bod2)
        {
            int OsaX = bod1.iBodX + bod2.iBodX;
            int OsaY = bod1.iBodY + bod2.iBodY;
            return new Point2D(OsaX, OsaY);
        }
    }
}
