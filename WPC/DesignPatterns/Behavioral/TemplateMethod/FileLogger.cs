using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    class FileLogger : Logger<string, FileService>
    {
        protected override void Save(FileService service, string messageToLog)
        {
            service.Appen(messageToLog);
        }

        protected override string PrepareLog(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }

        protected override FileService OpenService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }
    }
}
