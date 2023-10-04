using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Observer
{
    class SubscriberB : Subscriber
    {
        public override void OnNext(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine("SubscriberB zareagował");
            }
        }
    }
}
