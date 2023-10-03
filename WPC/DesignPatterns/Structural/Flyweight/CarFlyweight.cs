using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    public class CarFlyweight : ICloneable
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void ShowInfo(Car car)
        {
            string shared = JsonConvert.SerializeObject(this);
            string unique = JsonConvert.SerializeObject(car);
            Console.WriteLine($"Flyweight: Displaying shared {shared} and unique {unique} state.");
        }
    }
}
