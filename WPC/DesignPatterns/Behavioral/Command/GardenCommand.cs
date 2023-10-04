using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    abstract class GardenCommand : ICommand
    {
        protected Garden Garden { get; }
        protected string PlantName { get; }

        protected GardenCommand(Garden garden, string plantName)
        {
            Garden = garden;
            PlantName = plantName;
        }

        public abstract bool Execute();
        public abstract void Reverse();
    }
}
