using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Hello World!");
            Console.WriteLine("Jak se jmenuješ?");
            // necháme si předat od uživatele jméno
            string sName = Console.ReadLine();

            string sPozdrav = "Ahoj, ty jsi " + sName;
            Console.WriteLine(sPozdrav);
        }
    }
}
