using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    public class Vehicle : ICloneable
    {
        //builder wbudowany w klasę pozwala na zablokowanie metody konstrukcyjnej (prywatna metoda konstrukcyjne) i w ten sposób staje się jednym sposobem wytworzenia obiektu danej klasy
        /*public class VehicleBuilder
        {
            private Vehicle _vehicle = new Vehicle();


            public Vehicle Build()
            {
                return _vehicle;
            }
        }*/

        public Vehicle()
        {

        }
        public Vehicle(int wheels, int seats)
        {
            Wheels = wheels;
            Seats = seats;
        }
        public Vehicle(int wheels, int seats, int doors) : this(wheels, seats)
        {
            Doors = doors;
        }
        public Vehicle(int wheels, int seats, int? trunkCapacity) : this(wheels, seats)
        {
            TrunkCapacity = trunkCapacity;
        }
        /*public Vehicle(int wheels, int seats, int? enginePower) : this(wheels, seats)
        {
            EnginePower = enginePower;
        }*/
        public Vehicle(int wheels, int? enginePower, int seats) : this(wheels, seats)
        {
            EnginePower = enginePower;
        }
        public Vehicle(int wheels, int seats, int doors, int? trunkCapacity, int? enginePower) : this(wheels, seats, doors)
        {
            TrunkCapacity = trunkCapacity;
            EnginePower = enginePower;
        }

        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }


        public string ManufacturerName { get; set; }
        public DateTime ProductionDate { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Obiekt ma {Wheels} kół, {Seats} siedzeń, {Doors} drzwi" + (TrunkCapacity.HasValue ? $", pojemność bagażnika {TrunkCapacity}" : "") + (EnginePower.HasValue ? $", moc silnika {EnginePower}HP" : "");
        }

    }
}
