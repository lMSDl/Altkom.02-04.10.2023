using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Bridge.II
{
    class EmailGate : IMessageSenderImplenetation
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Wiadmość e-mail: {message}");
        }
    }
}
