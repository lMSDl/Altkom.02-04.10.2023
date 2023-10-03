using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.II
{
    class DbPeopleService
    {
        private ICollection<DbPerson> _people = new List<DbPerson> { new DbPerson { FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-36) },
                                                                     new DbPerson { FirstName = "Adam", LastName = "Adamski", BirthDate = DateTime.Now.AddYears(-44) }};

        public IEnumerable<DbPerson> Read()
        {
            return _people.ToList();
        }
    }
}
