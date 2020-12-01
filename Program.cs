using System;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            // Get initial charge
            electricVehicles.ForEach(v => Console.WriteLine($"{v.BatteryKWh}"));
            // Charge battery to 100%
            electricVehicles.ForEach(v => v.ChargeBattery());
            // Get the new charge
            electricVehicles.ForEach(v => Console.WriteLine($"{v.BatteryKWh}"));

            // /***********************************************/

            // Ram ram = new Ram ();
            // Cessna cessna150 = new Cessna ();

            // List<???> gasVehicles = new List<???>() {
            //     ram, cessna150
            // };

            // Console.WriteLine("Gas Vehicles");
            // foreach(??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }

            // foreach(??? gv in gasVehicles)
            // {
            //     // This should completely refuel the gas tank
            //     gv.RefuelTank();
            // }

            // foreach(??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }
        }
    }
}
