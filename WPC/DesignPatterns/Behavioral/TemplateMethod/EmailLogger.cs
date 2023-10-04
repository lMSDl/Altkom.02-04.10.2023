using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    class EmailLogger : Logger<string, IDisposable>
    {
        protected override void Save(IDisposable _, string messageToLog)
        {
            Console.WriteLine("Sending Email with Log Message : " + messageToLog);
        }

        protected override string PrepareLog(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }

        protected override void OnServceOpen()
        {
        }

        protected override void OnSaving()
        {
        }
    }
}
