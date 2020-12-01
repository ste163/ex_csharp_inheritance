using System;

namespace inheritance
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine("Zzzzzzzzz!");
        }
    }
}