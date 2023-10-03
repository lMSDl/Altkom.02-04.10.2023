using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Decorator
{
    internal class Notification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Wysłano notyfikację wewnętrzą: {message}");
        }
    }
}
