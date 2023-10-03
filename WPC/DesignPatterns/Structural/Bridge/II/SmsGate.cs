using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Bridge.II
{
    class SmsGate : IMessageSenderImplenetation
    {
        public const int MaxLength = 10;
        public void SendMessage(string message)
        {
            foreach (var item in Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MaxLength))
                                   .Select(x => message.Substring(x * MaxLength, Math.Min(MaxLength, message.Length - x * MaxLength))))
            {
                Console.WriteLine($"Wiadomość została wysłana przez Sms: {item}");
            }
        }
    }
}
