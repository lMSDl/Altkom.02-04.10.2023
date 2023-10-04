using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    class RemovePlantCommand : GardenCommand
    {
        public RemovePlantCommand(Garden garden, string plantName) : base(garden, plantName)
        {
        }

        public override bool Execute()
        {
            return Garden.Remove(PlantName);
        }

        public override void Reverse()
        {
            Garden.Add(PlantName);
        }
    }
}
