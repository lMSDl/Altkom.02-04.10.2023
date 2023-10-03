using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Singleton
{
    class Client
    {
        public static void Execute()
        {
            var service1 = new Context().GetSettings("1");
            Console.WriteLine($"Service: {service1}");

            var service2 = new Context().GetSettings("2");
            Console.WriteLine($"Service: {service2}");

            new Context().SetSettings("2", "X");
            service2 = new Context().GetSettings("2");
            Console.WriteLine($"Service: {service2}");
        }
    }
}
