using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    class DbService : IDisposable
    {
        public void Log(LogEntity entity)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + entity);
        }

        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }
    }
}
