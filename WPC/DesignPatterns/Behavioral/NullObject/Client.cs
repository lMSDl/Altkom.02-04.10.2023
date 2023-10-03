using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.NullObject
{
    class Client
    {
        public static void Execute()
        {
            var objects = new AbstractObject[] { new RealObject(), null };

            var random = new Random();

            while (true)
            {
                var value = random.Next(0, objects.Length);

                Console.ReadLine();

                //if (objects[value] != null)
                {
                    objects[value]?.Method1();
                    objects[value]?.Method2();
                }
            }
        }
    }
}
