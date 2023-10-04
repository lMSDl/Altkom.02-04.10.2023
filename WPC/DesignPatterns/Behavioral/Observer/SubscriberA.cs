using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Observer
{
    class SubscriberA : Subscriber
    {
        public override void OnNext(int value)
        {
            if (value > 30)
            {
                Thread.Sleep(5000);
                Console.WriteLine("SubscriberA zareagował");
            }
        }
    }
}
