using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    class FileService : IDisposable
    {
        public void Appen(string text) {
            Console.WriteLine("Appending Log message to file : " + text);
        }

        public void Dispose()
        {
            Console.WriteLine("Close File.");
        }
    }
}
