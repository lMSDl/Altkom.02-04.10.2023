using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.NullObject
{
    abstract class AbstractObject
    {

        public virtual void Method1()
        {
            Console.WriteLine("1");
        }
        public abstract void Method2();
    }
}
