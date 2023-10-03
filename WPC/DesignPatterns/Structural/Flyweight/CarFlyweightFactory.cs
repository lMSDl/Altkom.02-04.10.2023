using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    class CarFlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public CarFlyweightFactory(params CarFlyweight[] flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => GenerateKey(x));
        }

        private string GenerateKey(CarFlyweight flyweight)
        {
            return string.Join("_", flyweight.Manufacturer, flyweight.Model, flyweight.Color);
        }

        public CarFlyweight GetFlyweight(CarFlyweight flyweight)
        {
            var key = GenerateKey(flyweight);
            if (!_flyweights.ContainsKey(key))
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                _flyweights.Add(key, flyweight);
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return _flyweights[key];
        }


        public void ShowFlyweights()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight.Key);
            }
        } 
    }
}
