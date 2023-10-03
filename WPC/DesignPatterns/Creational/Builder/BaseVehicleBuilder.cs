using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    public abstract class BaseVehicleBuilder
    {
        protected Vehicle Vehicle { get; } = new Vehicle();

        public BaseVehicleBuilder()
        {
        }

        protected BaseVehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
