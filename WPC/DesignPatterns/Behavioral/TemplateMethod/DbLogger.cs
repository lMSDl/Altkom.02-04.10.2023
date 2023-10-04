using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    class DbLogger : Logger<LogEntity, DbService>
    {
        protected override void Save(DbService service, LogEntity messageToLog)
        {
            service.Log(messageToLog);
        }

        protected override LogEntity PrepareLog(string message)
        {
            Console.WriteLine("Serializing message");
            return new LogEntity { Message = message.ToString(), DateTime = DateTime.Now };
        }

        protected override DbService OpenService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DbService();
        }

        protected override string AddTimestamp(string message)
        {
            return message;
        }
    }
}
