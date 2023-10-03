using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Composite
{
    abstract class Composite : IComponent
    {
        public string Name => GetType().Name;
        public ICollection<IComponent> Components { get; set; } = new List<IComponent>();
        public float GetValue()
        {
            var value = Components.Sum(x => x.GetValue());
            Console.WriteLine($"Wartość {Name} to {value}");
            return value;
        }
    }
}
