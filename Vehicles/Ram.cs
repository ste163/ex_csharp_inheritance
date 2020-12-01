using System;

namespace inheritance
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 23;
        }

        public override void Drive()
        {
            Console.Write("Grumble grumble grumble!");
        }
    }
}