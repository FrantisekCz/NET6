using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World.Data
{
    class DateOperations
    {

        private static string[] aDny = new[] {
                                        "pondělí",
                                        "úterý",
                                        "středa",
                                        "čtvrtek",
                                        "pátek",
                                        "sobota",
                                        "neděle"
                                    };


        private static List<string> lDny = new List<string> {
                                        "pondělí",
                                        "úterý",
                                        "středa",
                                        "čtvrtek",
                                        "pátek",
                                        "sobota",
                                        "neděle"
                                    };

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

            // zkusim vratit hodnotu
            try
            {
                return lDny.ElementAt(iCislo-1);
                // lze i takto a chyba nevznikne
                // return lDny.ElementAtOrDefault(iCislo);

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



        public static int VratCisloDneDleNazvuSwitch( string sNazevDne)
        {
            switch( sNazevDne.ToLower())
            {
                case "pondělí":
                    return 1;
                case "úterý":
                    return 2;
                case "středa":
                    return 3;
                case "čtvrtek":
                    return 4;
                case "pátek":
                    return 5;
                case "sobota":
                    return 6;
                case "neděle":
                    return 7;
                default:
                    return 0;
            }
        }


        public static int VratCisloDneDleNazvuArray(string sNazevDne)
        {
            for (int iCnt = 0; iCnt < aDny.Count(); iCnt++)
            {
                if (sNazevDne.ToLower() == aDny[iCnt]) return iCnt + 1;

            }
            // default
            return -1;
        }

        public static int VratCisloDneDleNazvuList(string sNazevDne)
        {
            return lDny.IndexOf( sNazevDne.ToLower() )+1;
        }

    }
}
