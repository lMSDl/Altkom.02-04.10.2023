using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    class FileLogger
    {


        public void Log(object message)
        {
            string messageToLog = SerializeMessage(message);
            var service = OpenFile();
            WriteLogMessage(messageToLog, service);
            CloseFile(service);
        }
        private string SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
        private FileService OpenFile()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }
        private void WriteLogMessage(string message, FileService fileService)
        {
            fileService.Appen(message);
        }
        private void CloseFile(FileService fileService)
        {
            fileService.Dispose();
        }
    }
}
