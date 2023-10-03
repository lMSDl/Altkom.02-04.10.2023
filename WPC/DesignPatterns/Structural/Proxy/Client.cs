using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Proxy
{
    class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();

            //database = new DatabaseProxy(database);
            database = new DatabaseProxy(database, () => new Database());



            for (int i = 0; i < 10; i++)
            {
                _ = database.RequestAsync(i + 1);
            }
            Console.ReadLine();

            for (int i = 0; i < 15; i++)
            {
                _ = database.RequestAsync(i + 1);
            }
            Console.ReadLine();
        }
    }
}
