using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Data
{
    class DateOperations
    {

        public static string VratNazevDneDleCisla( int iCisloDne )
        {
            switch (iCisloDne)
            {
                case 1:
                    return "Pondělí";
                    break;
                case 2:
                    return "Úterý";
                    break;
                case 3:
                    return "Středa";
                    break;
                case 4:
                    return "Čtvrtek";
                    break;
                case 5:
                    return "Pátek";
                    break;
                case 6:
                    return "Sobota";
                    break;
                case 7:
                    return "Neděle";
                    break;
                default:
                    return "je potřeba zadat hodnotu 1-7";
                    break;
            }

        }


    }
}
