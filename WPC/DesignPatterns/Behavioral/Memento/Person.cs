using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Memento
{
    class Person : ICloneable, IRestorable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            FirstName = state.FirstName;
            LastName = state.LastName;
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
