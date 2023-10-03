using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.I
{
    class Client
    {
        public static void Execute()
        {
            var person = new Person() { Name = "Ewa Ewowska", BirthDate = DateTime.Now };

            //var settings = new JsonSerializerSettings() { DateFormatString = "yy-MMM_d", DefaultValueHandling = DefaultValueHandling.Ignore };
            //var json = JsonConvert.SerializeObject(person, settings);


            var json = SerializerFacade.Serialize(person);
            Console.WriteLine(json);
        }
    }
}
