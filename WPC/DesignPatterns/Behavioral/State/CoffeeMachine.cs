using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.State
{
    class CoffeeMachine
    {
        private State state;

        public State State
        {
            get => state;
            set
            {
                state = value;
                Console.WriteLine($"Zmiana stanu na { value.GetType().Name }");
            }
        }

        public CoffeeMachine()
        {
            State = new HeatingUpState(this);
        }


        public void LargeCoffee()
        {
            State.Large();
        }
        public void SmallCoffee()
        {
            State.Small();
        }
    }
}
