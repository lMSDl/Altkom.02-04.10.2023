using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    abstract class Logger<T, TService>  where TService : IDisposable
    {

        public void Log(string message)
        {
            message = AddTimestamp(message);
            T messageToLog = PrepareLog(message);
            using (TService service = OpenService())
            {
                Save(service, messageToLog);
            }
        }

        protected virtual string AddTimestamp(string message)
        {
            return $"{DateTime.Now.ToShortTimeString()}: {message}";
        }

        protected abstract void Save(TService service, T messageToLog);
        protected virtual TService OpenService()
        {
            return default;
        }
        protected abstract T PrepareLog(string message);
    }
}
