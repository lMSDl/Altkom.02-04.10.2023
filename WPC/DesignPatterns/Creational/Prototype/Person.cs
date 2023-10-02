using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Prototype
{
    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public ICollection<Person> Children { get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address.Clone();
            clone.Children = Children.ToList(); //Children.Select(x => (Person)x.Clone()).ToList();
            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
