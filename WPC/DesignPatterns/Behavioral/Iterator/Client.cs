using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
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

            Buffer<string> buffer = new Buffer<string>(list);
            var iterator = buffer.GetEnumerator();
            while(iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current.Item1 + iterator.Current.Item2);
            }

            foreach(var item in buffer)
            {
                Console.WriteLine(item.Item1 + item.Item2);
            }

            //alternatywa: RX Extensions
            list.ToObservable().Buffer(2, 1).Where(x => x.Count == 2).ForEach(x => Console.WriteLine(x[0] + x[1]));

        }
    }
}
