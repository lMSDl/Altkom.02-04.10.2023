using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.II
{
    interface IPeopleService
    {
        IEnumerable<Person> GetPeople();
    }
}
