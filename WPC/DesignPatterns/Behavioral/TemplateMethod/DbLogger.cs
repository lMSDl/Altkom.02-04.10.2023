using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    class DbLogger
    {
        private DbService dbService = new DbService();

        public void Log(string message)
        {
            var messageToLog = SerializeMessage(message);
            ConnectToDatabase();
            InsertLogMessageToTable(messageToLog);
            CloseDbConnection();
        }
        private LogEntity SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return new LogEntity { Message = message.ToString() };
        }
        private void ConnectToDatabase()
        {
            Console.WriteLine("Connecting to Database.");
        }
        private void InsertLogMessageToTable(LogEntity entity)
        {
            dbService.Log(entity);
        }
        private void CloseDbConnection()
        {
            dbService.Dispose();
        }
    }
}
