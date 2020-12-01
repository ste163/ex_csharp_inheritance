using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna myCessna = new Cessna();
            Ram myRam = new Ram();
            Tesla myTesla = new Tesla();
            Zero myZero = new Zero();

            // Cessna
            myCessna.MainColor = "blue";
            Console.Write($"A {myCessna.MainColor} Cessna flies, ");
            myCessna.Drive();
            Console.WriteLine(", overhead!");

            // Ram
            myRam.MainColor = "camo";
            Console.Write($"A {myRam.MainColor} Ram barrels past you. The disgusting diesel engine vomits black exhaust with a ");
            myRam.Drive();
            Console.WriteLine("");

            // Tesla
            myTesla.MainColor = "white";
            Console.Write($"A {myTesla.MainColor} Tesla zips past you. The electric engine goes ");
            myTesla.Drive();
            Console.WriteLine("");
            
            // Zero
            myZero.MainColor = "black";
            Console.Write($"A {myZero.MainColor} Zero careens past you. The electric engine whines ");
            myZero.Drive();
            Console.WriteLine("");
        }
    }
}
