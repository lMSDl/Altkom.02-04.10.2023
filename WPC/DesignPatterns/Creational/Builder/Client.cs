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
            vehicle = vehicleBuilder.Build();
            vehicle.EnginePower = 150;
            vehicle = vehicleBuilder.Build();

            Console.WriteLine(vehicle);

            vehicle = new VehicleBuilder()
                        .Parts
                            .SetWheels(4)
                            .SetSeats(5)
                        .Production
                            .SetManufacturerName("Altkom")
                            .SetProductionDate(DateTime.Now)
                        .Parts
                            .SetTrunkCapacity(500)
                            .SetEnginePower(100)
                            .SetDoors(4)
                        .Build();
            Console.WriteLine(vehicle);

            vehicle = new Vehicle { Doors = 4, EnginePower = 100, TrunkCapacity = 500, Seats = 5, Wheels = 4 };
            Console.WriteLine(vehicle);
        }
    }
}
