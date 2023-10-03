using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Singleton
{
    public class Context
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        public Context()
        {
            Console.WriteLine("Inicjalizacja ustawień");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }
    }
}
