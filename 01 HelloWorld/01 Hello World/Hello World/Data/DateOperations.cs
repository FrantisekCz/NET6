using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Data
{
    class DateOperations
    {

        public static string VratNazevDneDleCislaSwitch( int iCisloDne )
        {
            switch (iCisloDne)
            {
                case 1:
                    return "Pondělí";
                    // break; nedávám dávat, protože return samo o sobě ukončuje
                case 2:
                    return "Úterý";
                case 3:
                    return "Středa";
                case 4:
                    return "Čtvrtek";
                case 5:
                    return "Pátek";
                case 6:
                    return "Sobota";
                case 7:
                    return "Neděle";
                default:
                    return "Je potřeba zadat hodnotu 1-7";
            }

        }



        public static string VratNazevDneDleCislaIfElse(int iCisloDne)
        {
            if (iCisloDne == 1)
            {
                return "Pondělí";
            }
            else if (iCisloDne == 2)
            {
                return "Úterý";
            }
            else if (iCisloDne == 3)
            {
                return "Středa";
            }
            else if (iCisloDne == 4)
            {
                return "Čtvrtek";
            }
            else if (iCisloDne == 5)
            {
                return "Pátek";
            }
            else if (iCisloDne == 6)
            {
                return "Sobota";
            }
            else if (iCisloDne == 7)
            {
                return "Neděle";
            }
            else
            {
                return "Je potřeba zadat hodnotu 1-7";
            }

        }



        public static string VratNazevDneDleCislaArray(int iCislo)
        {
            var aDny = new[] {
                "pondělí",
                "úterý",
                "středa",
                "čtvrtek",
                "pátek",
                "sobota",
                "neděle"
            };

            // zkusim vratit hodnotu
            try
            {
                return aDny[iCislo - 1];
            }
            catch
            {
                throw new Exception("Je potřeba zadat hodnotu 1-7");
            }
        }




        public static string VratNazevDneDleCislaList(int iCislo)
        {
            var lDny = new List<string> { 
                "pondělí",
                "úterý",
                "středa",
                "čtvrtek",
                "pátek",
                "sobota",
                "neděle"
            };

            // zkusim vratit hodnotu
            try
            {
                return lDny[iCislo - 1];
            }
            catch
            {
                throw new Exception("Je potřeba zadat hodnotu 1-7");
            }
        }


        public static bool VratJePracovniDen(int iCisloDne)
        {
            switch (iCisloDne)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return true;
                case 6:
                case 7:
                    return false;
                default:
                    throw new Exception("Číslo dne musí být v rozsahu 1-7!");
            }

        }



    }
}
