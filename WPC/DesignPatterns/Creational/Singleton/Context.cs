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

        private Context()
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

        //private static Context _instance;
        //brak zabezpieczenia przed dostępem wielowątkowym
        /*public static Context GetInstance()
        {
            if(_instance == null)
                _instance = new Context();

            return _instance;
        }*/

        //private static object locker = new object();
        //wątki wstrzymywane na monitorze - tylko jeden w danym momencie dostaje dostęp
        /*public static Context GetInstance()
        {
            lock (locker)
            {
                if (_instance == null)
                    _instance = new Context();
            }
            return _instance;
        }*/

        //problem z poprzedniego przykładu występuje tylko przy pierwszym wywołaniu
        /*public static Context GetInstance()
        {
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                        _instance = new Context();
                }
            }
            return _instance;
        }*/

        //domyślna implementacla dla C# - prawie "lazy"
        static Context() { } //wyłącza flagę beforeFieldInit
        public static Context Instance { get; } = new Context();


        //full-lazy
        /*private static Lazy<Context> _lazyInstance = new Lazy<Context>(() => new Context());
        public static Context GetInstance() => _lazyInstance.Value;*/
    }
}
