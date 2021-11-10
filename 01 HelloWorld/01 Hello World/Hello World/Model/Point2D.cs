using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Model
{
    class Point2D
    {
        public int iBodX { get; }
        public int iBodY { get; }

        public Point2D(int bodX, int bodY)
        {
            this.iBodX = bodX;
            this.iBodY = bodY;
        }


        public int VratPlochu()
        {
            return (Math.Abs(iBodX) * Math.Abs(iBodY));
        }


        public override string ToString()
        {
            return $"Body [{this.iBodX},{this.iBodY}], obsah je {this.VratPlochu()}.";
        }




    }
}
