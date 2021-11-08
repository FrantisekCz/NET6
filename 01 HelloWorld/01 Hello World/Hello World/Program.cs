using System;
using System.IO;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            while( ZjistiZapisJmenoVek() )
            {
                // vykonavej dokud nevratim false
            };


        }

        static bool ZjistiZapisJmenoVek()
        {
            Console.WriteLine(Environment.NewLine + "Zadejte své jméno (x pro konec):");
            string sJmeno = Console.ReadLine();
            if (sJmeno == "x") return false;
            Console.WriteLine("Zadejte svůj věk:");
            string sVek = Console.ReadLine();

            File.AppendAllText("jmena.txt", ($"{sJmeno};{sVek}" + Environment.NewLine));
            return true;
            
        }
    }
}
