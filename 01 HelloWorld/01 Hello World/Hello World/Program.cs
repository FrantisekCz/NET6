using System;
using System.IO;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine(Environment.NewLine + "Zadejte své jméno (x pro konec):");
                string sJmeno = Console.ReadLine();
                if (sJmeno == "x") return;  // nasilne ukonci program; = halt
                Console.WriteLine("Zadejte svůj věk:");
                string sVek = Console.ReadLine();

                File.AppendAllText("jmena.txt", ($"{sJmeno};{sVek}" + Environment.NewLine));
            }
        }

    }
}
