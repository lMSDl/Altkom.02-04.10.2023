using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.II
{
    class Product
    {
        public virtual void PrintType()
        {
            Console.WriteLine("Product");
        }
    }
}
