using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Flyweight
{
    public class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        [JsonIgnore]
        public string Manufacturer { get => CarFlyweight.Manufacturer; set => CarFlyweight.Manufacturer = value; }
        [JsonIgnore]
        public string Model { get => CarFlyweight.Model; set => CarFlyweight.Model = value; }
        [JsonIgnore]
        public string Color { get => CarFlyweight.Color; set => CarFlyweight.Color = value; }

        [JsonIgnore]
        public CarFlyweight CarFlyweight { get; set; } = new CarFlyweight();

        public void ShowInfo()
        {
            CarFlyweight.ShowInfo(this);
        }
    }
}
