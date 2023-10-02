using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {

        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public void Execute(IElevatorOperation action, int floor)
        {
            action?.Operate(floor);
        }

        public void Execute(string action, int floor)
        {
            Execute(CreateAction(action), floor);
        }

        public IElevatorOperation CreateAction(string action)
        {
            IElevatorOperation elevatorOperation = null;
            if (_operations.TryGetValue(action, out elevatorOperation))
            {
                return elevatorOperation;
            }

            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    elevatorOperation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    elevatorOperation = new ElevatorUp();
                    break;
                case nameof(ElevatorGoTo):
                    elevatorOperation = new ElevatorGoTo();
                    break;
            }
            _operations[action] = elevatorOperation;
            return elevatorOperation;
        }
    }
}
