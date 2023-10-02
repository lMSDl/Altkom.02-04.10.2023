using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.SOLID.L
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("I am driving!");
        }

        public override void Move()
        {
            Drive();
        }
    }

    class Airplane : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public override void Move()
        {
            Fly();
        }
    }

    /*class Car : Vehicle
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }

    class Airplane : Vehicle
    {
        public override void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }*/
}
