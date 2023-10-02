using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    class Client
    {
        public static void Execute()
        {

            var elevator = new Elevator();

            var action = "Down";

            elevator.Execute(action, 3);
            action = "GoTo";

            elevator.Execute(action, 3);
        }
    }
}
