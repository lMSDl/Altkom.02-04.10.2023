using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.II
{
    class BoxedProduct : Product
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void PrintType()
        {
            Console.WriteLine("BoxedProduct");
        }
    }
}
