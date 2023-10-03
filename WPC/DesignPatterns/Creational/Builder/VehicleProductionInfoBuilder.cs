using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Builder
{
    public class VehicleProductionInfoBuilder : VehicleBuilderFacade
    {
        public VehicleProductionInfoBuilder()
        {
        }

        public VehicleProductionInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }



        public VehicleProductionInfoBuilder SetManufacturerName(string value)
        {
            Vehicle.ManufacturerName = value;
            return this;
        }
        public VehicleProductionInfoBuilder SetProductionDate(DateTime value)
        {
            Vehicle.ProductionDate = value;
            return this;
        }
    }
}
