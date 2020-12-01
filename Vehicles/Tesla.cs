using System;

namespace inheritance
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Battery charging for this rich person Tesla.");
        }

        public override void Drive()
        {
            Console.WriteLine("Zzzzzzzzz!");
        }
    }
}