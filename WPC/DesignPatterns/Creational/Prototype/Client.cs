using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Prototype
{
    class Client
    {
        public static void Execute()
        {
            var p0 = new Person { Name = "Ewa Tomaszewska", Age = 55, Address = new Address { City = "Kraków", Street = "Warszawska" } };

            Console.WriteLine(p0);
            var p1 = new Person();
            p1.Name = "Tomasz Tomaszewski";
            p1.Age = 25;
            p1.Address = new Address { City = "Warszawa", Street = "Krakowska" };
            Console.WriteLine(p1);

            p0.Children = new List<Person> { p1 };

            var p2 = (Person)p0.Clone();
            p2.Name = "Adam Tomaszewski";
            Console.WriteLine(p2);

            p0.Address.City = "Warszawa";
            p0.Address.Street = "Krakowska";

            Console.WriteLine(p0);
            Console.WriteLine(p2);

            p2.Children.Add(new Person() { Age = 1, Name = "Edward" });


            Console.WriteLine(p0);
            Console.WriteLine(p2);
        }
    }
}
