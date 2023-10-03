using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.II
{
    class DbPeopleServiceAdapter : IPeopleService
    {
        private readonly DbPeopleService _service;

        public DbPeopleServiceAdapter(DbPeopleService service)
        {
            _service = service;
        }

        public IEnumerable<Person> GetPeople()
        {
            var people = _service.Read();
            return people.Select(x => new Person { Name = $"{x.FirstName} {x.LastName}", Age = DateTime.Now.Year - x.BirthDate.Year });
        }
   }
}
