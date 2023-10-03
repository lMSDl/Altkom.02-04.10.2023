using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.I
{
    static class SerializerFacade
    {

        private static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings() { DateFormatString = "yy-MMM_d", DefaultValueHandling = DefaultValueHandling.Ignore };

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Settings);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
