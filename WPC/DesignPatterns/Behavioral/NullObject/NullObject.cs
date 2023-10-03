using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.NullObject
{
    class NullObject : AbstractObject
    {
        public override void Method1()
        {
        }

        public override void Method2()
        {
        }
        new public void Method3()
        {
        }
    }
}
