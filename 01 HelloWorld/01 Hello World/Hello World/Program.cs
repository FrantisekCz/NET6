using System;
using System.IO;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            // PRÁCE S DATEM A ČASEM
            // vytváří se nová instance objektu. Podle počtu parametrů se to chová.
            DateTime dDatum = new DateTime(2021, 11, 8);
            DateTime dtDatumCas = new DateTime(2021, 11, 8, 16, 11, 00);

            //statické metody
            DateTime dtNyni = DateTime.Now;

            // instanční metody
            DateTime dDatumZa14Dni  = dDatum.AddDays(14);
            int iDatumRok           = dDatum.Year;
            string sKratkeDatum     = dDatum.ToShortDateString();

            TimeSpan dtRozdilDateTime = dtNyni - dtDatumCas;

        }

    }
}
