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

            myZero.Drive();
        }
    }
}
