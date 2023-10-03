using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.NullObject
{
    class RealObject : AbstractObject
    {
        public override void Method2()
        {
            Console.WriteLine("2");
        }
    }
}
