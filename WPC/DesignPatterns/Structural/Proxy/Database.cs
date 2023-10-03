using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Proxy
{
    class Database : IDatabase
    {
        private int _connectionsCounter = 0;


        public async Task<int?> RequestAsync(int @int)
        {
            if (_connectionsCounter >= 5)
            {
                Console.WriteLine($"Request {@int} dropped!");
                return null;
            }

            Interlocked.Increment(ref _connectionsCounter);
            Console.WriteLine($"Opening connection {_connectionsCounter}");

            await Task.Delay(new Random().Next(500, 2500));
            Console.WriteLine($"Request {@int} completed ({_connectionsCounter})");
            Interlocked.Decrement(ref _connectionsCounter);
            return @int;
        }
    }
}
