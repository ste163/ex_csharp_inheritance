using System;

namespace inheritance
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 56;
        }

        public override void Drive()
        {
            Console.Write("GRAAAAA");
        }
    }
}