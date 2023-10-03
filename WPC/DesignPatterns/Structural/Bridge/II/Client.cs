using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Bridge.II
{
    class Client
    {
        public static void Execute()
        {
            var abstraction = new MessageAbstraction(new SmsGate());

            abstraction.Send(Console.ReadLine());

            abstraction = new MessageAbstraction(new EmailGate());

            abstraction.Send(Console.ReadLine());
        }
    }
}
