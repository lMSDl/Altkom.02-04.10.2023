using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    class ElevatorGoTo : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Winda rusza na piętro {floor}");
        }
    }
}
