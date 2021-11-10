using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Model
{
    class Point2D
    {
        public int iBodX { get; set; }
        public int iBodY { get; set; }

        public Point2D(int bodX, int bodY)
        {
            this.iBodX = bodX;
            this.iBodY = bodY;
        }


        public int VratPlochuOdNuly()
        {
            return (Math.Abs(iBodX) * Math.Abs(iBodY));
        }


        /// <summary>
        /// Přičte vstupní bod k aktuálnímu bodu a výsledek vrací jako nový bod. Aktuální bod nemění.
        /// </summary>
        /// <param name="druhyBod"></param>
        /// <returns></returns>
        public Point2D VratNovyBodPrictenim( Point2D druhyBod )
        {
            return new Point2D( this.iBodX + druhyBod.iBodX, this.iBodY + druhyBod.iBodY );
        }


        /// <summary>
        /// Modifikuje aktuální bod, přičítá jeho souřadnice
        /// </summary>
        /// <param name="druhyBod"></param>
        public void PrictiBod( Point2D druhyBod )
        {
            this.iBodX += druhyBod.iBodX;
            this.iBodY += druhyBod.iBodY;
        }


        public override string ToString()
        {
            return $"Souřadnice [{this.iBodX},{this.iBodY}], obsah je {this.VratPlochuOdNuly()}.";
        }


    }
}
