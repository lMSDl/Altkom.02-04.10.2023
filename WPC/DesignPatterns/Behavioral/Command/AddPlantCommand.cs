using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    class AddPlantCommand : GardenCommand
    {
        public AddPlantCommand(Garden garden, string plantName) : base(garden, plantName)
        {
        }

        public override bool Execute()
        {
            return Garden.Add(PlantName);
        }

        public override void Reverse()
        {
            Garden.Remove(PlantName);
        }
    }
}
