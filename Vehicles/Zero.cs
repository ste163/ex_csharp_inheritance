using System;

namespace inheritance
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine("BBBbbzzzzz!");
        }
    }
}