using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 100);

            //new Vehicle.VehicleBuilder().Build();

            Console.WriteLine(vehicle);


            var vehicleBuilder = new VehicleBuilder();
            vehicleBuilder.SetWheels(4);
            vehicleBuilder.SetSeats(5);
            vehicleBuilder.SetTrunkCapacity(500);
            vehicleBuilder.SetEnginePower(100);
            vehicleBuilder.SetDoors(4);

            vehicle = vehicleBuilder.Build();

            Console.WriteLine(vehicle);
        }
    }
}
