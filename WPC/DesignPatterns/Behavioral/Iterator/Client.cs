using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    class Client
    {
        public static void Execute()
        {
            List<string> list = new List<string> { "1", "2", "3", "4" };

            var itemBuffer = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(itemBuffer + list[i]);
                itemBuffer = list[i];
            }



        }
    }
}
