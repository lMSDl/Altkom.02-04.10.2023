using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    class EmailLogger
    {
        public void Log(object message)
        {
            string messageToLog = SerializeMessage(message);
            SendLogToEmail(messageToLog);
        }
        private string SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
        private void SendLogToEmail(string message)
        {
            Console.WriteLine("Sending Email with Log Message : " + message);
        }
    }
}
